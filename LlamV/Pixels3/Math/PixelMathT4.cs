using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pixels;

        //メソッドチェーンでfunc += hogeで並べるようにする？



namespace Pixels.Math
{

    public static partial class PixelMath
    {

        #region Cast

        
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Boolean> src) where TResult : struct, IComparable
            => ToPixel<Boolean, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Byte> src) where TResult : struct, IComparable
            => ToPixel<Byte, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<UInt16> src) where TResult : struct, IComparable
            => ToPixel<UInt16, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<UInt32> src) where TResult : struct, IComparable
            => ToPixel<UInt32, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<UInt64> src) where TResult : struct, IComparable
            => ToPixel<UInt64, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Int16> src) where TResult : struct, IComparable
            => ToPixel<Int16, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Int32> src) where TResult : struct, IComparable
            => ToPixel<Int32, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Int64> src) where TResult : struct, IComparable
            => ToPixel<Int64, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Single> src) where TResult : struct, IComparable
            => ToPixel<Single, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Double> src) where TResult : struct, IComparable
            => ToPixel<Double, TResult>(src);

        public static Pixel<TResult> ToPixel<T1, TResult>(this Pixel<T1> src)
        where T1 : struct, IComparable
        where TResult : struct, IComparable
        {
            return
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<Byte>(), default(Op_Cast_BooleanByte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<Byte>(), default(Op_Cast_ByteByte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<Byte>(), default(Op_Cast_UInt16Byte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<Byte>(), default(Op_Cast_UInt32Byte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<Byte>(), default(Op_Cast_UInt64Byte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<Byte>(), default(Op_Cast_Int16Byte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<Byte>(), default(Op_Cast_Int32Byte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<Byte>(), default(Op_Cast_Int64Byte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<Byte>(), default(Op_Cast_SingleByte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<Byte>(), default(Op_Cast_DoubleByte)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_BooleanUInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_ByteUInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_UInt16UInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_UInt32UInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_UInt64UInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_Int16UInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_Int32UInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_Int64UInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_SingleUInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<UInt16>(), default(Op_Cast_DoubleUInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_BooleanUInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_ByteUInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_UInt16UInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_UInt32UInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_UInt64UInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_Int16UInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_Int32UInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_Int64UInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_SingleUInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<UInt32>(), default(Op_Cast_DoubleUInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_BooleanUInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_ByteUInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_UInt16UInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_UInt32UInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_UInt64UInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_Int16UInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_Int32UInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_Int64UInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_SingleUInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<UInt64>(), default(Op_Cast_DoubleUInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<Int16>(), default(Op_Cast_BooleanInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<Int16>(), default(Op_Cast_ByteInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<Int16>(), default(Op_Cast_UInt16Int16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<Int16>(), default(Op_Cast_UInt32Int16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<Int16>(), default(Op_Cast_UInt64Int16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<Int16>(), default(Op_Cast_Int16Int16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<Int16>(), default(Op_Cast_Int32Int16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<Int16>(), default(Op_Cast_Int64Int16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<Int16>(), default(Op_Cast_SingleInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<Int16>(), default(Op_Cast_DoubleInt16)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<Int32>(), default(Op_Cast_BooleanInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<Int32>(), default(Op_Cast_ByteInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<Int32>(), default(Op_Cast_UInt16Int32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<Int32>(), default(Op_Cast_UInt32Int32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<Int32>(), default(Op_Cast_UInt64Int32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<Int32>(), default(Op_Cast_Int16Int32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<Int32>(), default(Op_Cast_Int32Int32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<Int32>(), default(Op_Cast_Int64Int32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<Int32>(), default(Op_Cast_SingleInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<Int32>(), default(Op_Cast_DoubleInt32)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<Int64>(), default(Op_Cast_BooleanInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<Int64>(), default(Op_Cast_ByteInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<Int64>(), default(Op_Cast_UInt16Int64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<Int64>(), default(Op_Cast_UInt32Int64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<Int64>(), default(Op_Cast_UInt64Int64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<Int64>(), default(Op_Cast_Int16Int64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<Int64>(), default(Op_Cast_Int32Int64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<Int64>(), default(Op_Cast_Int64Int64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<Int64>(), default(Op_Cast_SingleInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<Int64>(), default(Op_Cast_DoubleInt64)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<Single>(), default(Op_Cast_BooleanSingle)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<Single>(), default(Op_Cast_ByteSingle)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<Single>(), default(Op_Cast_UInt16Single)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<Single>(), default(Op_Cast_UInt32Single)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<Single>(), default(Op_Cast_UInt64Single)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<Single>(), default(Op_Cast_Int16Single)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<Single>(), default(Op_Cast_Int32Single)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<Single>(), default(Op_Cast_Int64Single)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<Single>(), default(Op_Cast_SingleSingle)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<Single>(), default(Op_Cast_DoubleSingle)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Boolean) 
                    ? (src as Pixel<Boolean>).Accumulate(src.Clone<Double>(), default(Op_Cast_BooleanDouble)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Byte) 
                    ? (src as Pixel<Byte>).Accumulate(src.Clone<Double>(), default(Op_Cast_ByteDouble)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(UInt16) 
                    ? (src as Pixel<UInt16>).Accumulate(src.Clone<Double>(), default(Op_Cast_UInt16Double)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(UInt32) 
                    ? (src as Pixel<UInt32>).Accumulate(src.Clone<Double>(), default(Op_Cast_UInt32Double)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(UInt64) 
                    ? (src as Pixel<UInt64>).Accumulate(src.Clone<Double>(), default(Op_Cast_UInt64Double)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Int16) 
                    ? (src as Pixel<Int16>).Accumulate(src.Clone<Double>(), default(Op_Cast_Int16Double)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<Double>(), default(Op_Cast_Int32Double)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Int64) 
                    ? (src as Pixel<Int64>).Accumulate(src.Clone<Double>(), default(Op_Cast_Int64Double)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Single) 
                    ? (src as Pixel<Single>).Accumulate(src.Clone<Double>(), default(Op_Cast_SingleDouble)) as Pixel<TResult> :
                
                typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Double) 
                    ? (src as Pixel<Double>).Accumulate(src.Clone<Double>(), default(Op_Cast_DoubleDouble)) as Pixel<TResult> :
                
                throw new FormatException($"{typeof(T1)},{typeof(TResult)}");
        }

        
        struct Op_Cast_ByteByte : IBinaryOperator<Byte, Byte>{ public void Operate(ref Byte x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_UInt16Byte : IBinaryOperator<UInt16, Byte>{ public void Operate(ref UInt16 x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_UInt32Byte : IBinaryOperator<UInt32, Byte>{ public void Operate(ref UInt32 x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_UInt64Byte : IBinaryOperator<UInt64, Byte>{ public void Operate(ref UInt64 x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_Int16Byte : IBinaryOperator<Int16, Byte>{ public void Operate(ref Int16 x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_Int32Byte : IBinaryOperator<Int32, Byte>{ public void Operate(ref Int32 x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_Int64Byte : IBinaryOperator<Int64, Byte>{ public void Operate(ref Int64 x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_SingleByte : IBinaryOperator<Single, Byte>{ public void Operate(ref Single x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_DoubleByte : IBinaryOperator<Double, Byte>{ public void Operate(ref Double x, ref Byte y) => y = (Byte)x; }
        struct Op_Cast_ByteUInt16 : IBinaryOperator<Byte, UInt16>{ public void Operate(ref Byte x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_UInt16UInt16 : IBinaryOperator<UInt16, UInt16>{ public void Operate(ref UInt16 x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_UInt32UInt16 : IBinaryOperator<UInt32, UInt16>{ public void Operate(ref UInt32 x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_UInt64UInt16 : IBinaryOperator<UInt64, UInt16>{ public void Operate(ref UInt64 x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_Int16UInt16 : IBinaryOperator<Int16, UInt16>{ public void Operate(ref Int16 x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_Int32UInt16 : IBinaryOperator<Int32, UInt16>{ public void Operate(ref Int32 x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_Int64UInt16 : IBinaryOperator<Int64, UInt16>{ public void Operate(ref Int64 x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_SingleUInt16 : IBinaryOperator<Single, UInt16>{ public void Operate(ref Single x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_DoubleUInt16 : IBinaryOperator<Double, UInt16>{ public void Operate(ref Double x, ref UInt16 y) => y = (UInt16)x; }
        struct Op_Cast_ByteUInt32 : IBinaryOperator<Byte, UInt32>{ public void Operate(ref Byte x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_UInt16UInt32 : IBinaryOperator<UInt16, UInt32>{ public void Operate(ref UInt16 x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_UInt32UInt32 : IBinaryOperator<UInt32, UInt32>{ public void Operate(ref UInt32 x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_UInt64UInt32 : IBinaryOperator<UInt64, UInt32>{ public void Operate(ref UInt64 x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_Int16UInt32 : IBinaryOperator<Int16, UInt32>{ public void Operate(ref Int16 x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_Int32UInt32 : IBinaryOperator<Int32, UInt32>{ public void Operate(ref Int32 x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_Int64UInt32 : IBinaryOperator<Int64, UInt32>{ public void Operate(ref Int64 x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_SingleUInt32 : IBinaryOperator<Single, UInt32>{ public void Operate(ref Single x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_DoubleUInt32 : IBinaryOperator<Double, UInt32>{ public void Operate(ref Double x, ref UInt32 y) => y = (UInt32)x; }
        struct Op_Cast_ByteUInt64 : IBinaryOperator<Byte, UInt64>{ public void Operate(ref Byte x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_UInt16UInt64 : IBinaryOperator<UInt16, UInt64>{ public void Operate(ref UInt16 x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_UInt32UInt64 : IBinaryOperator<UInt32, UInt64>{ public void Operate(ref UInt32 x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_UInt64UInt64 : IBinaryOperator<UInt64, UInt64>{ public void Operate(ref UInt64 x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_Int16UInt64 : IBinaryOperator<Int16, UInt64>{ public void Operate(ref Int16 x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_Int32UInt64 : IBinaryOperator<Int32, UInt64>{ public void Operate(ref Int32 x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_Int64UInt64 : IBinaryOperator<Int64, UInt64>{ public void Operate(ref Int64 x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_SingleUInt64 : IBinaryOperator<Single, UInt64>{ public void Operate(ref Single x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_DoubleUInt64 : IBinaryOperator<Double, UInt64>{ public void Operate(ref Double x, ref UInt64 y) => y = (UInt64)x; }
        struct Op_Cast_ByteInt16 : IBinaryOperator<Byte, Int16>{ public void Operate(ref Byte x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_UInt16Int16 : IBinaryOperator<UInt16, Int16>{ public void Operate(ref UInt16 x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_UInt32Int16 : IBinaryOperator<UInt32, Int16>{ public void Operate(ref UInt32 x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_UInt64Int16 : IBinaryOperator<UInt64, Int16>{ public void Operate(ref UInt64 x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_Int16Int16 : IBinaryOperator<Int16, Int16>{ public void Operate(ref Int16 x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_Int32Int16 : IBinaryOperator<Int32, Int16>{ public void Operate(ref Int32 x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_Int64Int16 : IBinaryOperator<Int64, Int16>{ public void Operate(ref Int64 x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_SingleInt16 : IBinaryOperator<Single, Int16>{ public void Operate(ref Single x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_DoubleInt16 : IBinaryOperator<Double, Int16>{ public void Operate(ref Double x, ref Int16 y) => y = (Int16)x; }
        struct Op_Cast_ByteInt32 : IBinaryOperator<Byte, Int32>{ public void Operate(ref Byte x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_UInt16Int32 : IBinaryOperator<UInt16, Int32>{ public void Operate(ref UInt16 x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_UInt32Int32 : IBinaryOperator<UInt32, Int32>{ public void Operate(ref UInt32 x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_UInt64Int32 : IBinaryOperator<UInt64, Int32>{ public void Operate(ref UInt64 x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_Int16Int32 : IBinaryOperator<Int16, Int32>{ public void Operate(ref Int16 x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_Int32Int32 : IBinaryOperator<Int32, Int32>{ public void Operate(ref Int32 x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_Int64Int32 : IBinaryOperator<Int64, Int32>{ public void Operate(ref Int64 x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_SingleInt32 : IBinaryOperator<Single, Int32>{ public void Operate(ref Single x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_DoubleInt32 : IBinaryOperator<Double, Int32>{ public void Operate(ref Double x, ref Int32 y) => y = (Int32)x; }
        struct Op_Cast_ByteInt64 : IBinaryOperator<Byte, Int64>{ public void Operate(ref Byte x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_UInt16Int64 : IBinaryOperator<UInt16, Int64>{ public void Operate(ref UInt16 x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_UInt32Int64 : IBinaryOperator<UInt32, Int64>{ public void Operate(ref UInt32 x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_UInt64Int64 : IBinaryOperator<UInt64, Int64>{ public void Operate(ref UInt64 x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_Int16Int64 : IBinaryOperator<Int16, Int64>{ public void Operate(ref Int16 x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_Int32Int64 : IBinaryOperator<Int32, Int64>{ public void Operate(ref Int32 x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_Int64Int64 : IBinaryOperator<Int64, Int64>{ public void Operate(ref Int64 x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_SingleInt64 : IBinaryOperator<Single, Int64>{ public void Operate(ref Single x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_DoubleInt64 : IBinaryOperator<Double, Int64>{ public void Operate(ref Double x, ref Int64 y) => y = (Int64)x; }
        struct Op_Cast_ByteSingle : IBinaryOperator<Byte, Single>{ public void Operate(ref Byte x, ref Single y) => y = (Single)x; }
        struct Op_Cast_UInt16Single : IBinaryOperator<UInt16, Single>{ public void Operate(ref UInt16 x, ref Single y) => y = (Single)x; }
        struct Op_Cast_UInt32Single : IBinaryOperator<UInt32, Single>{ public void Operate(ref UInt32 x, ref Single y) => y = (Single)x; }
        struct Op_Cast_UInt64Single : IBinaryOperator<UInt64, Single>{ public void Operate(ref UInt64 x, ref Single y) => y = (Single)x; }
        struct Op_Cast_Int16Single : IBinaryOperator<Int16, Single>{ public void Operate(ref Int16 x, ref Single y) => y = (Single)x; }
        struct Op_Cast_Int32Single : IBinaryOperator<Int32, Single>{ public void Operate(ref Int32 x, ref Single y) => y = (Single)x; }
        struct Op_Cast_Int64Single : IBinaryOperator<Int64, Single>{ public void Operate(ref Int64 x, ref Single y) => y = (Single)x; }
        struct Op_Cast_SingleSingle : IBinaryOperator<Single, Single>{ public void Operate(ref Single x, ref Single y) => y = (Single)x; }
        struct Op_Cast_DoubleSingle : IBinaryOperator<Double, Single>{ public void Operate(ref Double x, ref Single y) => y = (Single)x; }
        struct Op_Cast_ByteDouble : IBinaryOperator<Byte, Double>{ public void Operate(ref Byte x, ref Double y) => y = (Double)x; }
        struct Op_Cast_UInt16Double : IBinaryOperator<UInt16, Double>{ public void Operate(ref UInt16 x, ref Double y) => y = (Double)x; }
        struct Op_Cast_UInt32Double : IBinaryOperator<UInt32, Double>{ public void Operate(ref UInt32 x, ref Double y) => y = (Double)x; }
        struct Op_Cast_UInt64Double : IBinaryOperator<UInt64, Double>{ public void Operate(ref UInt64 x, ref Double y) => y = (Double)x; }
        struct Op_Cast_Int16Double : IBinaryOperator<Int16, Double>{ public void Operate(ref Int16 x, ref Double y) => y = (Double)x; }
        struct Op_Cast_Int32Double : IBinaryOperator<Int32, Double>{ public void Operate(ref Int32 x, ref Double y) => y = (Double)x; }
        struct Op_Cast_Int64Double : IBinaryOperator<Int64, Double>{ public void Operate(ref Int64 x, ref Double y) => y = (Double)x; }
        struct Op_Cast_SingleDouble : IBinaryOperator<Single, Double>{ public void Operate(ref Single x, ref Double y) => y = (Double)x; }
        struct Op_Cast_DoubleDouble : IBinaryOperator<Double, Double>{ public void Operate(ref Double x, ref Double y) => y = (Double)x; }

        //struct Op_Cast_Int32Byte : IBinaryOperator<Int32, Byte> { public void Operate(ref Int32 x, ref Byte y) => y = (x > Byte.MaxValue ? Byte.MaxValue : x < Byte.MinValue ? Byte.MinValue : (Byte)x); }

        
        struct Op_Cast_BooleanByte : IBinaryOperator<Boolean, Byte> { public void Operate(ref Boolean x, ref Byte y) => y = x ? Byte.MaxValue : (Byte)0; }
        struct Op_Cast_BooleanUInt16 : IBinaryOperator<Boolean, UInt16> { public void Operate(ref Boolean x, ref UInt16 y) => y = x ? UInt16.MaxValue : (UInt16)0; }
        struct Op_Cast_BooleanUInt32 : IBinaryOperator<Boolean, UInt32> { public void Operate(ref Boolean x, ref UInt32 y) => y = x ? UInt32.MaxValue : (UInt32)0; }
        struct Op_Cast_BooleanUInt64 : IBinaryOperator<Boolean, UInt64> { public void Operate(ref Boolean x, ref UInt64 y) => y = x ? UInt64.MaxValue : (UInt64)0; }
        struct Op_Cast_BooleanInt16 : IBinaryOperator<Boolean, Int16> { public void Operate(ref Boolean x, ref Int16 y) => y = x ? Int16.MaxValue : (Int16)0; }
        struct Op_Cast_BooleanInt32 : IBinaryOperator<Boolean, Int32> { public void Operate(ref Boolean x, ref Int32 y) => y = x ? Int32.MaxValue : (Int32)0; }
        struct Op_Cast_BooleanInt64 : IBinaryOperator<Boolean, Int64> { public void Operate(ref Boolean x, ref Int64 y) => y = x ? Int64.MaxValue : (Int64)0; }
        struct Op_Cast_BooleanSingle : IBinaryOperator<Boolean, Single> { public void Operate(ref Boolean x, ref Single y) => y = x ? Single.MaxValue : (Single)0; }
        struct Op_Cast_BooleanDouble : IBinaryOperator<Boolean, Double> { public void Operate(ref Boolean x, ref Double y) => y = x ? Double.MaxValue : (Double)0; }

        #endregion


        //二値化
        public static Pixel<bool> Binarization<T>(this Pixel<T> src, Func<T, bool, bool> func, Pixel<bool> dst = null) where T : struct, IComparable
        {
            dst = dst ?? src.Clone<bool>();
            if (func == null) func = (x, y) => x.CompareTo(0) == 0;

            foreach (var i in src.GetIndex())
                dst[i] = func(src[i], dst[i]);

            return dst;
        }


        #region Op

        //UInt64と他の演算は明示キャストしないとだめなので省略
        
        struct Op_Add_ByteByte : IBinaryOperator<Byte, Byte, Byte> { public void Operate(ref Byte x, ref Byte y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_ByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public void Operate(ref Byte x, ref UInt16 y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_ByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public void Operate(ref Byte x, ref UInt32 y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_ByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public void Operate(ref Byte x, ref Int16 y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_ByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public void Operate(ref Byte x, ref Int32 y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_ByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public void Operate(ref Byte x, ref Int64 y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_ByteSingle : IBinaryOperator<Byte, Single, Byte> { public void Operate(ref Byte x, ref Single y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_ByteDouble : IBinaryOperator<Byte, Double, Byte> { public void Operate(ref Byte x, ref Double y, ref Byte z) => z = (Byte)(x + y); }
        struct Op_Add_UInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public void Operate(ref UInt16 x, ref Byte y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public void Operate(ref UInt16 x, ref UInt16 y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public void Operate(ref UInt16 x, ref UInt32 y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public void Operate(ref UInt16 x, ref Int16 y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public void Operate(ref UInt16 x, ref Int32 y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public void Operate(ref UInt16 x, ref Int64 y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public void Operate(ref UInt16 x, ref Single y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public void Operate(ref UInt16 x, ref Double y, ref UInt16 z) => z = (UInt16)(x + y); }
        struct Op_Add_UInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public void Operate(ref UInt32 x, ref Byte y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_UInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public void Operate(ref UInt32 x, ref UInt16 y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_UInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public void Operate(ref UInt32 x, ref UInt32 y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_UInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public void Operate(ref UInt32 x, ref Int16 y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_UInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public void Operate(ref UInt32 x, ref Int32 y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_UInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public void Operate(ref UInt32 x, ref Int64 y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_UInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public void Operate(ref UInt32 x, ref Single y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_UInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public void Operate(ref UInt32 x, ref Double y, ref UInt32 z) => z = (UInt32)(x + y); }
        struct Op_Add_Int16Byte : IBinaryOperator<Int16, Byte, Int16> { public void Operate(ref Int16 x, ref Byte y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public void Operate(ref Int16 x, ref UInt16 y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public void Operate(ref Int16 x, ref UInt32 y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int16Int16 : IBinaryOperator<Int16, Int16, Int16> { public void Operate(ref Int16 x, ref Int16 y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int16Int32 : IBinaryOperator<Int16, Int32, Int16> { public void Operate(ref Int16 x, ref Int32 y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int16Int64 : IBinaryOperator<Int16, Int64, Int16> { public void Operate(ref Int16 x, ref Int64 y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int16Single : IBinaryOperator<Int16, Single, Int16> { public void Operate(ref Int16 x, ref Single y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int16Double : IBinaryOperator<Int16, Double, Int16> { public void Operate(ref Int16 x, ref Double y, ref Int16 z) => z = (Int16)(x + y); }
        struct Op_Add_Int32Byte : IBinaryOperator<Int32, Byte, Int32> { public void Operate(ref Int32 x, ref Byte y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public void Operate(ref Int32 x, ref UInt16 y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public void Operate(ref Int32 x, ref UInt32 y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int32Int16 : IBinaryOperator<Int32, Int16, Int32> { public void Operate(ref Int32 x, ref Int16 y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int32Int32 : IBinaryOperator<Int32, Int32, Int32> { public void Operate(ref Int32 x, ref Int32 y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int32Int64 : IBinaryOperator<Int32, Int64, Int32> { public void Operate(ref Int32 x, ref Int64 y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int32Single : IBinaryOperator<Int32, Single, Int32> { public void Operate(ref Int32 x, ref Single y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int32Double : IBinaryOperator<Int32, Double, Int32> { public void Operate(ref Int32 x, ref Double y, ref Int32 z) => z = (Int32)(x + y); }
        struct Op_Add_Int64Byte : IBinaryOperator<Int64, Byte, Int64> { public void Operate(ref Int64 x, ref Byte y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_Int64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public void Operate(ref Int64 x, ref UInt16 y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_Int64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public void Operate(ref Int64 x, ref UInt32 y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_Int64Int16 : IBinaryOperator<Int64, Int16, Int64> { public void Operate(ref Int64 x, ref Int16 y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_Int64Int32 : IBinaryOperator<Int64, Int32, Int64> { public void Operate(ref Int64 x, ref Int32 y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_Int64Int64 : IBinaryOperator<Int64, Int64, Int64> { public void Operate(ref Int64 x, ref Int64 y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_Int64Single : IBinaryOperator<Int64, Single, Int64> { public void Operate(ref Int64 x, ref Single y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_Int64Double : IBinaryOperator<Int64, Double, Int64> { public void Operate(ref Int64 x, ref Double y, ref Int64 z) => z = (Int64)(x + y); }
        struct Op_Add_SingleByte : IBinaryOperator<Single, Byte, Single> { public void Operate(ref Single x, ref Byte y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_SingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public void Operate(ref Single x, ref UInt16 y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_SingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public void Operate(ref Single x, ref UInt32 y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_SingleInt16 : IBinaryOperator<Single, Int16, Single> { public void Operate(ref Single x, ref Int16 y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_SingleInt32 : IBinaryOperator<Single, Int32, Single> { public void Operate(ref Single x, ref Int32 y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_SingleInt64 : IBinaryOperator<Single, Int64, Single> { public void Operate(ref Single x, ref Int64 y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_SingleSingle : IBinaryOperator<Single, Single, Single> { public void Operate(ref Single x, ref Single y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_SingleDouble : IBinaryOperator<Single, Double, Single> { public void Operate(ref Single x, ref Double y, ref Single z) => z = (Single)(x + y); }
        struct Op_Add_DoubleByte : IBinaryOperator<Double, Byte, Double> { public void Operate(ref Double x, ref Byte y, ref Double z) => z = (Double)(x + y); }
        struct Op_Add_DoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public void Operate(ref Double x, ref UInt16 y, ref Double z) => z = (Double)(x + y); }
        struct Op_Add_DoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public void Operate(ref Double x, ref UInt32 y, ref Double z) => z = (Double)(x + y); }
        struct Op_Add_DoubleInt16 : IBinaryOperator<Double, Int16, Double> { public void Operate(ref Double x, ref Int16 y, ref Double z) => z = (Double)(x + y); }
        struct Op_Add_DoubleInt32 : IBinaryOperator<Double, Int32, Double> { public void Operate(ref Double x, ref Int32 y, ref Double z) => z = (Double)(x + y); }
        struct Op_Add_DoubleInt64 : IBinaryOperator<Double, Int64, Double> { public void Operate(ref Double x, ref Int64 y, ref Double z) => z = (Double)(x + y); }
        struct Op_Add_DoubleSingle : IBinaryOperator<Double, Single, Double> { public void Operate(ref Double x, ref Single y, ref Double z) => z = (Double)(x + y); }
        struct Op_Add_DoubleDouble : IBinaryOperator<Double, Double, Double> { public void Operate(ref Double x, ref Double y, ref Double z) => z = (Double)(x + y); }
        struct Op_Sub_ByteByte : IBinaryOperator<Byte, Byte, Byte> { public void Operate(ref Byte x, ref Byte y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_ByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public void Operate(ref Byte x, ref UInt16 y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_ByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public void Operate(ref Byte x, ref UInt32 y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_ByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public void Operate(ref Byte x, ref Int16 y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_ByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public void Operate(ref Byte x, ref Int32 y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_ByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public void Operate(ref Byte x, ref Int64 y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_ByteSingle : IBinaryOperator<Byte, Single, Byte> { public void Operate(ref Byte x, ref Single y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_ByteDouble : IBinaryOperator<Byte, Double, Byte> { public void Operate(ref Byte x, ref Double y, ref Byte z) => z = (Byte)(x - y); }
        struct Op_Sub_UInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public void Operate(ref UInt16 x, ref Byte y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public void Operate(ref UInt16 x, ref UInt16 y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public void Operate(ref UInt16 x, ref UInt32 y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public void Operate(ref UInt16 x, ref Int16 y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public void Operate(ref UInt16 x, ref Int32 y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public void Operate(ref UInt16 x, ref Int64 y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public void Operate(ref UInt16 x, ref Single y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public void Operate(ref UInt16 x, ref Double y, ref UInt16 z) => z = (UInt16)(x - y); }
        struct Op_Sub_UInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public void Operate(ref UInt32 x, ref Byte y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_UInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public void Operate(ref UInt32 x, ref UInt16 y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_UInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public void Operate(ref UInt32 x, ref UInt32 y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_UInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public void Operate(ref UInt32 x, ref Int16 y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_UInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public void Operate(ref UInt32 x, ref Int32 y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_UInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public void Operate(ref UInt32 x, ref Int64 y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_UInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public void Operate(ref UInt32 x, ref Single y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_UInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public void Operate(ref UInt32 x, ref Double y, ref UInt32 z) => z = (UInt32)(x - y); }
        struct Op_Sub_Int16Byte : IBinaryOperator<Int16, Byte, Int16> { public void Operate(ref Int16 x, ref Byte y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public void Operate(ref Int16 x, ref UInt16 y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public void Operate(ref Int16 x, ref UInt32 y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int16Int16 : IBinaryOperator<Int16, Int16, Int16> { public void Operate(ref Int16 x, ref Int16 y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int16Int32 : IBinaryOperator<Int16, Int32, Int16> { public void Operate(ref Int16 x, ref Int32 y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int16Int64 : IBinaryOperator<Int16, Int64, Int16> { public void Operate(ref Int16 x, ref Int64 y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int16Single : IBinaryOperator<Int16, Single, Int16> { public void Operate(ref Int16 x, ref Single y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int16Double : IBinaryOperator<Int16, Double, Int16> { public void Operate(ref Int16 x, ref Double y, ref Int16 z) => z = (Int16)(x - y); }
        struct Op_Sub_Int32Byte : IBinaryOperator<Int32, Byte, Int32> { public void Operate(ref Int32 x, ref Byte y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public void Operate(ref Int32 x, ref UInt16 y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public void Operate(ref Int32 x, ref UInt32 y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int32Int16 : IBinaryOperator<Int32, Int16, Int32> { public void Operate(ref Int32 x, ref Int16 y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int32Int32 : IBinaryOperator<Int32, Int32, Int32> { public void Operate(ref Int32 x, ref Int32 y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int32Int64 : IBinaryOperator<Int32, Int64, Int32> { public void Operate(ref Int32 x, ref Int64 y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int32Single : IBinaryOperator<Int32, Single, Int32> { public void Operate(ref Int32 x, ref Single y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int32Double : IBinaryOperator<Int32, Double, Int32> { public void Operate(ref Int32 x, ref Double y, ref Int32 z) => z = (Int32)(x - y); }
        struct Op_Sub_Int64Byte : IBinaryOperator<Int64, Byte, Int64> { public void Operate(ref Int64 x, ref Byte y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_Int64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public void Operate(ref Int64 x, ref UInt16 y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_Int64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public void Operate(ref Int64 x, ref UInt32 y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_Int64Int16 : IBinaryOperator<Int64, Int16, Int64> { public void Operate(ref Int64 x, ref Int16 y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_Int64Int32 : IBinaryOperator<Int64, Int32, Int64> { public void Operate(ref Int64 x, ref Int32 y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_Int64Int64 : IBinaryOperator<Int64, Int64, Int64> { public void Operate(ref Int64 x, ref Int64 y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_Int64Single : IBinaryOperator<Int64, Single, Int64> { public void Operate(ref Int64 x, ref Single y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_Int64Double : IBinaryOperator<Int64, Double, Int64> { public void Operate(ref Int64 x, ref Double y, ref Int64 z) => z = (Int64)(x - y); }
        struct Op_Sub_SingleByte : IBinaryOperator<Single, Byte, Single> { public void Operate(ref Single x, ref Byte y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_SingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public void Operate(ref Single x, ref UInt16 y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_SingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public void Operate(ref Single x, ref UInt32 y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_SingleInt16 : IBinaryOperator<Single, Int16, Single> { public void Operate(ref Single x, ref Int16 y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_SingleInt32 : IBinaryOperator<Single, Int32, Single> { public void Operate(ref Single x, ref Int32 y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_SingleInt64 : IBinaryOperator<Single, Int64, Single> { public void Operate(ref Single x, ref Int64 y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_SingleSingle : IBinaryOperator<Single, Single, Single> { public void Operate(ref Single x, ref Single y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_SingleDouble : IBinaryOperator<Single, Double, Single> { public void Operate(ref Single x, ref Double y, ref Single z) => z = (Single)(x - y); }
        struct Op_Sub_DoubleByte : IBinaryOperator<Double, Byte, Double> { public void Operate(ref Double x, ref Byte y, ref Double z) => z = (Double)(x - y); }
        struct Op_Sub_DoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public void Operate(ref Double x, ref UInt16 y, ref Double z) => z = (Double)(x - y); }
        struct Op_Sub_DoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public void Operate(ref Double x, ref UInt32 y, ref Double z) => z = (Double)(x - y); }
        struct Op_Sub_DoubleInt16 : IBinaryOperator<Double, Int16, Double> { public void Operate(ref Double x, ref Int16 y, ref Double z) => z = (Double)(x - y); }
        struct Op_Sub_DoubleInt32 : IBinaryOperator<Double, Int32, Double> { public void Operate(ref Double x, ref Int32 y, ref Double z) => z = (Double)(x - y); }
        struct Op_Sub_DoubleInt64 : IBinaryOperator<Double, Int64, Double> { public void Operate(ref Double x, ref Int64 y, ref Double z) => z = (Double)(x - y); }
        struct Op_Sub_DoubleSingle : IBinaryOperator<Double, Single, Double> { public void Operate(ref Double x, ref Single y, ref Double z) => z = (Double)(x - y); }
        struct Op_Sub_DoubleDouble : IBinaryOperator<Double, Double, Double> { public void Operate(ref Double x, ref Double y, ref Double z) => z = (Double)(x - y); }
        struct Op_Mul_ByteByte : IBinaryOperator<Byte, Byte, Byte> { public void Operate(ref Byte x, ref Byte y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_ByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public void Operate(ref Byte x, ref UInt16 y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_ByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public void Operate(ref Byte x, ref UInt32 y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_ByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public void Operate(ref Byte x, ref Int16 y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_ByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public void Operate(ref Byte x, ref Int32 y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_ByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public void Operate(ref Byte x, ref Int64 y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_ByteSingle : IBinaryOperator<Byte, Single, Byte> { public void Operate(ref Byte x, ref Single y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_ByteDouble : IBinaryOperator<Byte, Double, Byte> { public void Operate(ref Byte x, ref Double y, ref Byte z) => z = (Byte)(x * y); }
        struct Op_Mul_UInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public void Operate(ref UInt16 x, ref Byte y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public void Operate(ref UInt16 x, ref UInt16 y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public void Operate(ref UInt16 x, ref UInt32 y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public void Operate(ref UInt16 x, ref Int16 y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public void Operate(ref UInt16 x, ref Int32 y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public void Operate(ref UInt16 x, ref Int64 y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public void Operate(ref UInt16 x, ref Single y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public void Operate(ref UInt16 x, ref Double y, ref UInt16 z) => z = (UInt16)(x * y); }
        struct Op_Mul_UInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public void Operate(ref UInt32 x, ref Byte y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_UInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public void Operate(ref UInt32 x, ref UInt16 y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_UInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public void Operate(ref UInt32 x, ref UInt32 y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_UInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public void Operate(ref UInt32 x, ref Int16 y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_UInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public void Operate(ref UInt32 x, ref Int32 y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_UInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public void Operate(ref UInt32 x, ref Int64 y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_UInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public void Operate(ref UInt32 x, ref Single y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_UInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public void Operate(ref UInt32 x, ref Double y, ref UInt32 z) => z = (UInt32)(x * y); }
        struct Op_Mul_Int16Byte : IBinaryOperator<Int16, Byte, Int16> { public void Operate(ref Int16 x, ref Byte y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public void Operate(ref Int16 x, ref UInt16 y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public void Operate(ref Int16 x, ref UInt32 y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int16Int16 : IBinaryOperator<Int16, Int16, Int16> { public void Operate(ref Int16 x, ref Int16 y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int16Int32 : IBinaryOperator<Int16, Int32, Int16> { public void Operate(ref Int16 x, ref Int32 y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int16Int64 : IBinaryOperator<Int16, Int64, Int16> { public void Operate(ref Int16 x, ref Int64 y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int16Single : IBinaryOperator<Int16, Single, Int16> { public void Operate(ref Int16 x, ref Single y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int16Double : IBinaryOperator<Int16, Double, Int16> { public void Operate(ref Int16 x, ref Double y, ref Int16 z) => z = (Int16)(x * y); }
        struct Op_Mul_Int32Byte : IBinaryOperator<Int32, Byte, Int32> { public void Operate(ref Int32 x, ref Byte y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public void Operate(ref Int32 x, ref UInt16 y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public void Operate(ref Int32 x, ref UInt32 y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int32Int16 : IBinaryOperator<Int32, Int16, Int32> { public void Operate(ref Int32 x, ref Int16 y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int32Int32 : IBinaryOperator<Int32, Int32, Int32> { public void Operate(ref Int32 x, ref Int32 y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int32Int64 : IBinaryOperator<Int32, Int64, Int32> { public void Operate(ref Int32 x, ref Int64 y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int32Single : IBinaryOperator<Int32, Single, Int32> { public void Operate(ref Int32 x, ref Single y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int32Double : IBinaryOperator<Int32, Double, Int32> { public void Operate(ref Int32 x, ref Double y, ref Int32 z) => z = (Int32)(x * y); }
        struct Op_Mul_Int64Byte : IBinaryOperator<Int64, Byte, Int64> { public void Operate(ref Int64 x, ref Byte y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_Int64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public void Operate(ref Int64 x, ref UInt16 y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_Int64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public void Operate(ref Int64 x, ref UInt32 y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_Int64Int16 : IBinaryOperator<Int64, Int16, Int64> { public void Operate(ref Int64 x, ref Int16 y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_Int64Int32 : IBinaryOperator<Int64, Int32, Int64> { public void Operate(ref Int64 x, ref Int32 y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_Int64Int64 : IBinaryOperator<Int64, Int64, Int64> { public void Operate(ref Int64 x, ref Int64 y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_Int64Single : IBinaryOperator<Int64, Single, Int64> { public void Operate(ref Int64 x, ref Single y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_Int64Double : IBinaryOperator<Int64, Double, Int64> { public void Operate(ref Int64 x, ref Double y, ref Int64 z) => z = (Int64)(x * y); }
        struct Op_Mul_SingleByte : IBinaryOperator<Single, Byte, Single> { public void Operate(ref Single x, ref Byte y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_SingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public void Operate(ref Single x, ref UInt16 y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_SingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public void Operate(ref Single x, ref UInt32 y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_SingleInt16 : IBinaryOperator<Single, Int16, Single> { public void Operate(ref Single x, ref Int16 y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_SingleInt32 : IBinaryOperator<Single, Int32, Single> { public void Operate(ref Single x, ref Int32 y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_SingleInt64 : IBinaryOperator<Single, Int64, Single> { public void Operate(ref Single x, ref Int64 y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_SingleSingle : IBinaryOperator<Single, Single, Single> { public void Operate(ref Single x, ref Single y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_SingleDouble : IBinaryOperator<Single, Double, Single> { public void Operate(ref Single x, ref Double y, ref Single z) => z = (Single)(x * y); }
        struct Op_Mul_DoubleByte : IBinaryOperator<Double, Byte, Double> { public void Operate(ref Double x, ref Byte y, ref Double z) => z = (Double)(x * y); }
        struct Op_Mul_DoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public void Operate(ref Double x, ref UInt16 y, ref Double z) => z = (Double)(x * y); }
        struct Op_Mul_DoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public void Operate(ref Double x, ref UInt32 y, ref Double z) => z = (Double)(x * y); }
        struct Op_Mul_DoubleInt16 : IBinaryOperator<Double, Int16, Double> { public void Operate(ref Double x, ref Int16 y, ref Double z) => z = (Double)(x * y); }
        struct Op_Mul_DoubleInt32 : IBinaryOperator<Double, Int32, Double> { public void Operate(ref Double x, ref Int32 y, ref Double z) => z = (Double)(x * y); }
        struct Op_Mul_DoubleInt64 : IBinaryOperator<Double, Int64, Double> { public void Operate(ref Double x, ref Int64 y, ref Double z) => z = (Double)(x * y); }
        struct Op_Mul_DoubleSingle : IBinaryOperator<Double, Single, Double> { public void Operate(ref Double x, ref Single y, ref Double z) => z = (Double)(x * y); }
        struct Op_Mul_DoubleDouble : IBinaryOperator<Double, Double, Double> { public void Operate(ref Double x, ref Double y, ref Double z) => z = (Double)(x * y); }
        struct Op_Div_ByteByte : IBinaryOperator<Byte, Byte, Byte> { public void Operate(ref Byte x, ref Byte y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_ByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public void Operate(ref Byte x, ref UInt16 y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_ByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public void Operate(ref Byte x, ref UInt32 y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_ByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public void Operate(ref Byte x, ref Int16 y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_ByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public void Operate(ref Byte x, ref Int32 y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_ByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public void Operate(ref Byte x, ref Int64 y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_ByteSingle : IBinaryOperator<Byte, Single, Byte> { public void Operate(ref Byte x, ref Single y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_ByteDouble : IBinaryOperator<Byte, Double, Byte> { public void Operate(ref Byte x, ref Double y, ref Byte z) => z = (Byte)(x / y); }
        struct Op_Div_UInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public void Operate(ref UInt16 x, ref Byte y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public void Operate(ref UInt16 x, ref UInt16 y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public void Operate(ref UInt16 x, ref UInt32 y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public void Operate(ref UInt16 x, ref Int16 y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public void Operate(ref UInt16 x, ref Int32 y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public void Operate(ref UInt16 x, ref Int64 y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public void Operate(ref UInt16 x, ref Single y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public void Operate(ref UInt16 x, ref Double y, ref UInt16 z) => z = (UInt16)(x / y); }
        struct Op_Div_UInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public void Operate(ref UInt32 x, ref Byte y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_UInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public void Operate(ref UInt32 x, ref UInt16 y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_UInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public void Operate(ref UInt32 x, ref UInt32 y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_UInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public void Operate(ref UInt32 x, ref Int16 y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_UInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public void Operate(ref UInt32 x, ref Int32 y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_UInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public void Operate(ref UInt32 x, ref Int64 y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_UInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public void Operate(ref UInt32 x, ref Single y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_UInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public void Operate(ref UInt32 x, ref Double y, ref UInt32 z) => z = (UInt32)(x / y); }
        struct Op_Div_Int16Byte : IBinaryOperator<Int16, Byte, Int16> { public void Operate(ref Int16 x, ref Byte y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public void Operate(ref Int16 x, ref UInt16 y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public void Operate(ref Int16 x, ref UInt32 y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int16Int16 : IBinaryOperator<Int16, Int16, Int16> { public void Operate(ref Int16 x, ref Int16 y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int16Int32 : IBinaryOperator<Int16, Int32, Int16> { public void Operate(ref Int16 x, ref Int32 y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int16Int64 : IBinaryOperator<Int16, Int64, Int16> { public void Operate(ref Int16 x, ref Int64 y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int16Single : IBinaryOperator<Int16, Single, Int16> { public void Operate(ref Int16 x, ref Single y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int16Double : IBinaryOperator<Int16, Double, Int16> { public void Operate(ref Int16 x, ref Double y, ref Int16 z) => z = (Int16)(x / y); }
        struct Op_Div_Int32Byte : IBinaryOperator<Int32, Byte, Int32> { public void Operate(ref Int32 x, ref Byte y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public void Operate(ref Int32 x, ref UInt16 y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public void Operate(ref Int32 x, ref UInt32 y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int32Int16 : IBinaryOperator<Int32, Int16, Int32> { public void Operate(ref Int32 x, ref Int16 y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int32Int32 : IBinaryOperator<Int32, Int32, Int32> { public void Operate(ref Int32 x, ref Int32 y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int32Int64 : IBinaryOperator<Int32, Int64, Int32> { public void Operate(ref Int32 x, ref Int64 y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int32Single : IBinaryOperator<Int32, Single, Int32> { public void Operate(ref Int32 x, ref Single y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int32Double : IBinaryOperator<Int32, Double, Int32> { public void Operate(ref Int32 x, ref Double y, ref Int32 z) => z = (Int32)(x / y); }
        struct Op_Div_Int64Byte : IBinaryOperator<Int64, Byte, Int64> { public void Operate(ref Int64 x, ref Byte y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_Int64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public void Operate(ref Int64 x, ref UInt16 y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_Int64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public void Operate(ref Int64 x, ref UInt32 y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_Int64Int16 : IBinaryOperator<Int64, Int16, Int64> { public void Operate(ref Int64 x, ref Int16 y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_Int64Int32 : IBinaryOperator<Int64, Int32, Int64> { public void Operate(ref Int64 x, ref Int32 y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_Int64Int64 : IBinaryOperator<Int64, Int64, Int64> { public void Operate(ref Int64 x, ref Int64 y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_Int64Single : IBinaryOperator<Int64, Single, Int64> { public void Operate(ref Int64 x, ref Single y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_Int64Double : IBinaryOperator<Int64, Double, Int64> { public void Operate(ref Int64 x, ref Double y, ref Int64 z) => z = (Int64)(x / y); }
        struct Op_Div_SingleByte : IBinaryOperator<Single, Byte, Single> { public void Operate(ref Single x, ref Byte y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_SingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public void Operate(ref Single x, ref UInt16 y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_SingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public void Operate(ref Single x, ref UInt32 y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_SingleInt16 : IBinaryOperator<Single, Int16, Single> { public void Operate(ref Single x, ref Int16 y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_SingleInt32 : IBinaryOperator<Single, Int32, Single> { public void Operate(ref Single x, ref Int32 y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_SingleInt64 : IBinaryOperator<Single, Int64, Single> { public void Operate(ref Single x, ref Int64 y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_SingleSingle : IBinaryOperator<Single, Single, Single> { public void Operate(ref Single x, ref Single y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_SingleDouble : IBinaryOperator<Single, Double, Single> { public void Operate(ref Single x, ref Double y, ref Single z) => z = (Single)(x / y); }
        struct Op_Div_DoubleByte : IBinaryOperator<Double, Byte, Double> { public void Operate(ref Double x, ref Byte y, ref Double z) => z = (Double)(x / y); }
        struct Op_Div_DoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public void Operate(ref Double x, ref UInt16 y, ref Double z) => z = (Double)(x / y); }
        struct Op_Div_DoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public void Operate(ref Double x, ref UInt32 y, ref Double z) => z = (Double)(x / y); }
        struct Op_Div_DoubleInt16 : IBinaryOperator<Double, Int16, Double> { public void Operate(ref Double x, ref Int16 y, ref Double z) => z = (Double)(x / y); }
        struct Op_Div_DoubleInt32 : IBinaryOperator<Double, Int32, Double> { public void Operate(ref Double x, ref Int32 y, ref Double z) => z = (Double)(x / y); }
        struct Op_Div_DoubleInt64 : IBinaryOperator<Double, Int64, Double> { public void Operate(ref Double x, ref Int64 y, ref Double z) => z = (Double)(x / y); }
        struct Op_Div_DoubleSingle : IBinaryOperator<Double, Single, Double> { public void Operate(ref Double x, ref Single y, ref Double z) => z = (Double)(x / y); }
        struct Op_Div_DoubleDouble : IBinaryOperator<Double, Double, Double> { public void Operate(ref Double x, ref Double y, ref Double z) => z = (Double)(x / y); }

        
        struct Op_Add_UInt64UInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public void Operate(ref UInt64 x, ref UInt64 y, ref UInt64 z) => z = (x + y); }
        struct Op_Sub_UInt64UInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public void Operate(ref UInt64 x, ref UInt64 y, ref UInt64 z) => z = (x - y); }
        struct Op_Mul_UInt64UInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public void Operate(ref UInt64 x, ref UInt64 y, ref UInt64 z) => z = (x * y); }
        struct Op_Div_UInt64UInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public void Operate(ref UInt64 x, ref UInt64 y, ref UInt64 z) => z = (x / y); }

        
        struct Op_ShiftLeft_Byte : IBinaryOperator<Byte, int, Byte> { public void Operate(ref Byte x, ref int y, ref Byte z) => z = (Byte)(x << y); }
        struct Op_ShiftLeft_UInt16 : IBinaryOperator<UInt16, int, UInt16> { public void Operate(ref UInt16 x, ref int y, ref UInt16 z) => z = (UInt16)(x << y); }
        struct Op_ShiftLeft_UInt32 : IBinaryOperator<UInt32, int, UInt32> { public void Operate(ref UInt32 x, ref int y, ref UInt32 z) => z = (UInt32)(x << y); }
        struct Op_ShiftLeft_UInt64 : IBinaryOperator<UInt64, int, UInt64> { public void Operate(ref UInt64 x, ref int y, ref UInt64 z) => z = (UInt64)(x << y); }
        struct Op_ShiftLeft_Int16 : IBinaryOperator<Int16, int, Int16> { public void Operate(ref Int16 x, ref int y, ref Int16 z) => z = (Int16)(x << y); }
        struct Op_ShiftLeft_Int32 : IBinaryOperator<Int32, int, Int32> { public void Operate(ref Int32 x, ref int y, ref Int32 z) => z = (Int32)(x << y); }
        struct Op_ShiftLeft_Int64 : IBinaryOperator<Int64, int, Int64> { public void Operate(ref Int64 x, ref int y, ref Int64 z) => z = (Int64)(x << y); }
        struct Op_ShiftRight_Byte : IBinaryOperator<Byte, int, Byte> { public void Operate(ref Byte x, ref int y, ref Byte z) => z = (Byte)(x >> y); }
        struct Op_ShiftRight_UInt16 : IBinaryOperator<UInt16, int, UInt16> { public void Operate(ref UInt16 x, ref int y, ref UInt16 z) => z = (UInt16)(x >> y); }
        struct Op_ShiftRight_UInt32 : IBinaryOperator<UInt32, int, UInt32> { public void Operate(ref UInt32 x, ref int y, ref UInt32 z) => z = (UInt32)(x >> y); }
        struct Op_ShiftRight_UInt64 : IBinaryOperator<UInt64, int, UInt64> { public void Operate(ref UInt64 x, ref int y, ref UInt64 z) => z = (UInt64)(x >> y); }
        struct Op_ShiftRight_Int16 : IBinaryOperator<Int16, int, Int16> { public void Operate(ref Int16 x, ref int y, ref Int16 z) => z = (Int16)(x >> y); }
        struct Op_ShiftRight_Int32 : IBinaryOperator<Int32, int, Int32> { public void Operate(ref Int32 x, ref int y, ref Int32 z) => z = (Int32)(x >> y); }
        struct Op_ShiftRight_Int64 : IBinaryOperator<Int64, int, Int64> { public void Operate(ref Int64 x, ref int y, ref Int64 z) => z = (Int64)(x >> y); }



        
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(Op_Add_ByteByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_ByteByte));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteByte));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_ByteUInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteUInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_ByteUInt16));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteUInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteUInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteUInt16));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_ByteUInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteUInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_ByteUInt32));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteUInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteUInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteUInt32));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_ByteInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_ByteInt16));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteInt16));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_ByteInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_ByteInt32));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteInt32));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_ByteInt64));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteInt64));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_ByteInt64));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteInt64));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteInt64));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteInt64));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Single value) => src.Accumulate(src, value, default(Op_Add_ByteSingle));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteSingle));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_ByteSingle));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteSingle));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteSingle));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteSingle));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Double value) => src.Accumulate(src, value, default(Op_Add_ByteDouble));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_ByteDouble));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_ByteDouble));
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_ByteDouble));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_ByteDouble));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_ByteDouble));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, Byte value) => src.Accumulate(src, value, default(Op_Add_UInt16Byte));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16Byte));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_UInt16Byte));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16Byte));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16Byte));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16Byte));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_UInt16UInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16UInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_UInt16UInt16));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16UInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16UInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16UInt16));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_UInt16UInt32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16UInt32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_UInt16UInt32));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16UInt32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16UInt32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16UInt32));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_UInt16Int16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16Int16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_UInt16Int16));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16Int16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16Int16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16Int16));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_UInt16Int32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16Int32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_UInt16Int32));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16Int32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16Int32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16Int32));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_UInt16Int64));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16Int64));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_UInt16Int64));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16Int64));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16Int64));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16Int64));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, Single value) => src.Accumulate(src, value, default(Op_Add_UInt16Single));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16Single));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_UInt16Single));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16Single));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16Single));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16Single));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, Double value) => src.Accumulate(src, value, default(Op_Add_UInt16Double));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt16Double));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_UInt16Double));
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt16Double));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt16Double));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt16Double));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, Byte value) => src.Accumulate(src, value, default(Op_Add_UInt32Byte));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32Byte));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_UInt32Byte));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32Byte));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32Byte));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32Byte));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_UInt32UInt16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32UInt16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_UInt32UInt16));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32UInt16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32UInt16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32UInt16));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_UInt32UInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32UInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_UInt32UInt32));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32UInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32UInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32UInt32));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_UInt32Int16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32Int16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_UInt32Int16));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32Int16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32Int16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32Int16));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_UInt32Int32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32Int32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_UInt32Int32));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32Int32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32Int32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32Int32));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_UInt32Int64));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32Int64));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_UInt32Int64));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32Int64));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32Int64));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32Int64));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, Single value) => src.Accumulate(src, value, default(Op_Add_UInt32Single));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32Single));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_UInt32Single));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32Single));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32Single));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32Single));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, Double value) => src.Accumulate(src, value, default(Op_Add_UInt32Double));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_UInt32Double));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_UInt32Double));
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt32Double));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt32Double));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt32Double));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Byte value) => src.Accumulate(src, value, default(Op_Add_Int16Byte));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16Byte));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_Int16Byte));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16Byte));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16Byte));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16Byte));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_Int16UInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16UInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_Int16UInt16));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16UInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16UInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16UInt16));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_Int16UInt32));
        public static Pixel<Int16> Add(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16UInt32));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_Int16UInt32));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16UInt32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16UInt32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16UInt32));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_Int16Int16));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16Int16));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_Int16Int16));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16Int16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16Int16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16Int16));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_Int16Int32));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16Int32));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_Int16Int32));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16Int32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16Int32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16Int32));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_Int16Int64));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16Int64));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_Int16Int64));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16Int64));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16Int64));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16Int64));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Single value) => src.Accumulate(src, value, default(Op_Add_Int16Single));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16Single));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_Int16Single));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16Single));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16Single));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16Single));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Double value) => src.Accumulate(src, value, default(Op_Add_Int16Double));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int16Double));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_Int16Double));
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int16Double));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int16Double));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int16Double));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Byte value) => src.Accumulate(src, value, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_Int32Byte));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32Byte));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_Int32UInt16));
        public static Pixel<Int32> Add(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32UInt16));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_Int32UInt16));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32UInt16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32UInt16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32UInt16));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_Int32UInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32UInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_Int32UInt32));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32UInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32UInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32UInt32));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_Int32Int16));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32Int16));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_Int32Int16));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32Int16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32Int16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32Int16));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_Int32Int32));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32Int32));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_Int32Int32));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32Int32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32Int32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32Int32));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_Int32Int64));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32Int64));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_Int32Int64));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32Int64));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32Int64));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32Int64));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Single value) => src.Accumulate(src, value, default(Op_Add_Int32Single));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32Single));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_Int32Single));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32Single));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32Single));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32Single));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Double value) => src.Accumulate(src, value, default(Op_Add_Int32Double));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32Double));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_Int32Double));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32Double));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32Double));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32Double));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Byte value) => src.Accumulate(src, value, default(Op_Add_Int64Byte));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64Byte));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_Int64Byte));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64Byte));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64Byte));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64Byte));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_Int64UInt16));
        public static Pixel<Int64> Add(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64UInt16));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_Int64UInt16));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64UInt16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64UInt16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64UInt16));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_Int64UInt32));
        public static Pixel<Int64> Add(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64UInt32));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_Int64UInt32));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64UInt32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64UInt32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64UInt32));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_Int64Int16));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64Int16));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_Int64Int16));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64Int16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64Int16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64Int16));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_Int64Int32));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64Int32));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_Int64Int32));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64Int32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64Int32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64Int32));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_Int64Int64));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64Int64));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_Int64Int64));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64Int64));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64Int64));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64Int64));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Single value) => src.Accumulate(src, value, default(Op_Add_Int64Single));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64Single));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_Int64Single));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64Single));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64Single));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64Single));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Double value) => src.Accumulate(src, value, default(Op_Add_Int64Double));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int64Double));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_Int64Double));
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int64Double));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int64Double));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int64Double));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, Byte value) => src.Accumulate(src, value, default(Op_Add_SingleByte));
        public static Pixel<Single> Add(this Pixel<Single> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleByte));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_SingleByte));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleByte));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleByte));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleByte));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_SingleUInt16));
        public static Pixel<Single> Add(this Pixel<Single> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleUInt16));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_SingleUInt16));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleUInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleUInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleUInt16));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_SingleUInt32));
        public static Pixel<Single> Add(this Pixel<Single> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleUInt32));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_SingleUInt32));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleUInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleUInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleUInt32));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_SingleInt16));
        public static Pixel<Single> Add(this Pixel<Single> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleInt16));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_SingleInt16));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleInt16));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_SingleInt32));
        public static Pixel<Single> Add(this Pixel<Single> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleInt32));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_SingleInt32));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleInt32));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_SingleInt64));
        public static Pixel<Single> Add(this Pixel<Single> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleInt64));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_SingleInt64));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleInt64));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleInt64));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleInt64));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(Op_Add_SingleSingle));
        public static Pixel<Single> Add(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleSingle));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_SingleSingle));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleSingle));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleSingle));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleSingle));
        public static Pixel<Single> AddSelf(this Pixel<Single> src, Double value) => src.Accumulate(src, value, default(Op_Add_SingleDouble));
        public static Pixel<Single> Add(this Pixel<Single> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_SingleDouble));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_SingleDouble));
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_SingleDouble));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_SingleDouble));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_SingleDouble));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, Byte value) => src.Accumulate(src, value, default(Op_Add_DoubleByte));
        public static Pixel<Double> Add(this Pixel<Double> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleByte));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_DoubleByte));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleByte));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleByte));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleByte));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, UInt16 value) => src.Accumulate(src, value, default(Op_Add_DoubleUInt16));
        public static Pixel<Double> Add(this Pixel<Double> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleUInt16));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Add_DoubleUInt16));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleUInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleUInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleUInt16));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, UInt32 value) => src.Accumulate(src, value, default(Op_Add_DoubleUInt32));
        public static Pixel<Double> Add(this Pixel<Double> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleUInt32));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Add_DoubleUInt32));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleUInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleUInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleUInt32));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, Int16 value) => src.Accumulate(src, value, default(Op_Add_DoubleInt16));
        public static Pixel<Double> Add(this Pixel<Double> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleInt16));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Add_DoubleInt16));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleInt16));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, Int32 value) => src.Accumulate(src, value, default(Op_Add_DoubleInt32));
        public static Pixel<Double> Add(this Pixel<Double> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleInt32));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Add_DoubleInt32));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleInt32));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, Int64 value) => src.Accumulate(src, value, default(Op_Add_DoubleInt64));
        public static Pixel<Double> Add(this Pixel<Double> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleInt64));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Add_DoubleInt64));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleInt64));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleInt64));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleInt64));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, Single value) => src.Accumulate(src, value, default(Op_Add_DoubleSingle));
        public static Pixel<Double> Add(this Pixel<Double> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleSingle));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Single value) => src.Accumulate(dst, value, default(Op_Add_DoubleSingle));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleSingle));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleSingle));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleSingle));
        public static Pixel<Double> AddSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(Op_Add_DoubleDouble));
        public static Pixel<Double> Add(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Add_DoubleDouble));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(Op_Add_DoubleDouble));
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Add_DoubleDouble));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_DoubleDouble));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Add_DoubleDouble));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_ByteByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_ByteByte));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteByte));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_ByteUInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteUInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_ByteUInt16));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteUInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteUInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteUInt16));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_ByteUInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteUInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_ByteUInt32));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteUInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteUInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteUInt32));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_ByteInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_ByteInt16));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteInt16));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_ByteInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_ByteInt32));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteInt32));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_ByteInt64));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteInt64));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_ByteInt64));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteInt64));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteInt64));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteInt64));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Single value) => src.Accumulate(src, value, default(Op_Sub_ByteSingle));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteSingle));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_ByteSingle));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteSingle));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteSingle));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteSingle));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Double value) => src.Accumulate(src, value, default(Op_Sub_ByteDouble));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_ByteDouble));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_ByteDouble));
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_ByteDouble));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_ByteDouble));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_ByteDouble));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_UInt16Byte));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16Byte));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_UInt16Byte));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16Byte));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16Byte));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16Byte));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_UInt16UInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16UInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_UInt16UInt16));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16UInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16UInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16UInt16));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_UInt16UInt32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16UInt32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_UInt16UInt32));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16UInt32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16UInt32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16UInt32));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_UInt16Int16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16Int16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_UInt16Int16));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16Int16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16Int16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16Int16));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_UInt16Int32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16Int32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_UInt16Int32));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16Int32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16Int32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16Int32));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_UInt16Int64));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16Int64));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_UInt16Int64));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16Int64));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16Int64));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16Int64));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, Single value) => src.Accumulate(src, value, default(Op_Sub_UInt16Single));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16Single));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_UInt16Single));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16Single));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16Single));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16Single));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, Double value) => src.Accumulate(src, value, default(Op_Sub_UInt16Double));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt16Double));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_UInt16Double));
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt16Double));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt16Double));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt16Double));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_UInt32Byte));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32Byte));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_UInt32Byte));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32Byte));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32Byte));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32Byte));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_UInt32UInt16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32UInt16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_UInt32UInt16));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32UInt16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32UInt16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32UInt16));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_UInt32UInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32UInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_UInt32UInt32));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32UInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32UInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32UInt32));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_UInt32Int16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32Int16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_UInt32Int16));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32Int16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32Int16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32Int16));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_UInt32Int32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32Int32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_UInt32Int32));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32Int32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32Int32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32Int32));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_UInt32Int64));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32Int64));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_UInt32Int64));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32Int64));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32Int64));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32Int64));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, Single value) => src.Accumulate(src, value, default(Op_Sub_UInt32Single));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32Single));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_UInt32Single));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32Single));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32Single));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32Single));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, Double value) => src.Accumulate(src, value, default(Op_Sub_UInt32Double));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_UInt32Double));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_UInt32Double));
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt32Double));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt32Double));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt32Double));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_Int16Byte));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16Byte));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_Int16Byte));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16Byte));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16Byte));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16Byte));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_Int16UInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16UInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_Int16UInt16));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16UInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16UInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16UInt16));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_Int16UInt32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16UInt32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_Int16UInt32));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16UInt32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16UInt32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16UInt32));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_Int16Int16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16Int16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_Int16Int16));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16Int16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16Int16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16Int16));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_Int16Int32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16Int32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_Int16Int32));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16Int32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16Int32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16Int32));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_Int16Int64));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16Int64));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_Int16Int64));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16Int64));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16Int64));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16Int64));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Single value) => src.Accumulate(src, value, default(Op_Sub_Int16Single));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16Single));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_Int16Single));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16Single));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16Single));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16Single));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Double value) => src.Accumulate(src, value, default(Op_Sub_Int16Double));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int16Double));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_Int16Double));
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int16Double));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int16Double));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int16Double));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_Int32Byte));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32Byte));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_Int32Byte));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32Byte));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32Byte));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32Byte));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_Int32UInt16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32UInt16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_Int32UInt16));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32UInt16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32UInt16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32UInt16));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_Int32UInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32UInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_Int32UInt32));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32UInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32UInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32UInt32));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_Int32Int16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32Int16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_Int32Int16));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32Int16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32Int16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32Int16));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_Int32Int32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32Int32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_Int32Int32));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32Int32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32Int32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32Int32));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_Int32Int64));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32Int64));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_Int32Int64));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32Int64));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32Int64));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32Int64));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Single value) => src.Accumulate(src, value, default(Op_Sub_Int32Single));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32Single));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_Int32Single));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32Single));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32Single));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32Single));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Double value) => src.Accumulate(src, value, default(Op_Sub_Int32Double));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int32Double));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_Int32Double));
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int32Double));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int32Double));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int32Double));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_Int64Byte));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64Byte));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_Int64Byte));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64Byte));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64Byte));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64Byte));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_Int64UInt16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64UInt16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_Int64UInt16));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64UInt16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64UInt16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64UInt16));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_Int64UInt32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64UInt32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_Int64UInt32));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64UInt32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64UInt32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64UInt32));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_Int64Int16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64Int16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_Int64Int16));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64Int16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64Int16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64Int16));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_Int64Int32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64Int32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_Int64Int32));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64Int32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64Int32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64Int32));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_Int64Int64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64Int64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_Int64Int64));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64Int64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64Int64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64Int64));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Single value) => src.Accumulate(src, value, default(Op_Sub_Int64Single));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64Single));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_Int64Single));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64Single));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64Single));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64Single));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Double value) => src.Accumulate(src, value, default(Op_Sub_Int64Double));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_Int64Double));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_Int64Double));
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_Int64Double));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_Int64Double));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_Int64Double));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_SingleByte));
        public static Pixel<Single> Sub(this Pixel<Single> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleByte));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_SingleByte));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleByte));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleByte));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleByte));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_SingleUInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleUInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_SingleUInt16));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleUInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleUInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleUInt16));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_SingleUInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleUInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_SingleUInt32));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleUInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleUInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleUInt32));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_SingleInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_SingleInt16));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleInt16));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_SingleInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_SingleInt32));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleInt32));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_SingleInt64));
        public static Pixel<Single> Sub(this Pixel<Single> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleInt64));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_SingleInt64));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleInt64));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleInt64));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleInt64));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(Op_Sub_SingleSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_SingleSingle));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleSingle));
        public static Pixel<Single> SubSelf(this Pixel<Single> src, Double value) => src.Accumulate(src, value, default(Op_Sub_SingleDouble));
        public static Pixel<Single> Sub(this Pixel<Single> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_SingleDouble));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_SingleDouble));
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_SingleDouble));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_SingleDouble));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_SingleDouble));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, Byte value) => src.Accumulate(src, value, default(Op_Sub_DoubleByte));
        public static Pixel<Double> Sub(this Pixel<Double> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleByte));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Byte value) => src.Accumulate(dst, value, default(Op_Sub_DoubleByte));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleByte));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleByte));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleByte));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, UInt16 value) => src.Accumulate(src, value, default(Op_Sub_DoubleUInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleUInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Sub_DoubleUInt16));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleUInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleUInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleUInt16));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, UInt32 value) => src.Accumulate(src, value, default(Op_Sub_DoubleUInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleUInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Sub_DoubleUInt32));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleUInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleUInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleUInt32));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, Int16 value) => src.Accumulate(src, value, default(Op_Sub_DoubleInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Sub_DoubleInt16));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleInt16));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, Int32 value) => src.Accumulate(src, value, default(Op_Sub_DoubleInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Sub_DoubleInt32));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleInt32));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, Int64 value) => src.Accumulate(src, value, default(Op_Sub_DoubleInt64));
        public static Pixel<Double> Sub(this Pixel<Double> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleInt64));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Sub_DoubleInt64));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleInt64));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleInt64));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleInt64));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, Single value) => src.Accumulate(src, value, default(Op_Sub_DoubleSingle));
        public static Pixel<Double> Sub(this Pixel<Double> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleSingle));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Single value) => src.Accumulate(dst, value, default(Op_Sub_DoubleSingle));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleSingle));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleSingle));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleSingle));
        public static Pixel<Double> SubSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(Op_Sub_DoubleDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Sub_DoubleDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(Op_Sub_DoubleDouble));
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Sub_DoubleDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_DoubleDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Sub_DoubleDouble));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_ByteByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_ByteByte));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteByte));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_ByteUInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteUInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_ByteUInt16));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteUInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteUInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteUInt16));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_ByteUInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteUInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_ByteUInt32));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteUInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteUInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteUInt32));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_ByteInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_ByteInt16));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteInt16));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_ByteInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_ByteInt32));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteInt32));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_ByteInt64));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteInt64));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_ByteInt64));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteInt64));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteInt64));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteInt64));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Single value) => src.Accumulate(src, value, default(Op_Mul_ByteSingle));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteSingle));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_ByteSingle));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteSingle));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteSingle));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteSingle));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Double value) => src.Accumulate(src, value, default(Op_Mul_ByteDouble));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_ByteDouble));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_ByteDouble));
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_ByteDouble));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_ByteDouble));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_ByteDouble));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_UInt16Byte));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16Byte));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_UInt16Byte));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16Byte));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16Byte));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16Byte));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_UInt16UInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16UInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_UInt16UInt16));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16UInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16UInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16UInt16));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_UInt16UInt32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16UInt32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_UInt16UInt32));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16UInt32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16UInt32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16UInt32));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_UInt16Int16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16Int16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_UInt16Int16));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16Int16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16Int16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16Int16));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_UInt16Int32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16Int32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_UInt16Int32));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16Int32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16Int32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16Int32));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_UInt16Int64));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16Int64));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_UInt16Int64));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16Int64));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16Int64));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16Int64));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, Single value) => src.Accumulate(src, value, default(Op_Mul_UInt16Single));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16Single));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_UInt16Single));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16Single));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16Single));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16Single));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, Double value) => src.Accumulate(src, value, default(Op_Mul_UInt16Double));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt16Double));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_UInt16Double));
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt16Double));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt16Double));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt16Double));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_UInt32Byte));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32Byte));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_UInt32Byte));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32Byte));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32Byte));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32Byte));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_UInt32UInt16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32UInt16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_UInt32UInt16));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32UInt16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32UInt16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32UInt16));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_UInt32UInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32UInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_UInt32UInt32));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32UInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32UInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32UInt32));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_UInt32Int16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32Int16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_UInt32Int16));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32Int16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32Int16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32Int16));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_UInt32Int32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32Int32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_UInt32Int32));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32Int32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32Int32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32Int32));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_UInt32Int64));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32Int64));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_UInt32Int64));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32Int64));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32Int64));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32Int64));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, Single value) => src.Accumulate(src, value, default(Op_Mul_UInt32Single));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32Single));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_UInt32Single));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32Single));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32Single));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32Single));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, Double value) => src.Accumulate(src, value, default(Op_Mul_UInt32Double));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_UInt32Double));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_UInt32Double));
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt32Double));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt32Double));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt32Double));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_Int16Byte));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16Byte));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_Int16Byte));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16Byte));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16Byte));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16Byte));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_Int16UInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16UInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_Int16UInt16));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16UInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16UInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16UInt16));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_Int16UInt32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16UInt32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_Int16UInt32));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16UInt32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16UInt32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16UInt32));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_Int16Int16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16Int16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_Int16Int16));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16Int16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16Int16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16Int16));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_Int16Int32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16Int32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_Int16Int32));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16Int32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16Int32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16Int32));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_Int16Int64));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16Int64));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_Int16Int64));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16Int64));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16Int64));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16Int64));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Single value) => src.Accumulate(src, value, default(Op_Mul_Int16Single));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16Single));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_Int16Single));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16Single));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16Single));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16Single));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Double value) => src.Accumulate(src, value, default(Op_Mul_Int16Double));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int16Double));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_Int16Double));
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int16Double));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int16Double));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int16Double));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_Int32Byte));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32Byte));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_Int32Byte));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32Byte));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32Byte));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32Byte));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_Int32UInt16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32UInt16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_Int32UInt16));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32UInt16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32UInt16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32UInt16));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_Int32UInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32UInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_Int32UInt32));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32UInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32UInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32UInt32));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_Int32Int16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32Int16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_Int32Int16));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32Int16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32Int16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32Int16));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_Int32Int32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32Int32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_Int32Int32));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32Int32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32Int32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32Int32));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_Int32Int64));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32Int64));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_Int32Int64));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32Int64));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32Int64));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32Int64));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Single value) => src.Accumulate(src, value, default(Op_Mul_Int32Single));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32Single));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_Int32Single));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32Single));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32Single));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32Single));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Double value) => src.Accumulate(src, value, default(Op_Mul_Int32Double));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int32Double));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_Int32Double));
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int32Double));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int32Double));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int32Double));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_Int64Byte));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64Byte));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_Int64Byte));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64Byte));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64Byte));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64Byte));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_Int64UInt16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64UInt16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_Int64UInt16));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64UInt16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64UInt16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64UInt16));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_Int64UInt32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64UInt32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_Int64UInt32));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64UInt32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64UInt32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64UInt32));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_Int64Int16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64Int16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_Int64Int16));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64Int16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64Int16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64Int16));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_Int64Int32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64Int32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_Int64Int32));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64Int32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64Int32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64Int32));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_Int64Int64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64Int64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_Int64Int64));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64Int64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64Int64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64Int64));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Single value) => src.Accumulate(src, value, default(Op_Mul_Int64Single));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64Single));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_Int64Single));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64Single));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64Single));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64Single));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Double value) => src.Accumulate(src, value, default(Op_Mul_Int64Double));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_Int64Double));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_Int64Double));
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_Int64Double));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_Int64Double));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_Int64Double));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_SingleByte));
        public static Pixel<Single> Mul(this Pixel<Single> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleByte));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_SingleByte));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleByte));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleByte));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleByte));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_SingleUInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleUInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_SingleUInt16));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleUInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleUInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleUInt16));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_SingleUInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleUInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_SingleUInt32));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleUInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleUInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleUInt32));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_SingleInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_SingleInt16));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleInt16));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_SingleInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_SingleInt32));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleInt32));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_SingleInt64));
        public static Pixel<Single> Mul(this Pixel<Single> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleInt64));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_SingleInt64));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleInt64));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleInt64));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleInt64));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(Op_Mul_SingleSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_SingleSingle));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleSingle));
        public static Pixel<Single> MulSelf(this Pixel<Single> src, Double value) => src.Accumulate(src, value, default(Op_Mul_SingleDouble));
        public static Pixel<Single> Mul(this Pixel<Single> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_SingleDouble));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_SingleDouble));
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_SingleDouble));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_SingleDouble));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_SingleDouble));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, Byte value) => src.Accumulate(src, value, default(Op_Mul_DoubleByte));
        public static Pixel<Double> Mul(this Pixel<Double> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleByte));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Byte value) => src.Accumulate(dst, value, default(Op_Mul_DoubleByte));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleByte));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleByte));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleByte));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, UInt16 value) => src.Accumulate(src, value, default(Op_Mul_DoubleUInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleUInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Mul_DoubleUInt16));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleUInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleUInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleUInt16));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, UInt32 value) => src.Accumulate(src, value, default(Op_Mul_DoubleUInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleUInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Mul_DoubleUInt32));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleUInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleUInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleUInt32));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, Int16 value) => src.Accumulate(src, value, default(Op_Mul_DoubleInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Mul_DoubleInt16));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleInt16));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, Int32 value) => src.Accumulate(src, value, default(Op_Mul_DoubleInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Mul_DoubleInt32));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleInt32));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, Int64 value) => src.Accumulate(src, value, default(Op_Mul_DoubleInt64));
        public static Pixel<Double> Mul(this Pixel<Double> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleInt64));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Mul_DoubleInt64));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleInt64));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleInt64));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleInt64));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, Single value) => src.Accumulate(src, value, default(Op_Mul_DoubleSingle));
        public static Pixel<Double> Mul(this Pixel<Double> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleSingle));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Single value) => src.Accumulate(dst, value, default(Op_Mul_DoubleSingle));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleSingle));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleSingle));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleSingle));
        public static Pixel<Double> MulSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(Op_Mul_DoubleDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Mul_DoubleDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(Op_Mul_DoubleDouble));
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Mul_DoubleDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_DoubleDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Mul_DoubleDouble));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(Op_Div_ByteByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_ByteByte));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteByte));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_ByteUInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteUInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_ByteUInt16));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteUInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteUInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteUInt16));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_ByteUInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteUInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_ByteUInt32));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteUInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteUInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteUInt32));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_ByteInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_ByteInt16));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteInt16));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_ByteInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_ByteInt32));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteInt32));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_ByteInt64));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteInt64));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_ByteInt64));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteInt64));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteInt64));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteInt64));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Single value) => src.Accumulate(src, value, default(Op_Div_ByteSingle));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteSingle));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_ByteSingle));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteSingle));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteSingle));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteSingle));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Double value) => src.Accumulate(src, value, default(Op_Div_ByteDouble));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_ByteDouble));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_ByteDouble));
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_ByteDouble));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_ByteDouble));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_ByteDouble));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, Byte value) => src.Accumulate(src, value, default(Op_Div_UInt16Byte));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16Byte));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_UInt16Byte));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16Byte));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16Byte));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16Byte));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_UInt16UInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16UInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_UInt16UInt16));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16UInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16UInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16UInt16));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_UInt16UInt32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16UInt32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_UInt16UInt32));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16UInt32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16UInt32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16UInt32));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_UInt16Int16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16Int16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_UInt16Int16));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16Int16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16Int16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16Int16));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_UInt16Int32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16Int32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_UInt16Int32));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16Int32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16Int32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16Int32));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_UInt16Int64));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16Int64));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_UInt16Int64));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16Int64));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16Int64));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16Int64));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, Single value) => src.Accumulate(src, value, default(Op_Div_UInt16Single));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16Single));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_UInt16Single));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16Single));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16Single));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16Single));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, Double value) => src.Accumulate(src, value, default(Op_Div_UInt16Double));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt16Double));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_UInt16Double));
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt16Double));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt16Double));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt16Double));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, Byte value) => src.Accumulate(src, value, default(Op_Div_UInt32Byte));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32Byte));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_UInt32Byte));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32Byte));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32Byte));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32Byte));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_UInt32UInt16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32UInt16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_UInt32UInt16));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32UInt16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32UInt16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32UInt16));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_UInt32UInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32UInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_UInt32UInt32));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32UInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32UInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32UInt32));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_UInt32Int16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32Int16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_UInt32Int16));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32Int16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32Int16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32Int16));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_UInt32Int32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32Int32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_UInt32Int32));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32Int32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32Int32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32Int32));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_UInt32Int64));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32Int64));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_UInt32Int64));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32Int64));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32Int64));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32Int64));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, Single value) => src.Accumulate(src, value, default(Op_Div_UInt32Single));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32Single));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_UInt32Single));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32Single));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32Single));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32Single));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, Double value) => src.Accumulate(src, value, default(Op_Div_UInt32Double));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_UInt32Double));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_UInt32Double));
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt32Double));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt32Double));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt32Double));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Byte value) => src.Accumulate(src, value, default(Op_Div_Int16Byte));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16Byte));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_Int16Byte));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16Byte));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16Byte));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16Byte));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_Int16UInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16UInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_Int16UInt16));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16UInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16UInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16UInt16));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_Int16UInt32));
        public static Pixel<Int16> Div(this Pixel<Int16> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16UInt32));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_Int16UInt32));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16UInt32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16UInt32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16UInt32));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_Int16Int16));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16Int16));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_Int16Int16));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16Int16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16Int16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16Int16));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_Int16Int32));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16Int32));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_Int16Int32));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16Int32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16Int32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16Int32));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_Int16Int64));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16Int64));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_Int16Int64));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16Int64));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16Int64));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16Int64));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Single value) => src.Accumulate(src, value, default(Op_Div_Int16Single));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16Single));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_Int16Single));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16Single));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16Single));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16Single));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Double value) => src.Accumulate(src, value, default(Op_Div_Int16Double));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int16Double));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_Int16Double));
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int16Double));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int16Double));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int16Double));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Byte value) => src.Accumulate(src, value, default(Op_Div_Int32Byte));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32Byte));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_Int32Byte));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32Byte));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32Byte));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32Byte));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_Int32UInt16));
        public static Pixel<Int32> Div(this Pixel<Int32> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32UInt16));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_Int32UInt16));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32UInt16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32UInt16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32UInt16));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_Int32UInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32UInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_Int32UInt32));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32UInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32UInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32UInt32));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_Int32Int16));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32Int16));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_Int32Int16));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32Int16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32Int16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32Int16));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_Int32Int32));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32Int32));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_Int32Int32));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32Int32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32Int32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32Int32));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_Int32Int64));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32Int64));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_Int32Int64));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32Int64));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32Int64));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32Int64));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Single value) => src.Accumulate(src, value, default(Op_Div_Int32Single));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32Single));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_Int32Single));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32Single));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32Single));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32Single));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Double value) => src.Accumulate(src, value, default(Op_Div_Int32Double));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int32Double));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_Int32Double));
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int32Double));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int32Double));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int32Double));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Byte value) => src.Accumulate(src, value, default(Op_Div_Int64Byte));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64Byte));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_Int64Byte));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64Byte));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64Byte));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64Byte));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_Int64UInt16));
        public static Pixel<Int64> Div(this Pixel<Int64> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64UInt16));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_Int64UInt16));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64UInt16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64UInt16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64UInt16));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_Int64UInt32));
        public static Pixel<Int64> Div(this Pixel<Int64> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64UInt32));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_Int64UInt32));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64UInt32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64UInt32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64UInt32));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_Int64Int16));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64Int16));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_Int64Int16));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64Int16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64Int16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64Int16));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_Int64Int32));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64Int32));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_Int64Int32));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64Int32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64Int32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64Int32));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_Int64Int64));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64Int64));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_Int64Int64));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64Int64));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64Int64));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64Int64));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Single value) => src.Accumulate(src, value, default(Op_Div_Int64Single));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64Single));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_Int64Single));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64Single));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64Single));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64Single));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Double value) => src.Accumulate(src, value, default(Op_Div_Int64Double));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_Int64Double));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_Int64Double));
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_Int64Double));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_Int64Double));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_Int64Double));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, Byte value) => src.Accumulate(src, value, default(Op_Div_SingleByte));
        public static Pixel<Single> Div(this Pixel<Single> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleByte));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_SingleByte));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleByte));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleByte));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleByte));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_SingleUInt16));
        public static Pixel<Single> Div(this Pixel<Single> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleUInt16));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_SingleUInt16));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleUInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleUInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleUInt16));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_SingleUInt32));
        public static Pixel<Single> Div(this Pixel<Single> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleUInt32));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_SingleUInt32));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleUInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleUInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleUInt32));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_SingleInt16));
        public static Pixel<Single> Div(this Pixel<Single> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleInt16));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_SingleInt16));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleInt16));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_SingleInt32));
        public static Pixel<Single> Div(this Pixel<Single> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleInt32));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_SingleInt32));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleInt32));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_SingleInt64));
        public static Pixel<Single> Div(this Pixel<Single> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleInt64));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_SingleInt64));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleInt64));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleInt64));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleInt64));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(Op_Div_SingleSingle));
        public static Pixel<Single> Div(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleSingle));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_SingleSingle));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleSingle));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleSingle));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleSingle));
        public static Pixel<Single> DivSelf(this Pixel<Single> src, Double value) => src.Accumulate(src, value, default(Op_Div_SingleDouble));
        public static Pixel<Single> Div(this Pixel<Single> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_SingleDouble));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_SingleDouble));
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_SingleDouble));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_SingleDouble));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_SingleDouble));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, Byte value) => src.Accumulate(src, value, default(Op_Div_DoubleByte));
        public static Pixel<Double> Div(this Pixel<Double> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleByte));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Byte value) => src.Accumulate(dst, value, default(Op_Div_DoubleByte));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleByte));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleByte));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleByte));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, UInt16 value) => src.Accumulate(src, value, default(Op_Div_DoubleUInt16));
        public static Pixel<Double> Div(this Pixel<Double> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleUInt16));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, UInt16 value) => src.Accumulate(dst, value, default(Op_Div_DoubleUInt16));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleUInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleUInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleUInt16));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, UInt32 value) => src.Accumulate(src, value, default(Op_Div_DoubleUInt32));
        public static Pixel<Double> Div(this Pixel<Double> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleUInt32));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, UInt32 value) => src.Accumulate(dst, value, default(Op_Div_DoubleUInt32));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleUInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleUInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleUInt32));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, Int16 value) => src.Accumulate(src, value, default(Op_Div_DoubleInt16));
        public static Pixel<Double> Div(this Pixel<Double> src, Int16 value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleInt16));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Int16 value) => src.Accumulate(dst, value, default(Op_Div_DoubleInt16));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleInt16));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, Int32 value) => src.Accumulate(src, value, default(Op_Div_DoubleInt32));
        public static Pixel<Double> Div(this Pixel<Double> src, Int32 value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleInt32));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Int32 value) => src.Accumulate(dst, value, default(Op_Div_DoubleInt32));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleInt32));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, Int64 value) => src.Accumulate(src, value, default(Op_Div_DoubleInt64));
        public static Pixel<Double> Div(this Pixel<Double> src, Int64 value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleInt64));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Int64 value) => src.Accumulate(dst, value, default(Op_Div_DoubleInt64));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleInt64));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleInt64));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleInt64));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, Single value) => src.Accumulate(src, value, default(Op_Div_DoubleSingle));
        public static Pixel<Double> Div(this Pixel<Double> src, Single value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleSingle));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Single value) => src.Accumulate(dst, value, default(Op_Div_DoubleSingle));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleSingle));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleSingle));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleSingle));
        public static Pixel<Double> DivSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(Op_Div_DoubleDouble));
        public static Pixel<Double> Div(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(Op_Div_DoubleDouble));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(Op_Div_DoubleDouble));
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(Op_Div_DoubleDouble));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_DoubleDouble));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(Op_Div_DoubleDouble));

        
        public static Pixel<UInt64> AddSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt64UInt64));
        public static Pixel<UInt64> Add(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt64UInt64));
        public static Pixel<UInt64> Add(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt64UInt64));
        public static Pixel<UInt64> SubSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1, src2, default(Op_Sub_UInt64UInt64));
        public static Pixel<UInt64> Sub(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Sub_UInt64UInt64));
        public static Pixel<UInt64> Sub(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2) => src1.Accumulate(dst, src2, default(Op_Sub_UInt64UInt64));
        public static Pixel<UInt64> MulSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1, src2, default(Op_Mul_UInt64UInt64));
        public static Pixel<UInt64> Mul(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Mul_UInt64UInt64));
        public static Pixel<UInt64> Mul(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2) => src1.Accumulate(dst, src2, default(Op_Mul_UInt64UInt64));
        public static Pixel<UInt64> DivSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1, src2, default(Op_Div_UInt64UInt64));
        public static Pixel<UInt64> Div(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Div_UInt64UInt64));
        public static Pixel<UInt64> Div(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2) => src1.Accumulate(dst, src2, default(Op_Div_UInt64UInt64));

        
        public static Pixel<Byte> ShiftLeftSelf(this Pixel<Byte> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_Byte));
        public static Pixel<Byte> ShiftLeft(this Pixel<Byte> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_Byte));
        public static Pixel<Byte> ShiftLeft(this Pixel<Byte> src, Pixel<Byte> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_Byte));
        public static Pixel<UInt16> ShiftLeftSelf(this Pixel<UInt16> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_UInt16));
        public static Pixel<UInt16> ShiftLeft(this Pixel<UInt16> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_UInt16));
        public static Pixel<UInt16> ShiftLeft(this Pixel<UInt16> src, Pixel<UInt16> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_UInt16));
        public static Pixel<UInt32> ShiftLeftSelf(this Pixel<UInt32> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_UInt32));
        public static Pixel<UInt32> ShiftLeft(this Pixel<UInt32> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_UInt32));
        public static Pixel<UInt32> ShiftLeft(this Pixel<UInt32> src, Pixel<UInt32> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_UInt32));
        public static Pixel<UInt64> ShiftLeftSelf(this Pixel<UInt64> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_UInt64));
        public static Pixel<UInt64> ShiftLeft(this Pixel<UInt64> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_UInt64));
        public static Pixel<UInt64> ShiftLeft(this Pixel<UInt64> src, Pixel<UInt64> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_UInt64));
        public static Pixel<Int16> ShiftLeftSelf(this Pixel<Int16> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_Int16));
        public static Pixel<Int16> ShiftLeft(this Pixel<Int16> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_Int16));
        public static Pixel<Int16> ShiftLeft(this Pixel<Int16> src, Pixel<Int16> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_Int16));
        public static Pixel<Int32> ShiftLeftSelf(this Pixel<Int32> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_Int32));
        public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_Int32));
        public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, Pixel<Int32> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_Int32));
        public static Pixel<Int64> ShiftLeftSelf(this Pixel<Int64> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_Int64));
        public static Pixel<Int64> ShiftLeft(this Pixel<Int64> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_Int64));
        public static Pixel<Int64> ShiftLeft(this Pixel<Int64> src, Pixel<Int64> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_Int64));
        public static Pixel<Byte> ShiftRightSelf(this Pixel<Byte> src, int value) => src.Accumulate(src, value, default(Op_ShiftRight_Byte));
        public static Pixel<Byte> ShiftRight(this Pixel<Byte> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftRight_Byte));
        public static Pixel<Byte> ShiftRight(this Pixel<Byte> src, Pixel<Byte> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftRight_Byte));
        public static Pixel<UInt16> ShiftRightSelf(this Pixel<UInt16> src, int value) => src.Accumulate(src, value, default(Op_ShiftRight_UInt16));
        public static Pixel<UInt16> ShiftRight(this Pixel<UInt16> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftRight_UInt16));
        public static Pixel<UInt16> ShiftRight(this Pixel<UInt16> src, Pixel<UInt16> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftRight_UInt16));
        public static Pixel<UInt32> ShiftRightSelf(this Pixel<UInt32> src, int value) => src.Accumulate(src, value, default(Op_ShiftRight_UInt32));
        public static Pixel<UInt32> ShiftRight(this Pixel<UInt32> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftRight_UInt32));
        public static Pixel<UInt32> ShiftRight(this Pixel<UInt32> src, Pixel<UInt32> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftRight_UInt32));
        public static Pixel<UInt64> ShiftRightSelf(this Pixel<UInt64> src, int value) => src.Accumulate(src, value, default(Op_ShiftRight_UInt64));
        public static Pixel<UInt64> ShiftRight(this Pixel<UInt64> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftRight_UInt64));
        public static Pixel<UInt64> ShiftRight(this Pixel<UInt64> src, Pixel<UInt64> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftRight_UInt64));
        public static Pixel<Int16> ShiftRightSelf(this Pixel<Int16> src, int value) => src.Accumulate(src, value, default(Op_ShiftRight_Int16));
        public static Pixel<Int16> ShiftRight(this Pixel<Int16> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftRight_Int16));
        public static Pixel<Int16> ShiftRight(this Pixel<Int16> src, Pixel<Int16> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftRight_Int16));
        public static Pixel<Int32> ShiftRightSelf(this Pixel<Int32> src, int value) => src.Accumulate(src, value, default(Op_ShiftRight_Int32));
        public static Pixel<Int32> ShiftRight(this Pixel<Int32> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftRight_Int32));
        public static Pixel<Int32> ShiftRight(this Pixel<Int32> src, Pixel<Int32> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftRight_Int32));
        public static Pixel<Int64> ShiftRightSelf(this Pixel<Int64> src, int value) => src.Accumulate(src, value, default(Op_ShiftRight_Int64));
        public static Pixel<Int64> ShiftRight(this Pixel<Int64> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftRight_Int64));
        public static Pixel<Int64> ShiftRight(this Pixel<Int64> src, Pixel<Int64> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftRight_Int64));

        #endregion

        //test

        public static Pixel<Single> Add_(this Pixel<Single> src, Pixel<Single> dst, Single value)
        {
            src.Accumulate_(dst, value, default(_Op_Add_SingleSingle));
            return dst;
        }
        struct _Op_Add_SingleSingle : IBinaryOperator_<Single[], Single, Pixel<Single>> { public void Operate(int i, ref Single[] x, ref Single y, ref Pixel<Single> z) => z[i] = (x[i] + y); }/*}T4*/


        //Statistical
        #region Statistical

        
        //      public static double Average(this Pixel<Byte> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<Byte> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<Byte> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<Byte> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<Byte> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<UInt16> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<UInt16> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<UInt16> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<UInt16> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<UInt16> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<UInt32> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<UInt32> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<UInt32> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<UInt32> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<UInt32> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<UInt64> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<UInt64> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<UInt64> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<UInt64> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<UInt64> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<Int16> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<Int16> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<Int16> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<Int16> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<Int16> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<Int32> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<Int32> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<Int32> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<Int32> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<Int32> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<Int64> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<Int64> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<Int64> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<Int64> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<Int64> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<Single> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<Single> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<Single> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<Single> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<Single> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        
        //      public static double Average(this Pixel<Double> src, string color)
        //      {
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += src[i];
        //          }
        //          return dst / src.GetCount(color);
        //      }
        //public static double Deviation(this Pixel<Double> src, string color, double? average = null)
        //      {
        //          var ave = average ?? Average(src, color);
        //          double dst = 0;
        //          foreach (var i in src.GetIndex(color))
        //          {
        //              dst += System.Math.Pow(src[i] - ave, 2);
        //          }
        //          return System.Math.Sqrt(dst / src.GetCount(color));
        //      }

        //public static (double Average, double Deviation) Signal(this Pixel<Double> src, string color)
        //{
        //          double ave = Average(src, color);
        //          double dev = Deviation(src, color, ave);

        //          return (ave, dev);
        //      }

        //public static double[] AverageH(this Pixel<Double> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var y in src.GetIndexY(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var x in src.GetIndexX(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        //      public static double[] AverageV(this Pixel<Double> src, string color)
        //      {
        //          List<double> dst = new List<double>();

        //          foreach (var x in src.GetIndexX(color))
        //          {
        //              int c = 0;
        //              double hoge = 0;
        //              foreach (var y in src.GetIndexY(color))
        //              {
        //                  hoge += src[x + y];
        //                  c++;
        //              }
        //              hoge /= c;
        //              dst.Add(hoge);
        //          }

        //          return dst.ToArray();
        //      }
        

        
        public static double Average2(this Pixel<Byte> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_Byte));
            return dst / src.Size;
        }
        private struct Op_Average_Byte : IBinaryOperator<Byte, double> { public void Operate(ref Byte x, ref double y) => y += x; }
        public static double Average2(this Pixel<UInt16> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_UInt16));
            return dst / src.Size;
        }
        private struct Op_Average_UInt16 : IBinaryOperator<UInt16, double> { public void Operate(ref UInt16 x, ref double y) => y += x; }
        public static double Average2(this Pixel<UInt32> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_UInt32));
            return dst / src.Size;
        }
        private struct Op_Average_UInt32 : IBinaryOperator<UInt32, double> { public void Operate(ref UInt32 x, ref double y) => y += x; }
        public static double Average2(this Pixel<UInt64> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_UInt64));
            return dst / src.Size;
        }
        private struct Op_Average_UInt64 : IBinaryOperator<UInt64, double> { public void Operate(ref UInt64 x, ref double y) => y += x; }
        public static double Average2(this Pixel<Int16> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_Int16));
            return dst / src.Size;
        }
        private struct Op_Average_Int16 : IBinaryOperator<Int16, double> { public void Operate(ref Int16 x, ref double y) => y += x; }
        public static double Average2(this Pixel<Int32> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_Int32));
            return dst / src.Size;
        }
        private struct Op_Average_Int32 : IBinaryOperator<Int32, double> { public void Operate(ref Int32 x, ref double y) => y += x; }
        public static double Average2(this Pixel<Int64> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_Int64));
            return dst / src.Size;
        }
        private struct Op_Average_Int64 : IBinaryOperator<Int64, double> { public void Operate(ref Int64 x, ref double y) => y += x; }
        public static double Average2(this Pixel<Single> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_Single));
            return dst / src.Size;
        }
        private struct Op_Average_Single : IBinaryOperator<Single, double> { public void Operate(ref Single x, ref double y) => y += x; }
        public static double Average2(this Pixel<Double> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_Double));
            return dst / src.Size;
        }
        private struct Op_Average_Double : IBinaryOperator<Double, double> { public void Operate(ref Double x, ref double y) => y += x; }

        //こっちの方が早い（あたりまえ

        #endregion


        //累積度数
        public static Dictionary<double,int> CumulativeFrequency<T>(this Pixel<T> src, double[] thr) where T : struct, IComparable
        {
            var dst = new Dictionary<double, int>();

            foreach (var i in thr) dst.Add(i, 0);

            foreach (var i in src.GetIndex())
            {
                double buf = (dynamic)src[i];
                foreach (var n in thr)
                {
                    if (buf> n) dst[i]++;
                    else break;
                }
            }
            return dst;
        }

        //カウント
        public static int Count<T>(this Pixel<T> src, Func<T, bool> func) where T : struct, IComparable
        {
            int count = 0;
            foreach (var i in src.GetIndex())
                if (func(src[i])) count++;
            return count;
        }
        public static Dictionary<int, T> CountDic<T>(this Pixel<T> src, Func<T, bool> func) where T : struct, IComparable
        {
            Dictionary<int, T> dst = new Dictionary<int, T>();
            foreach (var i in src.GetIndex())
                if (func(src[i])) dst.Add(i, src[i]);
            return dst;
        }

        public static int Count<T>(this (Pixel<T> src1, Pixel<T> src2) src, Func<T, T, bool> func) where T : struct, IComparable
        {
            int count = 0;
            foreach (var i in src.src1.GetIndex())
                if (func(src.src1[i], src.src2[i])) count++;
            return count;
        }
        public static List<int> CountDic<T>(this (Pixel<T> src1, Pixel<T> src2) src, Func<T, T, bool> func) where T : struct, IComparable
        {
            List<int> dst = new List<int>();
            foreach (var i in src.src1.GetIndex())
                if (func(src.src1[i], src.src2[i])) dst.Add(i);
            return dst;
        }


        //4近傍ラベリング
        public static Pixel<int> Labeling(this Pixel<bool> src)
        {
            src = src["Full"];
            int w = src.Width;
            int h = src.Height;
            var label = src.Clone<int>();
            //int[] label = new int[w*h];

            int count = 1;

            //一画素目
            if (src[0]) label[0] = count++;

            //一行目
            for (int x = 1; x < w; x++)
                if (src[x + 0 * w])
                {
                    var left = label[x - 1 + 0 * w];
                    label[x + 0 * w] = left > 0 ? left : count++;
                }

            //二行目以降
            for (int y = 1; y < h; y++)
            {
                if (src[0 + y * w])
                {
                    var top = label[0 + (y - 1) * w];
                    label[0 + y * w] = top > 0 ? top : count++;
                }
                for (int x = 1; x < w; x++)
                    if (src[x + y * w])
                    {
                        var top = label[x + (y - 1) * w];
                        var left = label[x - 1 + y * w];

                        label[x + y * w] = (left + top) > 0 ? 
                            (left > top ? top : left) : count++;
                    }
            }


            //連結ができてない
            //キャストの動きおかしくない？
            return label;

        }


    }

    //ラインプロファイルの計算
    public static class LineMath
    {
        public static (double average, double deviation, double Max, double Min, double ShaMax, double ShaMin) LineStatus(this double[] src, int boxsize = 5)
        {
            double max = double.MinValue;
            double min = double.MaxValue;

            double shamax = double.MinValue;
            double shamin = double.MaxValue;

            double ave = 0;
            double dev = 0;

            //移動平均
            for (int i = 0; i < src.Length - boxsize; i++)
            {
                ref double hoge = ref src[i];

                ave += hoge;

                if (max < hoge) max = hoge;
                if (min > hoge) min = hoge;

                double sha = 0;
                for (int n = 0; n < boxsize; n++)
                {
                    sha += src[i+n];
                }
                sha /= boxsize;

                if (shamax < sha) shamax = sha;
                if (shamin > sha) shamin = sha;
            }
            for (int i = src.Length - boxsize; i < src.Length; i++)
            {
                ref double hoge = ref src[i];

                ave += hoge;

                if (max < hoge) max = hoge;
                if (min > hoge) min = hoge;
            }

            ave /= src.Length;
            
            //偏差
            foreach(var i in src)
            {
                dev += System.Math.Pow(i - ave, 2);
            }
            dev = System.Math.Sqrt(dev / (src.Length - 1));



            return (ave, dev, max, min, shamax, shamin);
        }

    }

}

