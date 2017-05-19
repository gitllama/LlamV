






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
		//Cast


        public static Pixel<Byte> ToPixelByte(this Pixel<Byte> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<Byte> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<Byte> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<Byte> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<Byte> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<Byte> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<Byte> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<Byte> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<Byte> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<UInt16> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<UInt16> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<UInt16> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<UInt16> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<UInt16> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<UInt16> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<UInt16> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<UInt16> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<UInt16> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<UInt32> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<UInt32> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<UInt32> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<UInt32> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<UInt32> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<UInt32> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<UInt32> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<UInt32> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<UInt32> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<UInt64> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<UInt64> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<UInt64> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<UInt64> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<UInt64> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<UInt64> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<UInt64> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<UInt64> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<UInt64> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<Int16> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<Int16> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<Int16> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<Int16> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<Int16> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<Int16> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<Int16> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<Int16> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<Int16> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<Int32> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<Int32> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<Int32> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<Int32> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<Int32> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<Int32> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<Int32> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<Int32> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<Int32> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<Int64> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<Int64> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<Int64> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<Int64> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<Int64> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<Int64> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<Int64> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<Int64> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<Int64> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<Single> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<Single> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<Single> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<Single> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<Single> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<Single> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<Single> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<Single> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<Single> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}



        public static Pixel<Byte> ToPixelByte(this Pixel<Double> val)
		{
			Byte[] dst = new Byte[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Byte)i;
			}
			return PixelFactory.Create<Byte>(val.Maps, dst);
		}

        public static Pixel<UInt16> ToPixelUInt16(this Pixel<Double> val)
		{
			UInt16[] dst = new UInt16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt16)i;
			}
			return PixelFactory.Create<UInt16>(val.Maps, dst);
		}

        public static Pixel<UInt32> ToPixelUInt32(this Pixel<Double> val)
		{
			UInt32[] dst = new UInt32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt32)i;
			}
			return PixelFactory.Create<UInt32>(val.Maps, dst);
		}

        public static Pixel<UInt64> ToPixelUInt64(this Pixel<Double> val)
		{
			UInt64[] dst = new UInt64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (UInt64)i;
			}
			return PixelFactory.Create<UInt64>(val.Maps, dst);
		}

        public static Pixel<Int16> ToPixelInt16(this Pixel<Double> val)
		{
			Int16[] dst = new Int16[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int16)i;
			}
			return PixelFactory.Create<Int16>(val.Maps, dst);
		}

        public static Pixel<Int32> ToPixelInt32(this Pixel<Double> val)
		{
			Int32[] dst = new Int32[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int32)i;
			}
			return PixelFactory.Create<Int32>(val.Maps, dst);
		}

        public static Pixel<Int64> ToPixelInt64(this Pixel<Double> val)
		{
			Int64[] dst = new Int64[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Int64)i;
			}
			return PixelFactory.Create<Int64>(val.Maps, dst);
		}

        public static Pixel<Single> ToPixelSingle(this Pixel<Double> val)
		{
			Single[] dst = new Single[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Single)i;
			}
			return PixelFactory.Create<Single>(val.Maps, dst);
		}

        public static Pixel<Double> ToPixelDouble(this Pixel<Double> val)
		{
			Double[] dst = new Double[val.pixel.Length];
			int c = 0;
			foreach(var i in val.pixel)
			{
				dst[c++] = (Double)i;
			}
			return PixelFactory.Create<Double>(val.Maps, dst);
		}




		


		//別にdynamicでもよくないか？
		public static Pixel<T> Add<T>(this Pixel<T> src, Pixel<T> dst, T value) where T : struct, IComparable
        {
			if(false)
			{
			}
			else if(typeof(T) == typeof(Byte))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Single))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Double))
			{
				return Add(src, dst, value);
			}
			else
			{
				return null;
			}
		}

		//別にdynamicでもよくないか？
		public static Pixel<T> Sub<T>(this Pixel<T> src, Pixel<T> dst, T value) where T : struct, IComparable
        {
			if(false)
			{
			}
			else if(typeof(T) == typeof(Byte))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Single))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Double))
			{
				return Add(src, dst, value);
			}
			else
			{
				return null;
			}
		}

		//別にdynamicでもよくないか？
		public static Pixel<T> Mul<T>(this Pixel<T> src, Pixel<T> dst, T value) where T : struct, IComparable
        {
			if(false)
			{
			}
			else if(typeof(T) == typeof(Byte))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Single))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Double))
			{
				return Add(src, dst, value);
			}
			else
			{
				return null;
			}
		}

		//別にdynamicでもよくないか？
		public static Pixel<T> Div<T>(this Pixel<T> src, Pixel<T> dst, T value) where T : struct, IComparable
        {
			if(false)
			{
			}
			else if(typeof(T) == typeof(Byte))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Single))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Double))
			{
				return Add(src, dst, value);
			}
			else
			{
				return null;
			}
		}

		//別にdynamicでもよくないか？
		public static Pixel<T> ShiftLeft<T>(this Pixel<T> src, Pixel<T> dst, T value) where T : struct, IComparable
        {
			if(false)
			{
			}
			else if(typeof(T) == typeof(Byte))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Single))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Double))
			{
				return Add(src, dst, value);
			}
			else
			{
				return null;
			}
		}

		//別にdynamicでもよくないか？
		public static Pixel<T> ShiftRight<T>(this Pixel<T> src, Pixel<T> dst, T value) where T : struct, IComparable
        {
			if(false)
			{
			}
			else if(typeof(T) == typeof(Byte))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(UInt64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int16))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int32))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Int64))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Single))
			{
				return Add(src, dst, value);
			}
			else if(typeof(T) == typeof(Double))
			{
				return Add(src, dst, value);
			}
			else
			{
				return null;
			}
		}






		public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Byte value) => Add(src, src, value);
		public static Pixel<Byte> Add(this Pixel<Byte> src, Byte value) => Add(src, src.Clone(), value);

		public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Byte value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] + value);
            return dst;
        }


		public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, UInt16 value) => Add(src, src, value);
		public static Pixel<UInt16> Add(this Pixel<UInt16> src, UInt16 value) => Add(src, src.Clone(), value);

		public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] + value);
            return dst;
        }


		public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, UInt32 value) => Add(src, src, value);
		public static Pixel<UInt32> Add(this Pixel<UInt32> src, UInt32 value) => Add(src, src.Clone(), value);

		public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] + value);
            return dst;
        }


		public static Pixel<UInt64> AddSelf(this Pixel<UInt64> src, UInt64 value) => Add(src, src, value);
		public static Pixel<UInt64> Add(this Pixel<UInt64> src, UInt64 value) => Add(src, src.Clone(), value);

		public static Pixel<UInt64> Add(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] + value);
            return dst;
        }


		public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Int16 value) => Add(src, src, value);
		public static Pixel<Int16> Add(this Pixel<Int16> src, Int16 value) => Add(src, src.Clone(), value);

		public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] + value);
            return dst;
        }


		public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Int32 value) => Add(src, src, value);
		public static Pixel<Int32> Add(this Pixel<Int32> src, Int32 value) => Add(src, src.Clone(), value);

		public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int32)(src[x,y] + value);
            return dst;
        }


		public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Int64 value) => Add(src, src, value);
		public static Pixel<Int64> Add(this Pixel<Int64> src, Int64 value) => Add(src, src.Clone(), value);

		public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] + value);
            return dst;
        }


		public static Pixel<Single> AddSelf(this Pixel<Single> src, Single value) => Add(src, src, value);
		public static Pixel<Single> Add(this Pixel<Single> src, Single value) => Add(src, src.Clone(), value);

		public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Single value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Single)(src[x,y] + value);
            return dst;
        }


		public static Pixel<Double> AddSelf(this Pixel<Double> src, Double value) => Add(src, src, value);
		public static Pixel<Double> Add(this Pixel<Double> src, Double value) => Add(src, src.Clone(), value);

		public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Double)(src[x,y] + value);
            return dst;
        }




		public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Byte value) => Sub(src, src, value);
		public static Pixel<Byte> Sub(this Pixel<Byte> src, Byte value) => Sub(src, src.Clone(), value);

		public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Byte value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] - value);
            return dst;
        }


		public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, UInt16 value) => Sub(src, src, value);
		public static Pixel<UInt16> Sub(this Pixel<UInt16> src, UInt16 value) => Sub(src, src.Clone(), value);

		public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] - value);
            return dst;
        }


		public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, UInt32 value) => Sub(src, src, value);
		public static Pixel<UInt32> Sub(this Pixel<UInt32> src, UInt32 value) => Sub(src, src.Clone(), value);

		public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] - value);
            return dst;
        }


		public static Pixel<UInt64> SubSelf(this Pixel<UInt64> src, UInt64 value) => Sub(src, src, value);
		public static Pixel<UInt64> Sub(this Pixel<UInt64> src, UInt64 value) => Sub(src, src.Clone(), value);

		public static Pixel<UInt64> Sub(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] - value);
            return dst;
        }


		public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Int16 value) => Sub(src, src, value);
		public static Pixel<Int16> Sub(this Pixel<Int16> src, Int16 value) => Sub(src, src.Clone(), value);

		public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] - value);
            return dst;
        }


		public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Int32 value) => Sub(src, src, value);
		public static Pixel<Int32> Sub(this Pixel<Int32> src, Int32 value) => Sub(src, src.Clone(), value);

		public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int32)(src[x,y] - value);
            return dst;
        }


		public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Int64 value) => Sub(src, src, value);
		public static Pixel<Int64> Sub(this Pixel<Int64> src, Int64 value) => Sub(src, src.Clone(), value);

		public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] - value);
            return dst;
        }


		public static Pixel<Single> SubSelf(this Pixel<Single> src, Single value) => Sub(src, src, value);
		public static Pixel<Single> Sub(this Pixel<Single> src, Single value) => Sub(src, src.Clone(), value);

		public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Single value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Single)(src[x,y] - value);
            return dst;
        }


		public static Pixel<Double> SubSelf(this Pixel<Double> src, Double value) => Sub(src, src, value);
		public static Pixel<Double> Sub(this Pixel<Double> src, Double value) => Sub(src, src.Clone(), value);

		public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Double)(src[x,y] - value);
            return dst;
        }




		public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Byte value) => Mul(src, src, value);
		public static Pixel<Byte> Mul(this Pixel<Byte> src, Byte value) => Mul(src, src.Clone(), value);

		public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Byte value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] * value);
            return dst;
        }


		public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, UInt16 value) => Mul(src, src, value);
		public static Pixel<UInt16> Mul(this Pixel<UInt16> src, UInt16 value) => Mul(src, src.Clone(), value);

		public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] * value);
            return dst;
        }


		public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, UInt32 value) => Mul(src, src, value);
		public static Pixel<UInt32> Mul(this Pixel<UInt32> src, UInt32 value) => Mul(src, src.Clone(), value);

		public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] * value);
            return dst;
        }


		public static Pixel<UInt64> MulSelf(this Pixel<UInt64> src, UInt64 value) => Mul(src, src, value);
		public static Pixel<UInt64> Mul(this Pixel<UInt64> src, UInt64 value) => Mul(src, src.Clone(), value);

		public static Pixel<UInt64> Mul(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Int16 value) => Mul(src, src, value);
		public static Pixel<Int16> Mul(this Pixel<Int16> src, Int16 value) => Mul(src, src.Clone(), value);

		public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Int32 value) => Mul(src, src, value);
		public static Pixel<Int32> Mul(this Pixel<Int32> src, Int32 value) => Mul(src, src.Clone(), value);

		public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int32)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Int64 value) => Mul(src, src, value);
		public static Pixel<Int64> Mul(this Pixel<Int64> src, Int64 value) => Mul(src, src.Clone(), value);

		public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Single> MulSelf(this Pixel<Single> src, Single value) => Mul(src, src, value);
		public static Pixel<Single> Mul(this Pixel<Single> src, Single value) => Mul(src, src.Clone(), value);

		public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Single value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Single)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Double> MulSelf(this Pixel<Double> src, Double value) => Mul(src, src, value);
		public static Pixel<Double> Mul(this Pixel<Double> src, Double value) => Mul(src, src.Clone(), value);

		public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Double)(src[x,y] * value);
            return dst;
        }




		public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Byte value) => Div(src, src, value);
		public static Pixel<Byte> Div(this Pixel<Byte> src, Byte value) => Div(src, src.Clone(), value);

		public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Byte value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] / value);
            return dst;
        }


		public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, UInt16 value) => Div(src, src, value);
		public static Pixel<UInt16> Div(this Pixel<UInt16> src, UInt16 value) => Div(src, src.Clone(), value);

		public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] / value);
            return dst;
        }


		public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, UInt32 value) => Div(src, src, value);
		public static Pixel<UInt32> Div(this Pixel<UInt32> src, UInt32 value) => Div(src, src.Clone(), value);

		public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] / value);
            return dst;
        }


		public static Pixel<UInt64> DivSelf(this Pixel<UInt64> src, UInt64 value) => Div(src, src, value);
		public static Pixel<UInt64> Div(this Pixel<UInt64> src, UInt64 value) => Div(src, src.Clone(), value);

		public static Pixel<UInt64> Div(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Int16 value) => Div(src, src, value);
		public static Pixel<Int16> Div(this Pixel<Int16> src, Int16 value) => Div(src, src.Clone(), value);

		public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Int32 value) => Div(src, src, value);
		public static Pixel<Int32> Div(this Pixel<Int32> src, Int32 value) => Div(src, src.Clone(), value);

		public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int32)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Int64 value) => Div(src, src, value);
		public static Pixel<Int64> Div(this Pixel<Int64> src, Int64 value) => Div(src, src.Clone(), value);

		public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Single> DivSelf(this Pixel<Single> src, Single value) => Div(src, src, value);
		public static Pixel<Single> Div(this Pixel<Single> src, Single value) => Div(src, src.Clone(), value);

		public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Single value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Single)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Double> DivSelf(this Pixel<Double> src, Double value) => Div(src, src, value);
		public static Pixel<Double> Div(this Pixel<Double> src, Double value) => Div(src, src.Clone(), value);

		public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Double)(src[x,y] / value);
            return dst;
        }





		public static Pixel<Byte> MulSelf(this Pixel<Byte> src, double value) => Mul(src, src, value);
		public static Pixel<Byte> Mul(this Pixel<Byte> src, double value) => Mul(src, src.Clone(), value);

		public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] * value);
            return dst;
        }


		public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, double value) => Mul(src, src, value);
		public static Pixel<UInt16> Mul(this Pixel<UInt16> src, double value) => Mul(src, src.Clone(), value);

		public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] * value);
            return dst;
        }


		public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, double value) => Mul(src, src, value);
		public static Pixel<UInt32> Mul(this Pixel<UInt32> src, double value) => Mul(src, src.Clone(), value);

		public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] * value);
            return dst;
        }


		public static Pixel<UInt64> MulSelf(this Pixel<UInt64> src, double value) => Mul(src, src, value);
		public static Pixel<UInt64> Mul(this Pixel<UInt64> src, double value) => Mul(src, src.Clone(), value);

		public static Pixel<UInt64> Mul(this Pixel<UInt64> src, Pixel<UInt64> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Int16> MulSelf(this Pixel<Int16> src, double value) => Mul(src, src, value);
		public static Pixel<Int16> Mul(this Pixel<Int16> src, double value) => Mul(src, src.Clone(), value);

		public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Int64> MulSelf(this Pixel<Int64> src, double value) => Mul(src, src, value);
		public static Pixel<Int64> Mul(this Pixel<Int64> src, double value) => Mul(src, src.Clone(), value);

		public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] * value);
            return dst;
        }


		public static Pixel<Single> MulSelf(this Pixel<Single> src, double value) => Mul(src, src, value);
		public static Pixel<Single> Mul(this Pixel<Single> src, double value) => Mul(src, src.Clone(), value);

		public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Single)(src[x,y] * value);
            return dst;
        }




		public static Pixel<Byte> DivSelf(this Pixel<Byte> src, double value) => Div(src, src, value);
		public static Pixel<Byte> Div(this Pixel<Byte> src, double value) => Div(src, src.Clone(), value);

		public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] / value);
            return dst;
        }


		public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, double value) => Div(src, src, value);
		public static Pixel<UInt16> Div(this Pixel<UInt16> src, double value) => Div(src, src.Clone(), value);

		public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] / value);
            return dst;
        }


		public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, double value) => Div(src, src, value);
		public static Pixel<UInt32> Div(this Pixel<UInt32> src, double value) => Div(src, src.Clone(), value);

		public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] / value);
            return dst;
        }


		public static Pixel<UInt64> DivSelf(this Pixel<UInt64> src, double value) => Div(src, src, value);
		public static Pixel<UInt64> Div(this Pixel<UInt64> src, double value) => Div(src, src.Clone(), value);

		public static Pixel<UInt64> Div(this Pixel<UInt64> src, Pixel<UInt64> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Int16> DivSelf(this Pixel<Int16> src, double value) => Div(src, src, value);
		public static Pixel<Int16> Div(this Pixel<Int16> src, double value) => Div(src, src.Clone(), value);

		public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Int64> DivSelf(this Pixel<Int64> src, double value) => Div(src, src, value);
		public static Pixel<Int64> Div(this Pixel<Int64> src, double value) => Div(src, src.Clone(), value);

		public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] / value);
            return dst;
        }


		public static Pixel<Single> DivSelf(this Pixel<Single> src, double value) => Div(src, src, value);
		public static Pixel<Single> Div(this Pixel<Single> src, double value) => Div(src, src.Clone(), value);

		public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, double value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Single)(src[x,y] / value);
            return dst;
        }




		public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => Add(src1, src1, src2);
		public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Byte)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Add(src1, src1, src2);
		public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt16)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Add(src1, src1, src2);
		public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt32)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<UInt64> AddSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Add(src1, src1, src2);
		public static Pixel<UInt64> Add(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<UInt64> Add(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt64)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => Add(src1, src1, src2);
		public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int16)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => Add(src1, src1, src2);
		public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int32)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => Add(src1, src1, src2);
		public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int64)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Single> src2) => Add(src1, src1, src2);
		public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Single)(src1[x,y] + src2[x,y]);
            return dst;
        }

		public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Double> src2) => Add(src1, src1, src2);
		public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> src2) => Add(src1, src1.Clone(), src2);
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Double)(src1[x,y] + src2[x,y]);
            return dst;
        }



		public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => Sub(src1, src1, src2);
		public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Byte)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Sub(src1, src1, src2);
		public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt16)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Sub(src1, src1, src2);
		public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt32)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<UInt64> SubSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Sub(src1, src1, src2);
		public static Pixel<UInt64> Sub(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<UInt64> Sub(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt64)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => Sub(src1, src1, src2);
		public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int16)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => Sub(src1, src1, src2);
		public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int32)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => Sub(src1, src1, src2);
		public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int64)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Single> src2) => Sub(src1, src1, src2);
		public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Single)(src1[x,y] - src2[x,y]);
            return dst;
        }

		public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Double> src2) => Sub(src1, src1, src2);
		public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> src2) => Sub(src1, src1.Clone(), src2);
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Double)(src1[x,y] - src2[x,y]);
            return dst;
        }



		public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => Mul(src1, src1, src2);
		public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Byte)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Mul(src1, src1, src2);
		public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt16)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Mul(src1, src1, src2);
		public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt32)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<UInt64> MulSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Mul(src1, src1, src2);
		public static Pixel<UInt64> Mul(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<UInt64> Mul(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt64)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => Mul(src1, src1, src2);
		public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int16)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => Mul(src1, src1, src2);
		public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int32)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => Mul(src1, src1, src2);
		public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int64)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Single> src2) => Mul(src1, src1, src2);
		public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Single)(src1[x,y] * src2[x,y]);
            return dst;
        }

		public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Double> src2) => Mul(src1, src1, src2);
		public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> src2) => Mul(src1, src1.Clone(), src2);
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Double)(src1[x,y] * src2[x,y]);
            return dst;
        }



		public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => Div(src1, src1, src2);
		public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Byte)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Div(src1, src1, src2);
		public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt16)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Div(src1, src1, src2);
		public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt32)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<UInt64> DivSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Div(src1, src1, src2);
		public static Pixel<UInt64> Div(this Pixel<UInt64> src1, Pixel<UInt64> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<UInt64> Div(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (UInt64)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => Div(src1, src1, src2);
		public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int16)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => Div(src1, src1, src2);
		public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int32)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => Div(src1, src1, src2);
		public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Int64)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Single> src2) => Div(src1, src1, src2);
		public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Single)(src1[x,y] / src2[x,y]);
            return dst;
        }

		public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Double> src2) => Div(src1, src1, src2);
		public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> src2) => Div(src1, src1.Clone(), src2);
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2)
        {
            for (int y = 0; y < src1.Height; y++)
                for (int x = 0; x < src1.Width; x++)
                    dst[x, y] = (Double)(src1[x,y] / src2[x,y]);
            return dst;
        }






		public static Pixel<Byte> ShiftLeftSelf(this Pixel<Byte> src, int value) => ShiftLeft(src, src, value);
		public static Pixel<Byte> ShiftLeft(this Pixel<Byte> src, int value) => ShiftLeft(src, src.Clone(), value);
        public static Pixel<Byte> ShiftLeft(this Pixel<Byte> src, Pixel<Byte> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] << value);
            return src;
        }

		public static Pixel<UInt16> ShiftLeftSelf(this Pixel<UInt16> src, int value) => ShiftLeft(src, src, value);
		public static Pixel<UInt16> ShiftLeft(this Pixel<UInt16> src, int value) => ShiftLeft(src, src.Clone(), value);
        public static Pixel<UInt16> ShiftLeft(this Pixel<UInt16> src, Pixel<UInt16> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] << value);
            return src;
        }

		public static Pixel<UInt32> ShiftLeftSelf(this Pixel<UInt32> src, int value) => ShiftLeft(src, src, value);
		public static Pixel<UInt32> ShiftLeft(this Pixel<UInt32> src, int value) => ShiftLeft(src, src.Clone(), value);
        public static Pixel<UInt32> ShiftLeft(this Pixel<UInt32> src, Pixel<UInt32> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] << value);
            return src;
        }

		public static Pixel<UInt64> ShiftLeftSelf(this Pixel<UInt64> src, int value) => ShiftLeft(src, src, value);
		public static Pixel<UInt64> ShiftLeft(this Pixel<UInt64> src, int value) => ShiftLeft(src, src.Clone(), value);
        public static Pixel<UInt64> ShiftLeft(this Pixel<UInt64> src, Pixel<UInt64> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] << value);
            return src;
        }

		public static Pixel<Int16> ShiftLeftSelf(this Pixel<Int16> src, int value) => ShiftLeft(src, src, value);
		public static Pixel<Int16> ShiftLeft(this Pixel<Int16> src, int value) => ShiftLeft(src, src.Clone(), value);
        public static Pixel<Int16> ShiftLeft(this Pixel<Int16> src, Pixel<Int16> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] << value);
            return src;
        }

		public static Pixel<Int32> ShiftLeftSelf(this Pixel<Int32> src, int value) => ShiftLeft(src, src, value);
		public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, int value) => ShiftLeft(src, src.Clone(), value);
        public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, Pixel<Int32> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int32)(src[x,y] << value);
            return src;
        }

		public static Pixel<Int64> ShiftLeftSelf(this Pixel<Int64> src, int value) => ShiftLeft(src, src, value);
		public static Pixel<Int64> ShiftLeft(this Pixel<Int64> src, int value) => ShiftLeft(src, src.Clone(), value);
        public static Pixel<Int64> ShiftLeft(this Pixel<Int64> src, Pixel<Int64> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] << value);
            return src;
        }



		public static Pixel<Byte> ShiftRightSelf(this Pixel<Byte> src, int value) => ShiftRight(src, src, value);
		public static Pixel<Byte> ShiftRight(this Pixel<Byte> src, int value) => ShiftRight(src, src.Clone(), value);
        public static Pixel<Byte> ShiftRight(this Pixel<Byte> src, Pixel<Byte> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Byte)(src[x,y] >> value);
            return src;
        }

		public static Pixel<UInt16> ShiftRightSelf(this Pixel<UInt16> src, int value) => ShiftRight(src, src, value);
		public static Pixel<UInt16> ShiftRight(this Pixel<UInt16> src, int value) => ShiftRight(src, src.Clone(), value);
        public static Pixel<UInt16> ShiftRight(this Pixel<UInt16> src, Pixel<UInt16> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt16)(src[x,y] >> value);
            return src;
        }

		public static Pixel<UInt32> ShiftRightSelf(this Pixel<UInt32> src, int value) => ShiftRight(src, src, value);
		public static Pixel<UInt32> ShiftRight(this Pixel<UInt32> src, int value) => ShiftRight(src, src.Clone(), value);
        public static Pixel<UInt32> ShiftRight(this Pixel<UInt32> src, Pixel<UInt32> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt32)(src[x,y] >> value);
            return src;
        }

		public static Pixel<UInt64> ShiftRightSelf(this Pixel<UInt64> src, int value) => ShiftRight(src, src, value);
		public static Pixel<UInt64> ShiftRight(this Pixel<UInt64> src, int value) => ShiftRight(src, src.Clone(), value);
        public static Pixel<UInt64> ShiftRight(this Pixel<UInt64> src, Pixel<UInt64> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (UInt64)(src[x,y] >> value);
            return src;
        }

		public static Pixel<Int16> ShiftRightSelf(this Pixel<Int16> src, int value) => ShiftRight(src, src, value);
		public static Pixel<Int16> ShiftRight(this Pixel<Int16> src, int value) => ShiftRight(src, src.Clone(), value);
        public static Pixel<Int16> ShiftRight(this Pixel<Int16> src, Pixel<Int16> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int16)(src[x,y] >> value);
            return src;
        }

		public static Pixel<Int32> ShiftRightSelf(this Pixel<Int32> src, int value) => ShiftRight(src, src, value);
		public static Pixel<Int32> ShiftRight(this Pixel<Int32> src, int value) => ShiftRight(src, src.Clone(), value);
        public static Pixel<Int32> ShiftRight(this Pixel<Int32> src, Pixel<Int32> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int32)(src[x,y] >> value);
            return src;
        }

		public static Pixel<Int64> ShiftRightSelf(this Pixel<Int64> src, int value) => ShiftRight(src, src, value);
		public static Pixel<Int64> ShiftRight(this Pixel<Int64> src, int value) => ShiftRight(src, src.Clone(), value);
        public static Pixel<Int64> ShiftRight(this Pixel<Int64> src, Pixel<Int64> dst, int value)
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[x, y] = (Int64)(src[x,y] >> value);
            return src;
        }


    }
}