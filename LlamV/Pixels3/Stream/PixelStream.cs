using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

using System.Reflection;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

using System.IO.Compression;
using System.Threading.Tasks;

namespace Pixels.Stream
{
    public static partial class PixelStream
    {
        public static Pixel<T> Read<T>(this Pixel<T> src, string filename, int offsetbyte, String type) where T : struct, IComparable
            => Read(src, filename, offsetbyte, System.Type.GetType($"System.{type}"));
        public static Pixel<T> Read<T>(this Pixel<T> src, string filename, int offsetbyte = 0, Type type = null) where T : struct, IComparable
        {
            byte[] data = System.IO.File.ReadAllBytes(filename);
            _Read(data, src.pixel, offsetbyte, type?.Name);
            return src;
        }

        public static void Write<T>(this Pixel<T> src, string filename, bool selected = false) where T : struct, IComparable
        {
            if (!System.IO.Directory.Exists(Path.GetDirectoryName(filename)))
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(filename));

            if (!selected)
            {
                src = src["Full"];
            }

            using (FileStream sw = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                int bytesize = Marshal.SizeOf<T>();
                WriteArray(src.pixel, sw);
            }
        }

        public static void WriteText<T>(this Pixel<T> src, string filename, string delimiter = ", ", bool selected = false) where T : struct, IComparable
        {
            if(!selected)
            {
                src = src["Full"];
            }
            int w = src.Width;
            int h = src.Height;
            int depth = 255;

            using (StreamWriter sw = new StreamWriter(filename))
            {
                /* 
                bool pgmheader = false
                if (pgmheader)
                {
                    sw.Write($"P2\r\n");
                    sw.Write($"{w} {h}\r\n");
                    sw.Write($"{depth}\r\n");
                }
                */
                for (int y = 0; y < h; y++)
                {
                    StringBuilder buf = new StringBuilder();
                    for (int x = 0; x < w - 1; x++)
                    {
                        buf.Append(src[x,y]);
                        buf.Append(delimiter);
                    }
                    buf.Append(src[w - 1, y]);
                    buf.Append("\r\n");
                    sw.Write(buf);
                }
            }
        }

        public static string ToText<T>(this Pixel<T> src, string delimiter = ", ") where T : struct, IComparable
        {
            StringBuilder buf = new StringBuilder();

            buf.Append($"\"(Left, Top) = ({src.Left},{src.Top})\"");

            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width - 1; x++)
                {
                    buf.Append(src[x, y]);
                    buf.Append(delimiter);
                }
                buf.Append(src[src.Width - 1, y]);
                buf.Append("\r\n");
            }

            return buf.ToString();
        }

    }
}