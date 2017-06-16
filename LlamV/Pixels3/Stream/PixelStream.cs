using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.InteropServices;

using System.Windows.Media.Imaging;
using System.Windows.Media;
using Pixels.Math;

namespace Pixels.Stream/*T4namespace{*/.Base/*}T4namespace*/
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
            switch (type)
            {
                /*T4{[
                    {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
                ]T4h*/
                case "Int32": ReadInt32((dynamic)src.pixel, data, offsetbyte); break;/*}T4*/
                default:
                    break;
            }
            return src;
        }

        #region Read

        /*T4{[
            {"Key": ["UInt16"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
        ]T4h*/
        private static void ReadByte(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }/*}T4*/
        /*T4{[
            {"Key": ["Int32"], "Value": [["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
            {"Key": ["UInt16"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
        ]T4h*/
        private static void ReadInt32(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }/*}T4*/

        #endregion

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

                //配列の確保
                T[] dst = new T[s.PixelWidth * s.PixelHeight];

                int c = 1;
                switch (ch)
                {
                    case ColorChannel.R: c = 2; break;
                    case ColorChannel.B: c = 0; break;
                    case ColorChannel.A: c = 3; break;
                    case ColorChannel.G: c = 1; break;
                    default: c = 1; break;
                }

                switch ((object)dst)
                {
                    /*T4{[
                        {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
                    ]T4h*/
                    case Int32[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (Int32)src[c];
                            c += 4;
                        }
                        break;/*}T4*/
                    default:
                        break;
                }

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
                switch ((object)src)
                {
                    /*T4{[
                        {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
                    ]T4h*/
                    case Int32[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(Int32));
                        break;/*}T4*/
                    default:
                        break;
                }
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
            //int depth = 255;

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