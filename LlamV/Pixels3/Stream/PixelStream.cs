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
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Pixels.Math;

namespace Pixels.Stream
{
    public static partial class PixelStream
    {
        /*** read ***/

        public enum ColorChannel
        {
            R, G, B, A
        }

        public static Pixel<T> Read<T>(this Pixel<T> src, string filename, int offsetbyte, String type) where T : struct, IComparable
        {
            //type?.Name
            byte[] data = System.IO.File.ReadAllBytes(filename);
            _Read(data, src.pixel, offsetbyte, type);
            return src;
        }
        public static Pixel<T> Read<T>(this Pixel<T> src, string filename, int offsetbyte = 0, Type type = null) where T : struct, IComparable
        {
            return Read(src, filename, offsetbyte, System.Type.GetType($"System.{type}"));
        }

        public static Pixel<T> ReadBMP<T>(string filename, ColorChannel ch = ColorChannel.G) where T : struct, IComparable
        {
            using (MemoryStream data = new MemoryStream(File.ReadAllBytes(filename)))
            {
                WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                data.Close();
                // フォーマットが異なるならば変換
                BitmapSource s = wbmp;
                if (s.Format != PixelFormats.Bgra32)
                {
                    s = new FormatConvertedBitmap(
                        s,
                        PixelFormats.Bgra32,
                        null,
                        0);
                    s.Freeze();
                }

                //byteへの変換
                int stride = s.PixelWidth * s.Format.BitsPerPixel / 8;
                byte[] src = new byte[stride * s.PixelWidth];
                s.CopyPixels(src, stride, 0);

                int e = 1;
                switch (ch)
                {
                    case ColorChannel.R: e = 2; break;
                    case ColorChannel.B: e = 0; break;
                    case ColorChannel.A: e = 3; break;
                    case ColorChannel.G: e = 1; break;
                    default: e = 1; break;
                }

                //配列の確保
                T[] dst = new T[s.PixelWidth * s.PixelHeight];

                _ReadBMP<T>(src, dst, e);

                return PixelFactory.Create<T>(s.PixelWidth, s.PixelHeight, dst);
            }
        }

        /*** write ***/

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

        public static void WriteBitmap(this Pixel<byte> src, string filename, bool selected = false)
        { 
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                var i = ToBitmapSource(src, selected);
                encoder.Frames.Add(BitmapFrame.Create(i));
                encoder.Save(stream);
            }
        }
        public static WriteableBitmap ToWriteableBitmap(this Pixel<byte> src, bool selected = false)
        {
            return new WriteableBitmap(ToBitmapSource(src, selected));
        }
        public static BitmapSource ToBitmapSource(this Pixel<byte> src, bool selected = false)
        {
            var buf = src.Clone();
            if (!selected)
            {
                buf = buf["Full"];
            }
            else
            {
                buf = buf.Cut();
            }

            var _buf = BitmapImage.Create(
                buf.Width, buf.Height, 96, 96,
                System.Windows.Media.PixelFormats.Gray8,
                null,
                buf.pixel,
                (buf.Width * PixelFormats.Gray8.BitsPerPixel + 7) / 8);
            _buf.Freeze();
            return _buf;
        }


        public static string ToText<T>(this Pixel<T> src, string delimiter = ", ") where T : struct, IComparable
        {
            StringBuilder buf = new StringBuilder();

            buf.Append($"\"(Left, Top) = ({src.Left},{src.Top})\"\r\n");

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