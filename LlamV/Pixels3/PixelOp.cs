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
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<Double>(), default(Op_Cast_DoubleDouble)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<Double>(), default(Op_Cast_SingleDouble)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<Double>(), default(Op_Cast_Int64Double)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<Double>(), default(Op_Cast_Int32Double)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<Double>(), default(Op_Cast_Int16Double)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<Double>(), default(Op_Cast_UInt64Double)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<Double>(), default(Op_Cast_UInt32Double)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<Double>(), default(Op_Cast_UInt16Double)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<Double>(), default(Op_Cast_ByteDouble)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static implicit operator Pixel<Int32>(Pixel<T> x)
		{
            Pixel<Int32> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<Int32>(), default(Op_Cast_DoubleInt32)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<Int32>(), default(Op_Cast_SingleInt32)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<Int32>(), default(Op_Cast_Int64Int32)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<Int32>(), default(Op_Cast_Int32Int32)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<Int32>(), default(Op_Cast_Int16Int32)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<Int32>(), default(Op_Cast_UInt64Int32)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<Int32>(), default(Op_Cast_UInt32Int32)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<Int32>(), default(Op_Cast_UInt16Int32)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<Int32>(), default(Op_Cast_ByteInt32)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		struct Op_Cast_DoubleDouble : IBinaryOperator<Double, Double> { public void Operate(ref Double x, ref Double y) => y = (Double)x; }
		struct Op_Cast_DoubleInt32 : IBinaryOperator<Double, Int32> { public void Operate(ref Double x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_SingleDouble : IBinaryOperator<Single, Double> { public void Operate(ref Single x, ref Double y) => y = (Double)x; }
		struct Op_Cast_SingleInt32 : IBinaryOperator<Single, Int32> { public void Operate(ref Single x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_Int64Double : IBinaryOperator<Int64, Double> { public void Operate(ref Int64 x, ref Double y) => y = (Double)x; }
		struct Op_Cast_Int64Int32 : IBinaryOperator<Int64, Int32> { public void Operate(ref Int64 x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_Int32Double : IBinaryOperator<Int32, Double> { public void Operate(ref Int32 x, ref Double y) => y = (Double)x; }
		struct Op_Cast_Int32Int32 : IBinaryOperator<Int32, Int32> { public void Operate(ref Int32 x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_Int16Double : IBinaryOperator<Int16, Double> { public void Operate(ref Int16 x, ref Double y) => y = (Double)x; }
		struct Op_Cast_Int16Int32 : IBinaryOperator<Int16, Int32> { public void Operate(ref Int16 x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_UInt64Double : IBinaryOperator<UInt64, Double> { public void Operate(ref UInt64 x, ref Double y) => y = (Double)x; }
		struct Op_Cast_UInt64Int32 : IBinaryOperator<UInt64, Int32> { public void Operate(ref UInt64 x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_UInt32Double : IBinaryOperator<UInt32, Double> { public void Operate(ref UInt32 x, ref Double y) => y = (Double)x; }
		struct Op_Cast_UInt32Int32 : IBinaryOperator<UInt32, Int32> { public void Operate(ref UInt32 x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_UInt16Double : IBinaryOperator<UInt16, Double> { public void Operate(ref UInt16 x, ref Double y) => y = (Double)x; }
		struct Op_Cast_UInt16Int32 : IBinaryOperator<UInt16, Int32> { public void Operate(ref UInt16 x, ref Int32 y) => y = (Int32)x; }
		struct Op_Cast_ByteDouble : IBinaryOperator<Byte, Double> { public void Operate(ref Byte x, ref Double y) => y = (Double)x; }
		struct Op_Cast_ByteInt32 : IBinaryOperator<Byte, Int32> { public void Operate(ref Byte x, ref Int32 y) => y = (Int32)x; }



		//明示キャスト
		public static explicit operator Pixel<Single>(Pixel<T> x)
		{
            Pixel<Single> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<Single>(), default(Op_Cast_DoubleSingle)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<Single>(), default(Op_Cast_SingleSingle)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<Single>(), default(Op_Cast_Int64Single)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<Single>(), default(Op_Cast_Int32Single)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<Single>(), default(Op_Cast_Int16Single)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<Single>(), default(Op_Cast_UInt64Single)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<Single>(), default(Op_Cast_UInt32Single)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<Single>(), default(Op_Cast_UInt16Single)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<Single>(), default(Op_Cast_ByteSingle)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<Int64>(Pixel<T> x)
		{
            Pixel<Int64> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<Int64>(), default(Op_Cast_DoubleInt64)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<Int64>(), default(Op_Cast_SingleInt64)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<Int64>(), default(Op_Cast_Int64Int64)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<Int64>(), default(Op_Cast_Int32Int64)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<Int64>(), default(Op_Cast_Int16Int64)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<Int64>(), default(Op_Cast_UInt64Int64)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<Int64>(), default(Op_Cast_UInt32Int64)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<Int64>(), default(Op_Cast_UInt16Int64)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<Int64>(), default(Op_Cast_ByteInt64)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<Int16>(Pixel<T> x)
		{
            Pixel<Int16> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<Int16>(), default(Op_Cast_DoubleInt16)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<Int16>(), default(Op_Cast_SingleInt16)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<Int16>(), default(Op_Cast_Int64Int16)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<Int16>(), default(Op_Cast_Int32Int16)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<Int16>(), default(Op_Cast_Int16Int16)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<Int16>(), default(Op_Cast_UInt64Int16)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<Int16>(), default(Op_Cast_UInt32Int16)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<Int16>(), default(Op_Cast_UInt16Int16)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<Int16>(), default(Op_Cast_ByteInt16)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<UInt64>(Pixel<T> x)
		{
            Pixel<UInt64> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_DoubleUInt64)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_SingleUInt64)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_Int64UInt64)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_Int32UInt64)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_Int16UInt64)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_UInt64UInt64)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_UInt32UInt64)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_UInt16UInt64)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<UInt64>(), default(Op_Cast_ByteUInt64)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<UInt32>(Pixel<T> x)
		{
            Pixel<UInt32> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_DoubleUInt32)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_SingleUInt32)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_Int64UInt32)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_Int32UInt32)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_Int16UInt32)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_UInt64UInt32)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_UInt32UInt32)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_UInt16UInt32)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<UInt32>(), default(Op_Cast_ByteUInt32)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<UInt16>(Pixel<T> x)
		{
            Pixel<UInt16> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_DoubleUInt16)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_SingleUInt16)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_Int64UInt16)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_Int32UInt16)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_Int16UInt16)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_UInt64UInt16)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_UInt32UInt16)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_UInt16UInt16)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<UInt16>(), default(Op_Cast_ByteUInt16)) :
                null;
			return dst ?? throw new ArithmeticException();
		}
		public static explicit operator Pixel<Byte>(Pixel<T> x)
		{
            Pixel<Byte> dst = 
				typeof(T) == typeof(Double) ? (x as Pixel<Double>).Accumulate(x.Clone<Byte>(), default(Op_Cast_DoubleByte)) :
				typeof(T) == typeof(Single) ? (x as Pixel<Single>).Accumulate(x.Clone<Byte>(), default(Op_Cast_SingleByte)) :
				typeof(T) == typeof(Int64) ? (x as Pixel<Int64>).Accumulate(x.Clone<Byte>(), default(Op_Cast_Int64Byte)) :
				typeof(T) == typeof(Int32) ? (x as Pixel<Int32>).Accumulate(x.Clone<Byte>(), default(Op_Cast_Int32Byte)) :
				typeof(T) == typeof(Int16) ? (x as Pixel<Int16>).Accumulate(x.Clone<Byte>(), default(Op_Cast_Int16Byte)) :
				typeof(T) == typeof(UInt64) ? (x as Pixel<UInt64>).Accumulate(x.Clone<Byte>(), default(Op_Cast_UInt64Byte)) :
				typeof(T) == typeof(UInt32) ? (x as Pixel<UInt32>).Accumulate(x.Clone<Byte>(), default(Op_Cast_UInt32Byte)) :
				typeof(T) == typeof(UInt16) ? (x as Pixel<UInt16>).Accumulate(x.Clone<Byte>(), default(Op_Cast_UInt16Byte)) :
				typeof(T) == typeof(Byte) ? (x as Pixel<Byte>).Accumulate(x.Clone<Byte>(), default(Op_Cast_ByteByte)) :
                null;
			return dst ?? throw new ArithmeticException();
		}

		struct Op_Cast_DoubleSingle : IBinaryOperator<Double, Single> { public void Operate(ref Double x, ref Single y) => y = (Single)x; }
		struct Op_Cast_SingleSingle : IBinaryOperator<Single, Single> { public void Operate(ref Single x, ref Single y) => y = (Single)x; }
		struct Op_Cast_Int64Single : IBinaryOperator<Int64, Single> { public void Operate(ref Int64 x, ref Single y) => y = (Single)x; }
		struct Op_Cast_Int32Single : IBinaryOperator<Int32, Single> { public void Operate(ref Int32 x, ref Single y) => y = (Single)x; }
		struct Op_Cast_Int16Single : IBinaryOperator<Int16, Single> { public void Operate(ref Int16 x, ref Single y) => y = (Single)x; }
		struct Op_Cast_UInt64Single : IBinaryOperator<UInt64, Single> { public void Operate(ref UInt64 x, ref Single y) => y = (Single)x; }
		struct Op_Cast_UInt32Single : IBinaryOperator<UInt32, Single> { public void Operate(ref UInt32 x, ref Single y) => y = (Single)x; }
		struct Op_Cast_UInt16Single : IBinaryOperator<UInt16, Single> { public void Operate(ref UInt16 x, ref Single y) => y = (Single)x; }
		struct Op_Cast_ByteSingle : IBinaryOperator<Byte, Single> { public void Operate(ref Byte x, ref Single y) => y = (Single)x; }
		struct Op_Cast_DoubleInt64 : IBinaryOperator<Double, Int64> { public void Operate(ref Double x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_SingleInt64 : IBinaryOperator<Single, Int64> { public void Operate(ref Single x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_Int64Int64 : IBinaryOperator<Int64, Int64> { public void Operate(ref Int64 x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_Int32Int64 : IBinaryOperator<Int32, Int64> { public void Operate(ref Int32 x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_Int16Int64 : IBinaryOperator<Int16, Int64> { public void Operate(ref Int16 x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_UInt64Int64 : IBinaryOperator<UInt64, Int64> { public void Operate(ref UInt64 x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_UInt32Int64 : IBinaryOperator<UInt32, Int64> { public void Operate(ref UInt32 x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_UInt16Int64 : IBinaryOperator<UInt16, Int64> { public void Operate(ref UInt16 x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_ByteInt64 : IBinaryOperator<Byte, Int64> { public void Operate(ref Byte x, ref Int64 y) => y = (Int64)x; }
		struct Op_Cast_DoubleInt16 : IBinaryOperator<Double, Int16> { public void Operate(ref Double x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_SingleInt16 : IBinaryOperator<Single, Int16> { public void Operate(ref Single x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_Int64Int16 : IBinaryOperator<Int64, Int16> { public void Operate(ref Int64 x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_Int32Int16 : IBinaryOperator<Int32, Int16> { public void Operate(ref Int32 x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_Int16Int16 : IBinaryOperator<Int16, Int16> { public void Operate(ref Int16 x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_UInt64Int16 : IBinaryOperator<UInt64, Int16> { public void Operate(ref UInt64 x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_UInt32Int16 : IBinaryOperator<UInt32, Int16> { public void Operate(ref UInt32 x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_UInt16Int16 : IBinaryOperator<UInt16, Int16> { public void Operate(ref UInt16 x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_ByteInt16 : IBinaryOperator<Byte, Int16> { public void Operate(ref Byte x, ref Int16 y) => y = (Int16)x; }
		struct Op_Cast_DoubleUInt64 : IBinaryOperator<Double, UInt64> { public void Operate(ref Double x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_SingleUInt64 : IBinaryOperator<Single, UInt64> { public void Operate(ref Single x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_Int64UInt64 : IBinaryOperator<Int64, UInt64> { public void Operate(ref Int64 x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_Int32UInt64 : IBinaryOperator<Int32, UInt64> { public void Operate(ref Int32 x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_Int16UInt64 : IBinaryOperator<Int16, UInt64> { public void Operate(ref Int16 x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_UInt64UInt64 : IBinaryOperator<UInt64, UInt64> { public void Operate(ref UInt64 x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_UInt32UInt64 : IBinaryOperator<UInt32, UInt64> { public void Operate(ref UInt32 x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_UInt16UInt64 : IBinaryOperator<UInt16, UInt64> { public void Operate(ref UInt16 x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_ByteUInt64 : IBinaryOperator<Byte, UInt64> { public void Operate(ref Byte x, ref UInt64 y) => y = (UInt64)x; }
		struct Op_Cast_DoubleUInt32 : IBinaryOperator<Double, UInt32> { public void Operate(ref Double x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_SingleUInt32 : IBinaryOperator<Single, UInt32> { public void Operate(ref Single x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_Int64UInt32 : IBinaryOperator<Int64, UInt32> { public void Operate(ref Int64 x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_Int32UInt32 : IBinaryOperator<Int32, UInt32> { public void Operate(ref Int32 x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_Int16UInt32 : IBinaryOperator<Int16, UInt32> { public void Operate(ref Int16 x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_UInt64UInt32 : IBinaryOperator<UInt64, UInt32> { public void Operate(ref UInt64 x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_UInt32UInt32 : IBinaryOperator<UInt32, UInt32> { public void Operate(ref UInt32 x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_UInt16UInt32 : IBinaryOperator<UInt16, UInt32> { public void Operate(ref UInt16 x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_ByteUInt32 : IBinaryOperator<Byte, UInt32> { public void Operate(ref Byte x, ref UInt32 y) => y = (UInt32)x; }
		struct Op_Cast_DoubleUInt16 : IBinaryOperator<Double, UInt16> { public void Operate(ref Double x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_SingleUInt16 : IBinaryOperator<Single, UInt16> { public void Operate(ref Single x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_Int64UInt16 : IBinaryOperator<Int64, UInt16> { public void Operate(ref Int64 x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_Int32UInt16 : IBinaryOperator<Int32, UInt16> { public void Operate(ref Int32 x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_Int16UInt16 : IBinaryOperator<Int16, UInt16> { public void Operate(ref Int16 x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_UInt64UInt16 : IBinaryOperator<UInt64, UInt16> { public void Operate(ref UInt64 x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_UInt32UInt16 : IBinaryOperator<UInt32, UInt16> { public void Operate(ref UInt32 x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_UInt16UInt16 : IBinaryOperator<UInt16, UInt16> { public void Operate(ref UInt16 x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_ByteUInt16 : IBinaryOperator<Byte, UInt16> { public void Operate(ref Byte x, ref UInt16 y) => y = (UInt16)x; }
		struct Op_Cast_DoubleByte : IBinaryOperator<Double, Byte> { public void Operate(ref Double x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_SingleByte : IBinaryOperator<Single, Byte> { public void Operate(ref Single x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_Int64Byte : IBinaryOperator<Int64, Byte> { public void Operate(ref Int64 x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_Int32Byte : IBinaryOperator<Int32, Byte> { public void Operate(ref Int32 x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_Int16Byte : IBinaryOperator<Int16, Byte> { public void Operate(ref Int16 x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_UInt64Byte : IBinaryOperator<UInt64, Byte> { public void Operate(ref UInt64 x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_UInt32Byte : IBinaryOperator<UInt32, Byte> { public void Operate(ref UInt32 x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_UInt16Byte : IBinaryOperator<UInt16, Byte> { public void Operate(ref UInt16 x, ref Byte y) => y = (Byte)x; }
		struct Op_Cast_ByteByte : IBinaryOperator<Byte, Byte> { public void Operate(ref Byte x, ref Byte y) => y = (Byte)x; }

    }
}