using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

using Pixels;

namespace Pixels
{
    public partial class Pixel<T>
    {
	/*
		public static explicit operator Pixel<Byte>(Pixel<T> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (Byte)(object)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}
		public static explicit operator Pixel<UInt16>(Pixel<T> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (UInt16)(object)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}
		public static explicit operator Pixel<UInt32>(Pixel<T> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (UInt32)(object)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}
		public static explicit operator Pixel<UInt64>(Pixel<T> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (UInt64)(object)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}
		public static explicit operator Pixel<Int16>(Pixel<T> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (Int16)(object)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}
		public static explicit operator Pixel<Int32>(Pixel<T> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (Int32)(object)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}
		public static explicit operator Pixel<Int64>(Pixel<T> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (Int64)(object)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}
		public static explicit operator Pixel<Single>(Pixel<T> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (Single)(object)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}
		public static explicit operator Pixel<Double>(Pixel<T> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				//dst[c++] = (Double)(object)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}

        public static Pixel<T> operator <<(Pixel<T> src, int value)
        {
            switch ((object)src)
            {
                case Pixel<Byte> a:
                    Pixel<Byte> dst_Byte = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Byte[x, y] = (Byte)(a[x, y] << value);
                    return (dynamic)dst_Byte;
                case Pixel<UInt16> a:
                    Pixel<UInt16> dst_UInt16 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_UInt16[x, y] = (UInt16)(a[x, y] << value);
                    return (dynamic)dst_UInt16;
                case Pixel<UInt32> a:
                    Pixel<UInt32> dst_UInt32 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_UInt32[x, y] = (UInt32)(a[x, y] << value);
                    return (dynamic)dst_UInt32;
                case Pixel<UInt64> a:
                    Pixel<UInt64> dst_UInt64 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_UInt64[x, y] = (UInt64)(a[x, y] << value);
                    return (dynamic)dst_UInt64;
                case Pixel<Int16> a:
                    Pixel<Int16> dst_Int16 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Int16[x, y] = (Int16)(a[x, y] << value);
                    return (dynamic)dst_Int16;
                case Pixel<Int32> a:
                    Pixel<Int32> dst_Int32 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Int32[x, y] = (Int32)(a[x, y] << value);
                    return (dynamic)dst_Int32;
                case Pixel<Int64> a:
                    Pixel<Int64> dst_Int64 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Int64[x, y] = (Int64)(a[x, y] << value);
                    return (dynamic)dst_Int64;
				default:
					throw new ArithmeticException();
            }
        }
		public static Pixel<T> operator *(Pixel<T> src, T value)
        {
            switch ((object)src)
            {
                case Pixel<Byte> a:
                    Pixel<Byte> dst_Byte = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Byte[x, y] = (Byte)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_Byte;
                case Pixel<UInt16> a:
                    Pixel<UInt16> dst_UInt16 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_UInt16[x, y] = (UInt16)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_UInt16;
                case Pixel<UInt32> a:
                    Pixel<UInt32> dst_UInt32 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_UInt32[x, y] = (UInt32)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_UInt32;
                case Pixel<UInt64> a:
                    Pixel<UInt64> dst_UInt64 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_UInt64[x, y] = (UInt64)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_UInt64;
                case Pixel<Int16> a:
                    Pixel<Int16> dst_Int16 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Int16[x, y] = (Int16)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_Int16;
                case Pixel<Int32> a:
                    Pixel<Int32> dst_Int32 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Int32[x, y] = (Int32)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_Int32;
                case Pixel<Int64> a:
                    Pixel<Int64> dst_Int64 = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Int64[x, y] = (Int64)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_Int64;
                case Pixel<Single> a:
                    Pixel<Single> dst_Single = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Single[x, y] = (Single)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_Single;
                case Pixel<Double> a:
                    Pixel<Double> dst_Double = a.Clone();
                    for (int y = 0; y < a.Height; y++)
                        for (int x = 0; x < a.Width; x++)
                            dst_Double[x, y] = (Double)(a[x, y] * (dynamic)value);
                    return (dynamic)dst_Double;
				default:
					throw new ArithmeticException();
            }
        }
		*/
    }
}