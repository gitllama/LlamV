using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

using Pixels.Math;

namespace Pixels
{
    public partial class Pixel<T>
    {

		//暗示キャスト
		public static implicit operator Pixel<Double>(Pixel<T> x)
		{
            Pixel<Double> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<Double, Op_Cast_DoubleDouble>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<Double, Op_Cast_SingleDouble>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<Double, Op_Cast_Int64Double>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<Double, Op_Cast_Int32Double>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<Double, Op_Cast_Int16Double>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<Double, Op_Cast_UInt64Double>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<Double, Op_Cast_UInt32Double>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<Double, Op_Cast_UInt16Double>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<Double, Op_Cast_ByteDouble>() :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static implicit operator Pixel<Int32>(Pixel<T> x)
		{
            Pixel<Int32> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<Double, Op_Cast_DoubleDouble>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<Double, Op_Cast_SingleDouble>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<Double, Op_Cast_Int64Double>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<Double, Op_Cast_Int32Double>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<Double, Op_Cast_Int16Double>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<Double, Op_Cast_UInt64Double>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<Double, Op_Cast_UInt32Double>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<Double, Op_Cast_UInt16Double>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<Double, Op_Cast_ByteDouble>() :
                null;
			return dst ?? throw new ArithmeticException();
		}

		struct Op_Cast_DoubleDouble : IBinaryOperator<Double, Double> { public Double Operate(Double x) => (Double)x; }
		struct Op_Cast_DoubleInt32 : IBinaryOperator<Double, Int32> { public Int32 Operate(Double x) => (Int32)x; }
		struct Op_Cast_SingleDouble : IBinaryOperator<Single, Double> { public Double Operate(Single x) => (Double)x; }
		struct Op_Cast_SingleInt32 : IBinaryOperator<Single, Int32> { public Int32 Operate(Single x) => (Int32)x; }
		struct Op_Cast_Int64Double : IBinaryOperator<Int64, Double> { public Double Operate(Int64 x) => (Double)x; }
		struct Op_Cast_Int64Int32 : IBinaryOperator<Int64, Int32> { public Int32 Operate(Int64 x) => (Int32)x; }
		struct Op_Cast_Int32Double : IBinaryOperator<Int32, Double> { public Double Operate(Int32 x) => (Double)x; }
		struct Op_Cast_Int32Int32 : IBinaryOperator<Int32, Int32> { public Int32 Operate(Int32 x) => (Int32)x; }
		struct Op_Cast_Int16Double : IBinaryOperator<Int16, Double> { public Double Operate(Int16 x) => (Double)x; }
		struct Op_Cast_Int16Int32 : IBinaryOperator<Int16, Int32> { public Int32 Operate(Int16 x) => (Int32)x; }
		struct Op_Cast_UInt64Double : IBinaryOperator<UInt64, Double> { public Double Operate(UInt64 x) => (Double)x; }
		struct Op_Cast_UInt64Int32 : IBinaryOperator<UInt64, Int32> { public Int32 Operate(UInt64 x) => (Int32)x; }
		struct Op_Cast_UInt32Double : IBinaryOperator<UInt32, Double> { public Double Operate(UInt32 x) => (Double)x; }
		struct Op_Cast_UInt32Int32 : IBinaryOperator<UInt32, Int32> { public Int32 Operate(UInt32 x) => (Int32)x; }
		struct Op_Cast_UInt16Double : IBinaryOperator<UInt16, Double> { public Double Operate(UInt16 x) => (Double)x; }
		struct Op_Cast_UInt16Int32 : IBinaryOperator<UInt16, Int32> { public Int32 Operate(UInt16 x) => (Int32)x; }
		struct Op_Cast_ByteDouble : IBinaryOperator<Byte, Double> { public Double Operate(Byte x) => (Double)x; }
		struct Op_Cast_ByteInt32 : IBinaryOperator<Byte, Int32> { public Int32 Operate(Byte x) => (Int32)x; }



		//明示キャスト
		public static explicit operator Pixel<Single>(Pixel<T> x)
		{
            Pixel<Single> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<Single, Op_Cast_DoubleSingle>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<Single, Op_Cast_SingleSingle>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<Single, Op_Cast_Int64Single>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<Single, Op_Cast_Int32Single>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<Single, Op_Cast_Int16Single>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<Single, Op_Cast_UInt64Single>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<Single, Op_Cast_UInt32Single>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<Single, Op_Cast_UInt16Single>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<Single, Op_Cast_ByteSingle>() :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<Int64>(Pixel<T> x)
		{
            Pixel<Int64> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<Int64, Op_Cast_DoubleInt64>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<Int64, Op_Cast_SingleInt64>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<Int64, Op_Cast_Int64Int64>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<Int64, Op_Cast_Int32Int64>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<Int64, Op_Cast_Int16Int64>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<Int64, Op_Cast_UInt64Int64>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<Int64, Op_Cast_UInt32Int64>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<Int64, Op_Cast_UInt16Int64>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<Int64, Op_Cast_ByteInt64>() :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<Int16>(Pixel<T> x)
		{
            Pixel<Int16> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<Int16, Op_Cast_DoubleInt16>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<Int16, Op_Cast_SingleInt16>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<Int16, Op_Cast_Int64Int16>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<Int16, Op_Cast_Int32Int16>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<Int16, Op_Cast_Int16Int16>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<Int16, Op_Cast_UInt64Int16>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<Int16, Op_Cast_UInt32Int16>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<Int16, Op_Cast_UInt16Int16>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<Int16, Op_Cast_ByteInt16>() :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<UInt64>(Pixel<T> x)
		{
            Pixel<UInt64> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<UInt64, Op_Cast_DoubleUInt64>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<UInt64, Op_Cast_SingleUInt64>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<UInt64, Op_Cast_Int64UInt64>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<UInt64, Op_Cast_Int32UInt64>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<UInt64, Op_Cast_Int16UInt64>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<UInt64, Op_Cast_UInt64UInt64>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<UInt64, Op_Cast_UInt32UInt64>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<UInt64, Op_Cast_UInt16UInt64>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<UInt64, Op_Cast_ByteUInt64>() :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<UInt32>(Pixel<T> x)
		{
            Pixel<UInt32> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<UInt32, Op_Cast_DoubleUInt32>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<UInt32, Op_Cast_SingleUInt32>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<UInt32, Op_Cast_Int64UInt32>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<UInt32, Op_Cast_Int32UInt32>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<UInt32, Op_Cast_Int16UInt32>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<UInt32, Op_Cast_UInt64UInt32>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<UInt32, Op_Cast_UInt32UInt32>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<UInt32, Op_Cast_UInt16UInt32>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<UInt32, Op_Cast_ByteUInt32>() :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<UInt16>(Pixel<T> x)
		{
            Pixel<UInt16> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<UInt16, Op_Cast_DoubleUInt16>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<UInt16, Op_Cast_SingleUInt16>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<UInt16, Op_Cast_Int64UInt16>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<UInt16, Op_Cast_Int32UInt16>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<UInt16, Op_Cast_Int16UInt16>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<UInt16, Op_Cast_UInt64UInt16>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<UInt16, Op_Cast_UInt32UInt16>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<UInt16, Op_Cast_UInt16UInt16>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<UInt16, Op_Cast_ByteUInt16>() :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<Byte>(Pixel<T> x)
		{
            Pixel<Byte> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate<Byte, Op_Cast_DoubleByte>() :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate<Byte, Op_Cast_SingleByte>() :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate<Byte, Op_Cast_Int64Byte>() :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate<Byte, Op_Cast_Int32Byte>() :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate<Byte, Op_Cast_Int16Byte>() :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate<Byte, Op_Cast_UInt64Byte>() :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate<Byte, Op_Cast_UInt32Byte>() :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate<Byte, Op_Cast_UInt16Byte>() :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate<Byte, Op_Cast_ByteByte>() :
                null;
			return dst ?? throw new ArithmeticException();
		}

		struct Op_Cast_DoubleSingle : IBinaryOperator<Double, Single> { public Single Operate(Double x) => (Single)x; }
		struct Op_Cast_SingleSingle : IBinaryOperator<Single, Single> { public Single Operate(Single x) => (Single)x; }
		struct Op_Cast_Int64Single : IBinaryOperator<Int64, Single> { public Single Operate(Int64 x) => (Single)x; }
		struct Op_Cast_Int32Single : IBinaryOperator<Int32, Single> { public Single Operate(Int32 x) => (Single)x; }
		struct Op_Cast_Int16Single : IBinaryOperator<Int16, Single> { public Single Operate(Int16 x) => (Single)x; }
		struct Op_Cast_UInt64Single : IBinaryOperator<UInt64, Single> { public Single Operate(UInt64 x) => (Single)x; }
		struct Op_Cast_UInt32Single : IBinaryOperator<UInt32, Single> { public Single Operate(UInt32 x) => (Single)x; }
		struct Op_Cast_UInt16Single : IBinaryOperator<UInt16, Single> { public Single Operate(UInt16 x) => (Single)x; }
		struct Op_Cast_ByteSingle : IBinaryOperator<Byte, Single> { public Single Operate(Byte x) => (Single)x; }
		struct Op_Cast_DoubleInt64 : IBinaryOperator<Double, Int64> { public Int64 Operate(Double x) => (Int64)x; }
		struct Op_Cast_SingleInt64 : IBinaryOperator<Single, Int64> { public Int64 Operate(Single x) => (Int64)x; }
		struct Op_Cast_Int64Int64 : IBinaryOperator<Int64, Int64> { public Int64 Operate(Int64 x) => (Int64)x; }
		struct Op_Cast_Int32Int64 : IBinaryOperator<Int32, Int64> { public Int64 Operate(Int32 x) => (Int64)x; }
		struct Op_Cast_Int16Int64 : IBinaryOperator<Int16, Int64> { public Int64 Operate(Int16 x) => (Int64)x; }
		struct Op_Cast_UInt64Int64 : IBinaryOperator<UInt64, Int64> { public Int64 Operate(UInt64 x) => (Int64)x; }
		struct Op_Cast_UInt32Int64 : IBinaryOperator<UInt32, Int64> { public Int64 Operate(UInt32 x) => (Int64)x; }
		struct Op_Cast_UInt16Int64 : IBinaryOperator<UInt16, Int64> { public Int64 Operate(UInt16 x) => (Int64)x; }
		struct Op_Cast_ByteInt64 : IBinaryOperator<Byte, Int64> { public Int64 Operate(Byte x) => (Int64)x; }
		struct Op_Cast_DoubleInt16 : IBinaryOperator<Double, Int16> { public Int16 Operate(Double x) => (Int16)x; }
		struct Op_Cast_SingleInt16 : IBinaryOperator<Single, Int16> { public Int16 Operate(Single x) => (Int16)x; }
		struct Op_Cast_Int64Int16 : IBinaryOperator<Int64, Int16> { public Int16 Operate(Int64 x) => (Int16)x; }
		struct Op_Cast_Int32Int16 : IBinaryOperator<Int32, Int16> { public Int16 Operate(Int32 x) => (Int16)x; }
		struct Op_Cast_Int16Int16 : IBinaryOperator<Int16, Int16> { public Int16 Operate(Int16 x) => (Int16)x; }
		struct Op_Cast_UInt64Int16 : IBinaryOperator<UInt64, Int16> { public Int16 Operate(UInt64 x) => (Int16)x; }
		struct Op_Cast_UInt32Int16 : IBinaryOperator<UInt32, Int16> { public Int16 Operate(UInt32 x) => (Int16)x; }
		struct Op_Cast_UInt16Int16 : IBinaryOperator<UInt16, Int16> { public Int16 Operate(UInt16 x) => (Int16)x; }
		struct Op_Cast_ByteInt16 : IBinaryOperator<Byte, Int16> { public Int16 Operate(Byte x) => (Int16)x; }
		struct Op_Cast_DoubleUInt64 : IBinaryOperator<Double, UInt64> { public UInt64 Operate(Double x) => (UInt64)x; }
		struct Op_Cast_SingleUInt64 : IBinaryOperator<Single, UInt64> { public UInt64 Operate(Single x) => (UInt64)x; }
		struct Op_Cast_Int64UInt64 : IBinaryOperator<Int64, UInt64> { public UInt64 Operate(Int64 x) => (UInt64)x; }
		struct Op_Cast_Int32UInt64 : IBinaryOperator<Int32, UInt64> { public UInt64 Operate(Int32 x) => (UInt64)x; }
		struct Op_Cast_Int16UInt64 : IBinaryOperator<Int16, UInt64> { public UInt64 Operate(Int16 x) => (UInt64)x; }
		struct Op_Cast_UInt64UInt64 : IBinaryOperator<UInt64, UInt64> { public UInt64 Operate(UInt64 x) => (UInt64)x; }
		struct Op_Cast_UInt32UInt64 : IBinaryOperator<UInt32, UInt64> { public UInt64 Operate(UInt32 x) => (UInt64)x; }
		struct Op_Cast_UInt16UInt64 : IBinaryOperator<UInt16, UInt64> { public UInt64 Operate(UInt16 x) => (UInt64)x; }
		struct Op_Cast_ByteUInt64 : IBinaryOperator<Byte, UInt64> { public UInt64 Operate(Byte x) => (UInt64)x; }
		struct Op_Cast_DoubleUInt32 : IBinaryOperator<Double, UInt32> { public UInt32 Operate(Double x) => (UInt32)x; }
		struct Op_Cast_SingleUInt32 : IBinaryOperator<Single, UInt32> { public UInt32 Operate(Single x) => (UInt32)x; }
		struct Op_Cast_Int64UInt32 : IBinaryOperator<Int64, UInt32> { public UInt32 Operate(Int64 x) => (UInt32)x; }
		struct Op_Cast_Int32UInt32 : IBinaryOperator<Int32, UInt32> { public UInt32 Operate(Int32 x) => (UInt32)x; }
		struct Op_Cast_Int16UInt32 : IBinaryOperator<Int16, UInt32> { public UInt32 Operate(Int16 x) => (UInt32)x; }
		struct Op_Cast_UInt64UInt32 : IBinaryOperator<UInt64, UInt32> { public UInt32 Operate(UInt64 x) => (UInt32)x; }
		struct Op_Cast_UInt32UInt32 : IBinaryOperator<UInt32, UInt32> { public UInt32 Operate(UInt32 x) => (UInt32)x; }
		struct Op_Cast_UInt16UInt32 : IBinaryOperator<UInt16, UInt32> { public UInt32 Operate(UInt16 x) => (UInt32)x; }
		struct Op_Cast_ByteUInt32 : IBinaryOperator<Byte, UInt32> { public UInt32 Operate(Byte x) => (UInt32)x; }
		struct Op_Cast_DoubleUInt16 : IBinaryOperator<Double, UInt16> { public UInt16 Operate(Double x) => (UInt16)x; }
		struct Op_Cast_SingleUInt16 : IBinaryOperator<Single, UInt16> { public UInt16 Operate(Single x) => (UInt16)x; }
		struct Op_Cast_Int64UInt16 : IBinaryOperator<Int64, UInt16> { public UInt16 Operate(Int64 x) => (UInt16)x; }
		struct Op_Cast_Int32UInt16 : IBinaryOperator<Int32, UInt16> { public UInt16 Operate(Int32 x) => (UInt16)x; }
		struct Op_Cast_Int16UInt16 : IBinaryOperator<Int16, UInt16> { public UInt16 Operate(Int16 x) => (UInt16)x; }
		struct Op_Cast_UInt64UInt16 : IBinaryOperator<UInt64, UInt16> { public UInt16 Operate(UInt64 x) => (UInt16)x; }
		struct Op_Cast_UInt32UInt16 : IBinaryOperator<UInt32, UInt16> { public UInt16 Operate(UInt32 x) => (UInt16)x; }
		struct Op_Cast_UInt16UInt16 : IBinaryOperator<UInt16, UInt16> { public UInt16 Operate(UInt16 x) => (UInt16)x; }
		struct Op_Cast_ByteUInt16 : IBinaryOperator<Byte, UInt16> { public UInt16 Operate(Byte x) => (UInt16)x; }
		struct Op_Cast_DoubleByte : IBinaryOperator<Double, Byte> { public Byte Operate(Double x) => (Byte)x; }
		struct Op_Cast_SingleByte : IBinaryOperator<Single, Byte> { public Byte Operate(Single x) => (Byte)x; }
		struct Op_Cast_Int64Byte : IBinaryOperator<Int64, Byte> { public Byte Operate(Int64 x) => (Byte)x; }
		struct Op_Cast_Int32Byte : IBinaryOperator<Int32, Byte> { public Byte Operate(Int32 x) => (Byte)x; }
		struct Op_Cast_Int16Byte : IBinaryOperator<Int16, Byte> { public Byte Operate(Int16 x) => (Byte)x; }
		struct Op_Cast_UInt64Byte : IBinaryOperator<UInt64, Byte> { public Byte Operate(UInt64 x) => (Byte)x; }
		struct Op_Cast_UInt32Byte : IBinaryOperator<UInt32, Byte> { public Byte Operate(UInt32 x) => (Byte)x; }
		struct Op_Cast_UInt16Byte : IBinaryOperator<UInt16, Byte> { public Byte Operate(UInt16 x) => (Byte)x; }
		struct Op_Cast_ByteByte : IBinaryOperator<Byte, Byte> { public Byte Operate(Byte x) => (Byte)x; }

    }
}