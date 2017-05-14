using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

using Pixels;

namespace Pixels.Math
{
    public static partial class PixelMath
    {
	    public static void ConvertToByte<T>(Pixel<T> src, byte[] dst) where T : struct, IComparable
        {
            int c = 0;
            switch((object)src)
            {
                case Pixel<Byte> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<UInt16> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<UInt32> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<UInt64> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Int16> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Int32> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Int64> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Single> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Double> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                            dst[c++] = hoge;
                        }
                    break;
                default:
                    throw new NotSupportedException($"{typeof(T)}");
            }
        }
	    public static void ConvertToByteColor<T>(Pixel<T> src, byte[] dst) where T : struct, IComparable
        {
            int c = 0;
            switch((object)src)
            {
                case Pixel<Byte> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<UInt16> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<UInt32> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<UInt64> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Int16> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Int32> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Int64> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Single> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                case Pixel<Double> h:
                    for (int y = 0; y < h.Height; y++)
                        for (int x = 0; x < h.Width; x++)
                        {
                            var hoge = h[x, y].ConvertToByte();
                            dst[c++] = hoge;
                        }
                    break;
                default:
                    throw new NotSupportedException($"{typeof(T)}");
            }
        }

        public static byte ConvertToByte(this Byte value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this UInt16 value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this UInt32 value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this UInt64 value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this Int16 value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this Int32 value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this Int64 value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this Single value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
        public static byte ConvertToByte(this Double value) => (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
    }
}