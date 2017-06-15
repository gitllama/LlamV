using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixels.Math
{
    public static partial class PixelMath
    {
        //メソッドチェーンでfunc += hogeで並べるようにする？

        #region Cast

        public static Pixel<TResult> ToPixel<T1, TResult>(this Pixel<T1> src)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
        {
            var dst = src.Clone<TResult>();

            //if (typeof(T) == typeof(bool)) return (dynamic)Binarization((dynamic)src, null, "M", null);

            if(false) throw new Exception();
            
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<Byte>, default(OpCastBooleanByte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<Byte>, default(OpCastByteByte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<Byte>, default(OpCastUInt16Byte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<Byte>, default(OpCastUInt32Byte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<Byte>, default(OpCastUInt64Byte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<Byte>, default(OpCastInt16Byte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<Byte>, default(OpCastInt32Byte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<Byte>, default(OpCastInt64Byte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<Byte>, default(OpCastSingleByte));
                return dst;
            }
            else if (typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<Byte>, default(OpCastDoubleByte));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<UInt16>, default(OpCastBooleanUInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<UInt16>, default(OpCastByteUInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<UInt16>, default(OpCastUInt16UInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<UInt16>, default(OpCastUInt32UInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<UInt16>, default(OpCastUInt64UInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<UInt16>, default(OpCastInt16UInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<UInt16>, default(OpCastInt32UInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<UInt16>, default(OpCastInt64UInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<UInt16>, default(OpCastSingleUInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt16) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<UInt16>, default(OpCastDoubleUInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<UInt32>, default(OpCastBooleanUInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<UInt32>, default(OpCastByteUInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<UInt32>, default(OpCastUInt16UInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<UInt32>, default(OpCastUInt32UInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<UInt32>, default(OpCastUInt64UInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<UInt32>, default(OpCastInt16UInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<UInt32>, default(OpCastInt32UInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<UInt32>, default(OpCastInt64UInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<UInt32>, default(OpCastSingleUInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt32) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<UInt32>, default(OpCastDoubleUInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<UInt64>, default(OpCastBooleanUInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<UInt64>, default(OpCastByteUInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<UInt64>, default(OpCastUInt16UInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<UInt64>, default(OpCastUInt32UInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<UInt64>, default(OpCastUInt64UInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<UInt64>, default(OpCastInt16UInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<UInt64>, default(OpCastInt32UInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<UInt64>, default(OpCastInt64UInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<UInt64>, default(OpCastSingleUInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(UInt64) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<UInt64>, default(OpCastDoubleUInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<Int16>, default(OpCastBooleanInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<Int16>, default(OpCastByteInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<Int16>, default(OpCastUInt16Int16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<Int16>, default(OpCastUInt32Int16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<Int16>, default(OpCastUInt64Int16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<Int16>, default(OpCastInt16Int16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<Int16>, default(OpCastInt32Int16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<Int16>, default(OpCastInt64Int16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<Int16>, default(OpCastSingleInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int16) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<Int16>, default(OpCastDoubleInt16));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<Int32>, default(OpCastBooleanInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<Int32>, default(OpCastByteInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<Int32>, default(OpCastUInt16Int32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<Int32>, default(OpCastUInt32Int32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<Int32>, default(OpCastUInt64Int32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<Int32>, default(OpCastInt16Int32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<Int32>, default(OpCastInt32Int32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<Int32>, default(OpCastInt64Int32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<Int32>, default(OpCastSingleInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int32) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<Int32>, default(OpCastDoubleInt32));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<Int64>, default(OpCastBooleanInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<Int64>, default(OpCastByteInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<Int64>, default(OpCastUInt16Int64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<Int64>, default(OpCastUInt32Int64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<Int64>, default(OpCastUInt64Int64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<Int64>, default(OpCastInt16Int64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<Int64>, default(OpCastInt32Int64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<Int64>, default(OpCastInt64Int64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<Int64>, default(OpCastSingleInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Int64) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<Int64>, default(OpCastDoubleInt64));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<Single>, default(OpCastBooleanSingle));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<Single>, default(OpCastByteSingle));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<Single>, default(OpCastUInt16Single));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<Single>, default(OpCastUInt32Single));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<Single>, default(OpCastUInt64Single));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<Single>, default(OpCastInt16Single));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<Single>, default(OpCastInt32Single));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<Single>, default(OpCastInt64Single));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<Single>, default(OpCastSingleSingle));
                return dst;
            }
            else if (typeof(TResult) == typeof(Single) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<Single>, default(OpCastDoubleSingle));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Boolean))
            {
                (src as Pixel<Boolean>).Accumulate(dst as Pixel<Double>, default(OpCastBooleanDouble));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Byte))
            {
                (src as Pixel<Byte>).Accumulate(dst as Pixel<Double>, default(OpCastByteDouble));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(UInt16))
            {
                (src as Pixel<UInt16>).Accumulate(dst as Pixel<Double>, default(OpCastUInt16Double));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(UInt32))
            {
                (src as Pixel<UInt32>).Accumulate(dst as Pixel<Double>, default(OpCastUInt32Double));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(UInt64))
            {
                (src as Pixel<UInt64>).Accumulate(dst as Pixel<Double>, default(OpCastUInt64Double));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Int16))
            {
                (src as Pixel<Int16>).Accumulate(dst as Pixel<Double>, default(OpCastInt16Double));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Int32))
            {
                (src as Pixel<Int32>).Accumulate(dst as Pixel<Double>, default(OpCastInt32Double));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Int64))
            {
                (src as Pixel<Int64>).Accumulate(dst as Pixel<Double>, default(OpCastInt64Double));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Single))
            {
                (src as Pixel<Single>).Accumulate(dst as Pixel<Double>, default(OpCastSingleDouble));
                return dst;
            }
            else if (typeof(TResult) == typeof(Double) && typeof(T1) == typeof(Double))
            {
                (src as Pixel<Double>).Accumulate(dst as Pixel<Double>, default(OpCastDoubleDouble));
                return dst;
            }
            else throw new FormatException($"{typeof(T1)},{typeof(TResult)}");
        }

        
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Boolean> src)
            where TResult : struct, IComparable
            => ToPixel<Boolean, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Byte> src)
            where TResult : struct, IComparable
            => ToPixel<Byte, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<UInt16> src)
            where TResult : struct, IComparable
            => ToPixel<UInt16, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<UInt32> src)
            where TResult : struct, IComparable
            => ToPixel<UInt32, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<UInt64> src)
            where TResult : struct, IComparable
            => ToPixel<UInt64, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Int16> src)
            where TResult : struct, IComparable
            => ToPixel<Int16, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Int32> src)
            where TResult : struct, IComparable
            => ToPixel<Int32, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Int64> src)
            where TResult : struct, IComparable
            => ToPixel<Int64, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Single> src)
            where TResult : struct, IComparable
            => ToPixel<Single, TResult>(src);
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Double> src)
            where TResult : struct, IComparable
            => ToPixel<Double, TResult>(src);

        
        private struct OpCastByteByte : IBinaryOperator<Byte, Byte> { public Byte Operate(Byte x) => (Byte)(x); }
        private struct OpCastUInt16Byte : IBinaryOperator<UInt16, Byte> { public Byte Operate(UInt16 x) => (Byte)(x); }
        private struct OpCastUInt32Byte : IBinaryOperator<UInt32, Byte> { public Byte Operate(UInt32 x) => (Byte)(x); }
        private struct OpCastUInt64Byte : IBinaryOperator<UInt64, Byte> { public Byte Operate(UInt64 x) => (Byte)(x); }
        private struct OpCastInt16Byte : IBinaryOperator<Int16, Byte> { public Byte Operate(Int16 x) => (Byte)(x); }
        private struct OpCastInt32Byte : IBinaryOperator<Int32, Byte> { public Byte Operate(Int32 x) => (Byte)(x); }
        private struct OpCastInt64Byte : IBinaryOperator<Int64, Byte> { public Byte Operate(Int64 x) => (Byte)(x); }
        private struct OpCastSingleByte : IBinaryOperator<Single, Byte> { public Byte Operate(Single x) => (Byte)(x); }
        private struct OpCastDoubleByte : IBinaryOperator<Double, Byte> { public Byte Operate(Double x) => (Byte)(x); }
        private struct OpCastByteUInt16 : IBinaryOperator<Byte, UInt16> { public UInt16 Operate(Byte x) => (UInt16)(x); }
        private struct OpCastUInt16UInt16 : IBinaryOperator<UInt16, UInt16> { public UInt16 Operate(UInt16 x) => (UInt16)(x); }
        private struct OpCastUInt32UInt16 : IBinaryOperator<UInt32, UInt16> { public UInt16 Operate(UInt32 x) => (UInt16)(x); }
        private struct OpCastUInt64UInt16 : IBinaryOperator<UInt64, UInt16> { public UInt16 Operate(UInt64 x) => (UInt16)(x); }
        private struct OpCastInt16UInt16 : IBinaryOperator<Int16, UInt16> { public UInt16 Operate(Int16 x) => (UInt16)(x); }
        private struct OpCastInt32UInt16 : IBinaryOperator<Int32, UInt16> { public UInt16 Operate(Int32 x) => (UInt16)(x); }
        private struct OpCastInt64UInt16 : IBinaryOperator<Int64, UInt16> { public UInt16 Operate(Int64 x) => (UInt16)(x); }
        private struct OpCastSingleUInt16 : IBinaryOperator<Single, UInt16> { public UInt16 Operate(Single x) => (UInt16)(x); }
        private struct OpCastDoubleUInt16 : IBinaryOperator<Double, UInt16> { public UInt16 Operate(Double x) => (UInt16)(x); }
        private struct OpCastByteUInt32 : IBinaryOperator<Byte, UInt32> { public UInt32 Operate(Byte x) => (UInt32)(x); }
        private struct OpCastUInt16UInt32 : IBinaryOperator<UInt16, UInt32> { public UInt32 Operate(UInt16 x) => (UInt32)(x); }
        private struct OpCastUInt32UInt32 : IBinaryOperator<UInt32, UInt32> { public UInt32 Operate(UInt32 x) => (UInt32)(x); }
        private struct OpCastUInt64UInt32 : IBinaryOperator<UInt64, UInt32> { public UInt32 Operate(UInt64 x) => (UInt32)(x); }
        private struct OpCastInt16UInt32 : IBinaryOperator<Int16, UInt32> { public UInt32 Operate(Int16 x) => (UInt32)(x); }
        private struct OpCastInt32UInt32 : IBinaryOperator<Int32, UInt32> { public UInt32 Operate(Int32 x) => (UInt32)(x); }
        private struct OpCastInt64UInt32 : IBinaryOperator<Int64, UInt32> { public UInt32 Operate(Int64 x) => (UInt32)(x); }
        private struct OpCastSingleUInt32 : IBinaryOperator<Single, UInt32> { public UInt32 Operate(Single x) => (UInt32)(x); }
        private struct OpCastDoubleUInt32 : IBinaryOperator<Double, UInt32> { public UInt32 Operate(Double x) => (UInt32)(x); }
        private struct OpCastByteUInt64 : IBinaryOperator<Byte, UInt64> { public UInt64 Operate(Byte x) => (UInt64)(x); }
        private struct OpCastUInt16UInt64 : IBinaryOperator<UInt16, UInt64> { public UInt64 Operate(UInt16 x) => (UInt64)(x); }
        private struct OpCastUInt32UInt64 : IBinaryOperator<UInt32, UInt64> { public UInt64 Operate(UInt32 x) => (UInt64)(x); }
        private struct OpCastUInt64UInt64 : IBinaryOperator<UInt64, UInt64> { public UInt64 Operate(UInt64 x) => (UInt64)(x); }
        private struct OpCastInt16UInt64 : IBinaryOperator<Int16, UInt64> { public UInt64 Operate(Int16 x) => (UInt64)(x); }
        private struct OpCastInt32UInt64 : IBinaryOperator<Int32, UInt64> { public UInt64 Operate(Int32 x) => (UInt64)(x); }
        private struct OpCastInt64UInt64 : IBinaryOperator<Int64, UInt64> { public UInt64 Operate(Int64 x) => (UInt64)(x); }
        private struct OpCastSingleUInt64 : IBinaryOperator<Single, UInt64> { public UInt64 Operate(Single x) => (UInt64)(x); }
        private struct OpCastDoubleUInt64 : IBinaryOperator<Double, UInt64> { public UInt64 Operate(Double x) => (UInt64)(x); }
        private struct OpCastByteInt16 : IBinaryOperator<Byte, Int16> { public Int16 Operate(Byte x) => (Int16)(x); }
        private struct OpCastUInt16Int16 : IBinaryOperator<UInt16, Int16> { public Int16 Operate(UInt16 x) => (Int16)(x); }
        private struct OpCastUInt32Int16 : IBinaryOperator<UInt32, Int16> { public Int16 Operate(UInt32 x) => (Int16)(x); }
        private struct OpCastUInt64Int16 : IBinaryOperator<UInt64, Int16> { public Int16 Operate(UInt64 x) => (Int16)(x); }
        private struct OpCastInt16Int16 : IBinaryOperator<Int16, Int16> { public Int16 Operate(Int16 x) => (Int16)(x); }
        private struct OpCastInt32Int16 : IBinaryOperator<Int32, Int16> { public Int16 Operate(Int32 x) => (Int16)(x); }
        private struct OpCastInt64Int16 : IBinaryOperator<Int64, Int16> { public Int16 Operate(Int64 x) => (Int16)(x); }
        private struct OpCastSingleInt16 : IBinaryOperator<Single, Int16> { public Int16 Operate(Single x) => (Int16)(x); }
        private struct OpCastDoubleInt16 : IBinaryOperator<Double, Int16> { public Int16 Operate(Double x) => (Int16)(x); }
        private struct OpCastByteInt32 : IBinaryOperator<Byte, Int32> { public Int32 Operate(Byte x) => (Int32)(x); }
        private struct OpCastUInt16Int32 : IBinaryOperator<UInt16, Int32> { public Int32 Operate(UInt16 x) => (Int32)(x); }
        private struct OpCastUInt32Int32 : IBinaryOperator<UInt32, Int32> { public Int32 Operate(UInt32 x) => (Int32)(x); }
        private struct OpCastUInt64Int32 : IBinaryOperator<UInt64, Int32> { public Int32 Operate(UInt64 x) => (Int32)(x); }
        private struct OpCastInt16Int32 : IBinaryOperator<Int16, Int32> { public Int32 Operate(Int16 x) => (Int32)(x); }
        private struct OpCastInt32Int32 : IBinaryOperator<Int32, Int32> { public Int32 Operate(Int32 x) => (Int32)(x); }
        private struct OpCastInt64Int32 : IBinaryOperator<Int64, Int32> { public Int32 Operate(Int64 x) => (Int32)(x); }
        private struct OpCastSingleInt32 : IBinaryOperator<Single, Int32> { public Int32 Operate(Single x) => (Int32)(x); }
        private struct OpCastDoubleInt32 : IBinaryOperator<Double, Int32> { public Int32 Operate(Double x) => (Int32)(x); }
        private struct OpCastByteInt64 : IBinaryOperator<Byte, Int64> { public Int64 Operate(Byte x) => (Int64)(x); }
        private struct OpCastUInt16Int64 : IBinaryOperator<UInt16, Int64> { public Int64 Operate(UInt16 x) => (Int64)(x); }
        private struct OpCastUInt32Int64 : IBinaryOperator<UInt32, Int64> { public Int64 Operate(UInt32 x) => (Int64)(x); }
        private struct OpCastUInt64Int64 : IBinaryOperator<UInt64, Int64> { public Int64 Operate(UInt64 x) => (Int64)(x); }
        private struct OpCastInt16Int64 : IBinaryOperator<Int16, Int64> { public Int64 Operate(Int16 x) => (Int64)(x); }
        private struct OpCastInt32Int64 : IBinaryOperator<Int32, Int64> { public Int64 Operate(Int32 x) => (Int64)(x); }
        private struct OpCastInt64Int64 : IBinaryOperator<Int64, Int64> { public Int64 Operate(Int64 x) => (Int64)(x); }
        private struct OpCastSingleInt64 : IBinaryOperator<Single, Int64> { public Int64 Operate(Single x) => (Int64)(x); }
        private struct OpCastDoubleInt64 : IBinaryOperator<Double, Int64> { public Int64 Operate(Double x) => (Int64)(x); }
        private struct OpCastByteSingle : IBinaryOperator<Byte, Single> { public Single Operate(Byte x) => (Single)(x); }
        private struct OpCastUInt16Single : IBinaryOperator<UInt16, Single> { public Single Operate(UInt16 x) => (Single)(x); }
        private struct OpCastUInt32Single : IBinaryOperator<UInt32, Single> { public Single Operate(UInt32 x) => (Single)(x); }
        private struct OpCastUInt64Single : IBinaryOperator<UInt64, Single> { public Single Operate(UInt64 x) => (Single)(x); }
        private struct OpCastInt16Single : IBinaryOperator<Int16, Single> { public Single Operate(Int16 x) => (Single)(x); }
        private struct OpCastInt32Single : IBinaryOperator<Int32, Single> { public Single Operate(Int32 x) => (Single)(x); }
        private struct OpCastInt64Single : IBinaryOperator<Int64, Single> { public Single Operate(Int64 x) => (Single)(x); }
        private struct OpCastSingleSingle : IBinaryOperator<Single, Single> { public Single Operate(Single x) => (Single)(x); }
        private struct OpCastDoubleSingle : IBinaryOperator<Double, Single> { public Single Operate(Double x) => (Single)(x); }
        private struct OpCastByteDouble : IBinaryOperator<Byte, Double> { public Double Operate(Byte x) => (Double)(x); }
        private struct OpCastUInt16Double : IBinaryOperator<UInt16, Double> { public Double Operate(UInt16 x) => (Double)(x); }
        private struct OpCastUInt32Double : IBinaryOperator<UInt32, Double> { public Double Operate(UInt32 x) => (Double)(x); }
        private struct OpCastUInt64Double : IBinaryOperator<UInt64, Double> { public Double Operate(UInt64 x) => (Double)(x); }
        private struct OpCastInt16Double : IBinaryOperator<Int16, Double> { public Double Operate(Int16 x) => (Double)(x); }
        private struct OpCastInt32Double : IBinaryOperator<Int32, Double> { public Double Operate(Int32 x) => (Double)(x); }
        private struct OpCastInt64Double : IBinaryOperator<Int64, Double> { public Double Operate(Int64 x) => (Double)(x); }
        private struct OpCastSingleDouble : IBinaryOperator<Single, Double> { public Double Operate(Single x) => (Double)(x); }
        private struct OpCastDoubleDouble : IBinaryOperator<Double, Double> { public Double Operate(Double x) => (Double)(x); }
        
        private struct OpCastBooleanByte : IBinaryOperator<Boolean, Byte> { public Byte Operate(Boolean x) => x ? Byte.MaxValue : (Byte)0; }
        private struct OpCastBooleanUInt16 : IBinaryOperator<Boolean, UInt16> { public UInt16 Operate(Boolean x) => x ? UInt16.MaxValue : (UInt16)0; }
        private struct OpCastBooleanUInt32 : IBinaryOperator<Boolean, UInt32> { public UInt32 Operate(Boolean x) => x ? UInt32.MaxValue : (UInt32)0; }
        private struct OpCastBooleanUInt64 : IBinaryOperator<Boolean, UInt64> { public UInt64 Operate(Boolean x) => x ? UInt64.MaxValue : (UInt64)0; }
        private struct OpCastBooleanInt16 : IBinaryOperator<Boolean, Int16> { public Int16 Operate(Boolean x) => x ? Int16.MaxValue : (Int16)0; }
        private struct OpCastBooleanInt32 : IBinaryOperator<Boolean, Int32> { public Int32 Operate(Boolean x) => x ? Int32.MaxValue : (Int32)0; }
        private struct OpCastBooleanInt64 : IBinaryOperator<Boolean, Int64> { public Int64 Operate(Boolean x) => x ? Int64.MaxValue : (Int64)0; }
        private struct OpCastBooleanSingle : IBinaryOperator<Boolean, Single> { public Single Operate(Boolean x) => x ? Single.MaxValue : (Single)0; }
        private struct OpCastBooleanDouble : IBinaryOperator<Boolean, Double> { public Double Operate(Boolean x) => x ? Double.MaxValue : (Double)0; }

        #endregion


        /*
        public static Pixel<T> TrimSelf<T>(this Pixel<T> src, T upper, T lower) where T : struct, IComparable
        {
            return Trim(src, src, upper, lower);
        }
        public static Pixel<T> Trim<T>(this Pixel<T> src, T upper, T lower) where T : struct, IComparable
        {
            return Trim(src, src.Clone(), upper, lower);
        }
        public static Pixel<T> Trim<T>(this Pixel<T> src, Pixel<T> dst, T upper, T lower) where T : struct, IComparable
        {
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                {
                    ref var buf = ref src[x, y];
                    if (buf.CompareTo(upper) > 0) dst[x, y] = upper;
                    else if (buf.CompareTo(lower) < 0) dst[x, y] = lower;
                    else dst[x, y] = buf;
                }

            return dst;
        }
        */

        //二値化
        public static Pixel<bool> Binarization<T>(this Pixel<T> src, Func<T, bool, bool> func, string color, Pixel<bool> dst = null) where T : struct, IComparable
        {
            dst = dst ?? src.Clone<bool>();
            if (func == null) func = (x, y) => x.CompareTo(0) == 0;

            foreach (var i in src.GetIndex(color))
                dst[i] = func(src[i], dst[i]);

            return dst;
        }

        #region Op

        //ulongはdoubleに明示キャストしないとだめなので省略

        
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(OpAddByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(OpAddByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(OpAddByte));
        private struct OpAddByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(OpAddUInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(OpAddUInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(OpAddUInt16));
        private struct OpAddUInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(OpAddUInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(OpAddUInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(OpAddUInt32));
        private struct OpAddUInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x + y); }
        public static Pixel<UInt64> AddSelf(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src, value, default(OpAddUInt64));
        public static Pixel<UInt64> Add(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src.Clone(), value, default(OpAddUInt64));
        public static Pixel<UInt64> Add(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value) => src.Accumulate(dst, value, default(OpAddUInt64));
        private struct OpAddUInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public UInt64 Operate(UInt64 x, UInt64 y) => (UInt64)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(OpAddInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(OpAddInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(OpAddInt16));
        private struct OpAddInt16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(OpAddInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(OpAddInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(OpAddInt32));
        private struct OpAddInt32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(OpAddInt64));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(OpAddInt64));
        public static Pixel<Int64> Add(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(OpAddInt64));
        private struct OpAddInt64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(OpAddSingle));
        public static Pixel<Single> Add(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(OpAddSingle));
        public static Pixel<Single> Add(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(OpAddSingle));
        private struct OpAddSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(OpAddDouble));
        public static Pixel<Double> Add(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(OpAddDouble));
        public static Pixel<Double> Add(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(OpAddDouble));
        private struct OpAddDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x + y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(OpSubByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(OpSubByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(OpSubByte));
        private struct OpSubByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(OpSubUInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(OpSubUInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(OpSubUInt16));
        private struct OpSubUInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(OpSubUInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(OpSubUInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(OpSubUInt32));
        private struct OpSubUInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x - y); }
        public static Pixel<UInt64> SubSelf(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src, value, default(OpSubUInt64));
        public static Pixel<UInt64> Sub(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src.Clone(), value, default(OpSubUInt64));
        public static Pixel<UInt64> Sub(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value) => src.Accumulate(dst, value, default(OpSubUInt64));
        private struct OpSubUInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public UInt64 Operate(UInt64 x, UInt64 y) => (UInt64)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(OpSubInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(OpSubInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(OpSubInt16));
        private struct OpSubInt16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(OpSubInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(OpSubInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(OpSubInt32));
        private struct OpSubInt32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(OpSubInt64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(OpSubInt64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(OpSubInt64));
        private struct OpSubInt64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(OpSubSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(OpSubSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(OpSubSingle));
        private struct OpSubSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(OpSubDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(OpSubDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(OpSubDouble));
        private struct OpSubDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x - y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(OpMulByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(OpMulByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(OpMulByte));
        private struct OpMulByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(OpMulUInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(OpMulUInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(OpMulUInt16));
        private struct OpMulUInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(OpMulUInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(OpMulUInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(OpMulUInt32));
        private struct OpMulUInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x * y); }
        public static Pixel<UInt64> MulSelf(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src, value, default(OpMulUInt64));
        public static Pixel<UInt64> Mul(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src.Clone(), value, default(OpMulUInt64));
        public static Pixel<UInt64> Mul(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value) => src.Accumulate(dst, value, default(OpMulUInt64));
        private struct OpMulUInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public UInt64 Operate(UInt64 x, UInt64 y) => (UInt64)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(OpMulInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(OpMulInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(OpMulInt16));
        private struct OpMulInt16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(OpMulInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(OpMulInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(OpMulInt32));
        private struct OpMulInt32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(OpMulInt64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(OpMulInt64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(OpMulInt64));
        private struct OpMulInt64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(OpMulSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(OpMulSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(OpMulSingle));
        private struct OpMulSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(OpMulDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(OpMulDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(OpMulDouble));
        private struct OpMulDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x * y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src, Byte value) => src.Accumulate(src, value, default(OpDivByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Byte value) => src.Accumulate(src.Clone(), value, default(OpDivByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src, Pixel<Byte> dst, Byte value) => src.Accumulate(dst, value, default(OpDivByte));
        private struct OpDivByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src, value, default(OpDivUInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, UInt16 value) => src.Accumulate(src.Clone(), value, default(OpDivUInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src, Pixel<UInt16> dst, UInt16 value) => src.Accumulate(dst, value, default(OpDivUInt16));
        private struct OpDivUInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src, value, default(OpDivUInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, UInt32 value) => src.Accumulate(src.Clone(), value, default(OpDivUInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src, Pixel<UInt32> dst, UInt32 value) => src.Accumulate(dst, value, default(OpDivUInt32));
        private struct OpDivUInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x / y); }
        public static Pixel<UInt64> DivSelf(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src, value, default(OpDivUInt64));
        public static Pixel<UInt64> Div(this Pixel<UInt64> src, UInt64 value) => src.Accumulate(src.Clone(), value, default(OpDivUInt64));
        public static Pixel<UInt64> Div(this Pixel<UInt64> src, Pixel<UInt64> dst, UInt64 value) => src.Accumulate(dst, value, default(OpDivUInt64));
        private struct OpDivUInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public UInt64 Operate(UInt64 x, UInt64 y) => (UInt64)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src, Int16 value) => src.Accumulate(src, value, default(OpDivInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Int16 value) => src.Accumulate(src.Clone(), value, default(OpDivInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src, Pixel<Int16> dst, Int16 value) => src.Accumulate(dst, value, default(OpDivInt16));
        private struct OpDivInt16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src, Int32 value) => src.Accumulate(src, value, default(OpDivInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Int32 value) => src.Accumulate(src.Clone(), value, default(OpDivInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src, Pixel<Int32> dst, Int32 value) => src.Accumulate(dst, value, default(OpDivInt32));
        private struct OpDivInt32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src, Int64 value) => src.Accumulate(src, value, default(OpDivInt64));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Int64 value) => src.Accumulate(src.Clone(), value, default(OpDivInt64));
        public static Pixel<Int64> Div(this Pixel<Int64> src, Pixel<Int64> dst, Int64 value) => src.Accumulate(dst, value, default(OpDivInt64));
        private struct OpDivInt64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src, Single value) => src.Accumulate(src, value, default(OpDivSingle));
        public static Pixel<Single> Div(this Pixel<Single> src, Single value) => src.Accumulate(src.Clone(), value, default(OpDivSingle));
        public static Pixel<Single> Div(this Pixel<Single> src, Pixel<Single> dst, Single value) => src.Accumulate(dst, value, default(OpDivSingle));
        private struct OpDivSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src, Double value) => src.Accumulate(src, value, default(OpDivDouble));
        public static Pixel<Double> Div(this Pixel<Double> src, Double value) => src.Accumulate(src.Clone(), value, default(OpDivDouble));
        public static Pixel<Double> Div(this Pixel<Double> src, Pixel<Double> dst, Double value) => src.Accumulate(dst, value, default(OpDivDouble));
        private struct OpDivDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x / y); }

        
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddByteByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteByte));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddByteByte));
        private struct OpAddByteByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x + y); }
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddByteUInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteUInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddByteUInt16));
        private struct OpAddByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public Byte Operate(Byte x, UInt16 y) => (Byte)(x + y); }
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddByteUInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteUInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddByteUInt32));
        private struct OpAddByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public Byte Operate(Byte x, UInt32 y) => (Byte)(x + y); }
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddByteInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteInt16));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddByteInt16));
        private struct OpAddByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public Byte Operate(Byte x, Int16 y) => (Byte)(x + y); }
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddByteInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteInt32));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddByteInt32));
        private struct OpAddByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public Byte Operate(Byte x, Int32 y) => (Byte)(x + y); }
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddByteInt64));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteInt64));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddByteInt64));
        private struct OpAddByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public Byte Operate(Byte x, Int64 y) => (Byte)(x + y); }
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddByteSingle));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteSingle));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddByteSingle));
        private struct OpAddByteSingle : IBinaryOperator<Byte, Single, Byte> { public Byte Operate(Byte x, Single y) => (Byte)(x + y); }
        public static Pixel<Byte> AddSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddByteDouble));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddByteDouble));
        public static Pixel<Byte> Add(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddByteDouble));
        private struct OpAddByteDouble : IBinaryOperator<Byte, Double, Byte> { public Byte Operate(Byte x, Double y) => (Byte)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16Byte));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16Byte));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16Byte));
        private struct OpAddUInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public UInt16 Operate(UInt16 x, Byte y) => (UInt16)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16UInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16UInt16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16UInt16));
        private struct OpAddUInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16UInt32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16UInt32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16UInt32));
        private struct OpAddUInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public UInt16 Operate(UInt16 x, UInt32 y) => (UInt16)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16Int16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16Int16));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16Int16));
        private struct OpAddUInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public UInt16 Operate(UInt16 x, Int16 y) => (UInt16)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16Int32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16Int32));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16Int32));
        private struct OpAddUInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public UInt16 Operate(UInt16 x, Int32 y) => (UInt16)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16Int64));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16Int64));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16Int64));
        private struct OpAddUInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public UInt16 Operate(UInt16 x, Int64 y) => (UInt16)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16Single));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16Single));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16Single));
        private struct OpAddUInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public UInt16 Operate(UInt16 x, Single y) => (UInt16)(x + y); }
        public static Pixel<UInt16> AddSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddUInt16Double));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt16Double));
        public static Pixel<UInt16> Add(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddUInt16Double));
        private struct OpAddUInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public UInt16 Operate(UInt16 x, Double y) => (UInt16)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32Byte));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32Byte));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32Byte));
        private struct OpAddUInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public UInt32 Operate(UInt32 x, Byte y) => (UInt32)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32UInt16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32UInt16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32UInt16));
        private struct OpAddUInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public UInt32 Operate(UInt32 x, UInt16 y) => (UInt32)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32UInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32UInt32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32UInt32));
        private struct OpAddUInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32Int16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32Int16));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32Int16));
        private struct OpAddUInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public UInt32 Operate(UInt32 x, Int16 y) => (UInt32)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32Int32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32Int32));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32Int32));
        private struct OpAddUInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public UInt32 Operate(UInt32 x, Int32 y) => (UInt32)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32Int64));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32Int64));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32Int64));
        private struct OpAddUInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public UInt32 Operate(UInt32 x, Int64 y) => (UInt32)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32Single));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32Single));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32Single));
        private struct OpAddUInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public UInt32 Operate(UInt32 x, Single y) => (UInt32)(x + y); }
        public static Pixel<UInt32> AddSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddUInt32Double));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddUInt32Double));
        public static Pixel<UInt32> Add(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddUInt32Double));
        private struct OpAddUInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public UInt32 Operate(UInt32 x, Double y) => (UInt32)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddInt16Byte));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16Byte));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddInt16Byte));
        private struct OpAddInt16Byte : IBinaryOperator<Int16, Byte, Int16> { public Int16 Operate(Int16 x, Byte y) => (Int16)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddInt16UInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16UInt16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddInt16UInt16));
        private struct OpAddInt16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public Int16 Operate(Int16 x, UInt16 y) => (Int16)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddInt16UInt32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16UInt32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddInt16UInt32));
        private struct OpAddInt16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public Int16 Operate(Int16 x, UInt32 y) => (Int16)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddInt16Int16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16Int16));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddInt16Int16));
        private struct OpAddInt16Int16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddInt16Int32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16Int32));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddInt16Int32));
        private struct OpAddInt16Int32 : IBinaryOperator<Int16, Int32, Int16> { public Int16 Operate(Int16 x, Int32 y) => (Int16)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddInt16Int64));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16Int64));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddInt16Int64));
        private struct OpAddInt16Int64 : IBinaryOperator<Int16, Int64, Int16> { public Int16 Operate(Int16 x, Int64 y) => (Int16)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddInt16Single));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16Single));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddInt16Single));
        private struct OpAddInt16Single : IBinaryOperator<Int16, Single, Int16> { public Int16 Operate(Int16 x, Single y) => (Int16)(x + y); }
        public static Pixel<Int16> AddSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddInt16Double));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt16Double));
        public static Pixel<Int16> Add(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddInt16Double));
        private struct OpAddInt16Double : IBinaryOperator<Int16, Double, Int16> { public Int16 Operate(Int16 x, Double y) => (Int16)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddInt32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddInt32Byte));
        private struct OpAddInt32Byte : IBinaryOperator<Int32, Byte, Int32> { public Int32 Operate(Int32 x, Byte y) => (Int32)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddInt32UInt16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32UInt16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddInt32UInt16));
        private struct OpAddInt32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public Int32 Operate(Int32 x, UInt16 y) => (Int32)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddInt32UInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32UInt32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddInt32UInt32));
        private struct OpAddInt32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public Int32 Operate(Int32 x, UInt32 y) => (Int32)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddInt32Int16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32Int16));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddInt32Int16));
        private struct OpAddInt32Int16 : IBinaryOperator<Int32, Int16, Int32> { public Int32 Operate(Int32 x, Int16 y) => (Int32)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddInt32Int32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32Int32));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddInt32Int32));
        private struct OpAddInt32Int32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddInt32Int64));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32Int64));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddInt32Int64));
        private struct OpAddInt32Int64 : IBinaryOperator<Int32, Int64, Int32> { public Int32 Operate(Int32 x, Int64 y) => (Int32)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddInt32Single));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32Single));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddInt32Single));
        private struct OpAddInt32Single : IBinaryOperator<Int32, Single, Int32> { public Int32 Operate(Int32 x, Single y) => (Int32)(x + y); }
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddInt32Double));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt32Double));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddInt32Double));
        private struct OpAddInt32Double : IBinaryOperator<Int32, Double, Int32> { public Int32 Operate(Int32 x, Double y) => (Int32)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddInt64Byte));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64Byte));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddInt64Byte));
        private struct OpAddInt64Byte : IBinaryOperator<Int64, Byte, Int64> { public Int64 Operate(Int64 x, Byte y) => (Int64)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddInt64UInt16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64UInt16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddInt64UInt16));
        private struct OpAddInt64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public Int64 Operate(Int64 x, UInt16 y) => (Int64)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddInt64UInt32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64UInt32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddInt64UInt32));
        private struct OpAddInt64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public Int64 Operate(Int64 x, UInt32 y) => (Int64)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddInt64Int16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64Int16));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddInt64Int16));
        private struct OpAddInt64Int16 : IBinaryOperator<Int64, Int16, Int64> { public Int64 Operate(Int64 x, Int16 y) => (Int64)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddInt64Int32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64Int32));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddInt64Int32));
        private struct OpAddInt64Int32 : IBinaryOperator<Int64, Int32, Int64> { public Int64 Operate(Int64 x, Int32 y) => (Int64)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddInt64Int64));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64Int64));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddInt64Int64));
        private struct OpAddInt64Int64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddInt64Single));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64Single));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddInt64Single));
        private struct OpAddInt64Single : IBinaryOperator<Int64, Single, Int64> { public Int64 Operate(Int64 x, Single y) => (Int64)(x + y); }
        public static Pixel<Int64> AddSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddInt64Double));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddInt64Double));
        public static Pixel<Int64> Add(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddInt64Double));
        private struct OpAddInt64Double : IBinaryOperator<Int64, Double, Int64> { public Int64 Operate(Int64 x, Double y) => (Int64)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddSingleByte));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleByte));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddSingleByte));
        private struct OpAddSingleByte : IBinaryOperator<Single, Byte, Single> { public Single Operate(Single x, Byte y) => (Single)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddSingleUInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleUInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddSingleUInt16));
        private struct OpAddSingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public Single Operate(Single x, UInt16 y) => (Single)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddSingleUInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleUInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddSingleUInt32));
        private struct OpAddSingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public Single Operate(Single x, UInt32 y) => (Single)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddSingleInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleInt16));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddSingleInt16));
        private struct OpAddSingleInt16 : IBinaryOperator<Single, Int16, Single> { public Single Operate(Single x, Int16 y) => (Single)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddSingleInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleInt32));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddSingleInt32));
        private struct OpAddSingleInt32 : IBinaryOperator<Single, Int32, Single> { public Single Operate(Single x, Int32 y) => (Single)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddSingleInt64));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleInt64));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddSingleInt64));
        private struct OpAddSingleInt64 : IBinaryOperator<Single, Int64, Single> { public Single Operate(Single x, Int64 y) => (Single)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddSingleSingle));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleSingle));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddSingleSingle));
        private struct OpAddSingleSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x + y); }
        public static Pixel<Single> AddSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddSingleDouble));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddSingleDouble));
        public static Pixel<Single> Add(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddSingleDouble));
        private struct OpAddSingleDouble : IBinaryOperator<Single, Double, Single> { public Single Operate(Single x, Double y) => (Single)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleByte));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleByte));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleByte));
        private struct OpAddDoubleByte : IBinaryOperator<Double, Byte, Double> { public Double Operate(Double x, Byte y) => (Double)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleUInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleUInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleUInt16));
        private struct OpAddDoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public Double Operate(Double x, UInt16 y) => (Double)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleUInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleUInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleUInt32));
        private struct OpAddDoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public Double Operate(Double x, UInt32 y) => (Double)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleInt16));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleInt16));
        private struct OpAddDoubleInt16 : IBinaryOperator<Double, Int16, Double> { public Double Operate(Double x, Int16 y) => (Double)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleInt32));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleInt32));
        private struct OpAddDoubleInt32 : IBinaryOperator<Double, Int32, Double> { public Double Operate(Double x, Int32 y) => (Double)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleInt64));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleInt64));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleInt64));
        private struct OpAddDoubleInt64 : IBinaryOperator<Double, Int64, Double> { public Double Operate(Double x, Int64 y) => (Double)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleSingle));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleSingle));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleSingle));
        private struct OpAddDoubleSingle : IBinaryOperator<Double, Single, Double> { public Double Operate(Double x, Single y) => (Double)(x + y); }
        public static Pixel<Double> AddSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpAddDoubleDouble));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpAddDoubleDouble));
        public static Pixel<Double> Add(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpAddDoubleDouble));
        private struct OpAddDoubleDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x + y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubByteByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteByte));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubByteByte));
        private struct OpSubByteByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x - y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubByteUInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteUInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubByteUInt16));
        private struct OpSubByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public Byte Operate(Byte x, UInt16 y) => (Byte)(x - y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubByteUInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteUInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubByteUInt32));
        private struct OpSubByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public Byte Operate(Byte x, UInt32 y) => (Byte)(x - y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubByteInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteInt16));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubByteInt16));
        private struct OpSubByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public Byte Operate(Byte x, Int16 y) => (Byte)(x - y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubByteInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteInt32));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubByteInt32));
        private struct OpSubByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public Byte Operate(Byte x, Int32 y) => (Byte)(x - y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubByteInt64));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteInt64));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubByteInt64));
        private struct OpSubByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public Byte Operate(Byte x, Int64 y) => (Byte)(x - y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubByteSingle));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteSingle));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubByteSingle));
        private struct OpSubByteSingle : IBinaryOperator<Byte, Single, Byte> { public Byte Operate(Byte x, Single y) => (Byte)(x - y); }
        public static Pixel<Byte> SubSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubByteDouble));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubByteDouble));
        public static Pixel<Byte> Sub(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubByteDouble));
        private struct OpSubByteDouble : IBinaryOperator<Byte, Double, Byte> { public Byte Operate(Byte x, Double y) => (Byte)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16Byte));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16Byte));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16Byte));
        private struct OpSubUInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public UInt16 Operate(UInt16 x, Byte y) => (UInt16)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16UInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16UInt16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16UInt16));
        private struct OpSubUInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16UInt32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16UInt32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16UInt32));
        private struct OpSubUInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public UInt16 Operate(UInt16 x, UInt32 y) => (UInt16)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16Int16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16Int16));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16Int16));
        private struct OpSubUInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public UInt16 Operate(UInt16 x, Int16 y) => (UInt16)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16Int32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16Int32));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16Int32));
        private struct OpSubUInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public UInt16 Operate(UInt16 x, Int32 y) => (UInt16)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16Int64));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16Int64));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16Int64));
        private struct OpSubUInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public UInt16 Operate(UInt16 x, Int64 y) => (UInt16)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16Single));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16Single));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16Single));
        private struct OpSubUInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public UInt16 Operate(UInt16 x, Single y) => (UInt16)(x - y); }
        public static Pixel<UInt16> SubSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubUInt16Double));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt16Double));
        public static Pixel<UInt16> Sub(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubUInt16Double));
        private struct OpSubUInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public UInt16 Operate(UInt16 x, Double y) => (UInt16)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32Byte));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32Byte));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32Byte));
        private struct OpSubUInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public UInt32 Operate(UInt32 x, Byte y) => (UInt32)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32UInt16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32UInt16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32UInt16));
        private struct OpSubUInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public UInt32 Operate(UInt32 x, UInt16 y) => (UInt32)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32UInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32UInt32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32UInt32));
        private struct OpSubUInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32Int16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32Int16));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32Int16));
        private struct OpSubUInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public UInt32 Operate(UInt32 x, Int16 y) => (UInt32)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32Int32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32Int32));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32Int32));
        private struct OpSubUInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public UInt32 Operate(UInt32 x, Int32 y) => (UInt32)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32Int64));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32Int64));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32Int64));
        private struct OpSubUInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public UInt32 Operate(UInt32 x, Int64 y) => (UInt32)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32Single));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32Single));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32Single));
        private struct OpSubUInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public UInt32 Operate(UInt32 x, Single y) => (UInt32)(x - y); }
        public static Pixel<UInt32> SubSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubUInt32Double));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubUInt32Double));
        public static Pixel<UInt32> Sub(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubUInt32Double));
        private struct OpSubUInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public UInt32 Operate(UInt32 x, Double y) => (UInt32)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubInt16Byte));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16Byte));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubInt16Byte));
        private struct OpSubInt16Byte : IBinaryOperator<Int16, Byte, Int16> { public Int16 Operate(Int16 x, Byte y) => (Int16)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubInt16UInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16UInt16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubInt16UInt16));
        private struct OpSubInt16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public Int16 Operate(Int16 x, UInt16 y) => (Int16)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubInt16UInt32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16UInt32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubInt16UInt32));
        private struct OpSubInt16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public Int16 Operate(Int16 x, UInt32 y) => (Int16)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubInt16Int16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16Int16));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubInt16Int16));
        private struct OpSubInt16Int16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubInt16Int32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16Int32));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubInt16Int32));
        private struct OpSubInt16Int32 : IBinaryOperator<Int16, Int32, Int16> { public Int16 Operate(Int16 x, Int32 y) => (Int16)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubInt16Int64));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16Int64));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubInt16Int64));
        private struct OpSubInt16Int64 : IBinaryOperator<Int16, Int64, Int16> { public Int16 Operate(Int16 x, Int64 y) => (Int16)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubInt16Single));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16Single));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubInt16Single));
        private struct OpSubInt16Single : IBinaryOperator<Int16, Single, Int16> { public Int16 Operate(Int16 x, Single y) => (Int16)(x - y); }
        public static Pixel<Int16> SubSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubInt16Double));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt16Double));
        public static Pixel<Int16> Sub(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubInt16Double));
        private struct OpSubInt16Double : IBinaryOperator<Int16, Double, Int16> { public Int16 Operate(Int16 x, Double y) => (Int16)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubInt32Byte));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32Byte));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubInt32Byte));
        private struct OpSubInt32Byte : IBinaryOperator<Int32, Byte, Int32> { public Int32 Operate(Int32 x, Byte y) => (Int32)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubInt32UInt16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32UInt16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubInt32UInt16));
        private struct OpSubInt32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public Int32 Operate(Int32 x, UInt16 y) => (Int32)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubInt32UInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32UInt32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubInt32UInt32));
        private struct OpSubInt32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public Int32 Operate(Int32 x, UInt32 y) => (Int32)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubInt32Int16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32Int16));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubInt32Int16));
        private struct OpSubInt32Int16 : IBinaryOperator<Int32, Int16, Int32> { public Int32 Operate(Int32 x, Int16 y) => (Int32)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubInt32Int32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32Int32));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubInt32Int32));
        private struct OpSubInt32Int32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubInt32Int64));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32Int64));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubInt32Int64));
        private struct OpSubInt32Int64 : IBinaryOperator<Int32, Int64, Int32> { public Int32 Operate(Int32 x, Int64 y) => (Int32)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubInt32Single));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32Single));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubInt32Single));
        private struct OpSubInt32Single : IBinaryOperator<Int32, Single, Int32> { public Int32 Operate(Int32 x, Single y) => (Int32)(x - y); }
        public static Pixel<Int32> SubSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubInt32Double));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt32Double));
        public static Pixel<Int32> Sub(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubInt32Double));
        private struct OpSubInt32Double : IBinaryOperator<Int32, Double, Int32> { public Int32 Operate(Int32 x, Double y) => (Int32)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubInt64Byte));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64Byte));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubInt64Byte));
        private struct OpSubInt64Byte : IBinaryOperator<Int64, Byte, Int64> { public Int64 Operate(Int64 x, Byte y) => (Int64)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubInt64UInt16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64UInt16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubInt64UInt16));
        private struct OpSubInt64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public Int64 Operate(Int64 x, UInt16 y) => (Int64)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubInt64UInt32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64UInt32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubInt64UInt32));
        private struct OpSubInt64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public Int64 Operate(Int64 x, UInt32 y) => (Int64)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubInt64Int16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64Int16));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubInt64Int16));
        private struct OpSubInt64Int16 : IBinaryOperator<Int64, Int16, Int64> { public Int64 Operate(Int64 x, Int16 y) => (Int64)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubInt64Int32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64Int32));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubInt64Int32));
        private struct OpSubInt64Int32 : IBinaryOperator<Int64, Int32, Int64> { public Int64 Operate(Int64 x, Int32 y) => (Int64)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubInt64Int64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64Int64));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubInt64Int64));
        private struct OpSubInt64Int64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubInt64Single));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64Single));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubInt64Single));
        private struct OpSubInt64Single : IBinaryOperator<Int64, Single, Int64> { public Int64 Operate(Int64 x, Single y) => (Int64)(x - y); }
        public static Pixel<Int64> SubSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubInt64Double));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubInt64Double));
        public static Pixel<Int64> Sub(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubInt64Double));
        private struct OpSubInt64Double : IBinaryOperator<Int64, Double, Int64> { public Int64 Operate(Int64 x, Double y) => (Int64)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubSingleByte));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleByte));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubSingleByte));
        private struct OpSubSingleByte : IBinaryOperator<Single, Byte, Single> { public Single Operate(Single x, Byte y) => (Single)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubSingleUInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleUInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubSingleUInt16));
        private struct OpSubSingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public Single Operate(Single x, UInt16 y) => (Single)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubSingleUInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleUInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubSingleUInt32));
        private struct OpSubSingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public Single Operate(Single x, UInt32 y) => (Single)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubSingleInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleInt16));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubSingleInt16));
        private struct OpSubSingleInt16 : IBinaryOperator<Single, Int16, Single> { public Single Operate(Single x, Int16 y) => (Single)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubSingleInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleInt32));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubSingleInt32));
        private struct OpSubSingleInt32 : IBinaryOperator<Single, Int32, Single> { public Single Operate(Single x, Int32 y) => (Single)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubSingleInt64));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleInt64));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubSingleInt64));
        private struct OpSubSingleInt64 : IBinaryOperator<Single, Int64, Single> { public Single Operate(Single x, Int64 y) => (Single)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubSingleSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleSingle));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubSingleSingle));
        private struct OpSubSingleSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x - y); }
        public static Pixel<Single> SubSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubSingleDouble));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubSingleDouble));
        public static Pixel<Single> Sub(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubSingleDouble));
        private struct OpSubSingleDouble : IBinaryOperator<Single, Double, Single> { public Single Operate(Single x, Double y) => (Single)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleByte));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleByte));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleByte));
        private struct OpSubDoubleByte : IBinaryOperator<Double, Byte, Double> { public Double Operate(Double x, Byte y) => (Double)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleUInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleUInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleUInt16));
        private struct OpSubDoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public Double Operate(Double x, UInt16 y) => (Double)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleUInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleUInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleUInt32));
        private struct OpSubDoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public Double Operate(Double x, UInt32 y) => (Double)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleInt16));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleInt16));
        private struct OpSubDoubleInt16 : IBinaryOperator<Double, Int16, Double> { public Double Operate(Double x, Int16 y) => (Double)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleInt32));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleInt32));
        private struct OpSubDoubleInt32 : IBinaryOperator<Double, Int32, Double> { public Double Operate(Double x, Int32 y) => (Double)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleInt64));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleInt64));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleInt64));
        private struct OpSubDoubleInt64 : IBinaryOperator<Double, Int64, Double> { public Double Operate(Double x, Int64 y) => (Double)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleSingle));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleSingle));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleSingle));
        private struct OpSubDoubleSingle : IBinaryOperator<Double, Single, Double> { public Double Operate(Double x, Single y) => (Double)(x - y); }
        public static Pixel<Double> SubSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpSubDoubleDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpSubDoubleDouble));
        public static Pixel<Double> Sub(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpSubDoubleDouble));
        private struct OpSubDoubleDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x - y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulByteByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteByte));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulByteByte));
        private struct OpMulByteByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x * y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulByteUInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteUInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulByteUInt16));
        private struct OpMulByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public Byte Operate(Byte x, UInt16 y) => (Byte)(x * y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulByteUInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteUInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulByteUInt32));
        private struct OpMulByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public Byte Operate(Byte x, UInt32 y) => (Byte)(x * y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulByteInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteInt16));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulByteInt16));
        private struct OpMulByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public Byte Operate(Byte x, Int16 y) => (Byte)(x * y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulByteInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteInt32));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulByteInt32));
        private struct OpMulByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public Byte Operate(Byte x, Int32 y) => (Byte)(x * y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulByteInt64));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteInt64));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulByteInt64));
        private struct OpMulByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public Byte Operate(Byte x, Int64 y) => (Byte)(x * y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulByteSingle));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteSingle));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulByteSingle));
        private struct OpMulByteSingle : IBinaryOperator<Byte, Single, Byte> { public Byte Operate(Byte x, Single y) => (Byte)(x * y); }
        public static Pixel<Byte> MulSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulByteDouble));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulByteDouble));
        public static Pixel<Byte> Mul(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulByteDouble));
        private struct OpMulByteDouble : IBinaryOperator<Byte, Double, Byte> { public Byte Operate(Byte x, Double y) => (Byte)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16Byte));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16Byte));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16Byte));
        private struct OpMulUInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public UInt16 Operate(UInt16 x, Byte y) => (UInt16)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16UInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16UInt16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16UInt16));
        private struct OpMulUInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16UInt32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16UInt32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16UInt32));
        private struct OpMulUInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public UInt16 Operate(UInt16 x, UInt32 y) => (UInt16)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16Int16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16Int16));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16Int16));
        private struct OpMulUInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public UInt16 Operate(UInt16 x, Int16 y) => (UInt16)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16Int32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16Int32));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16Int32));
        private struct OpMulUInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public UInt16 Operate(UInt16 x, Int32 y) => (UInt16)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16Int64));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16Int64));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16Int64));
        private struct OpMulUInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public UInt16 Operate(UInt16 x, Int64 y) => (UInt16)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16Single));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16Single));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16Single));
        private struct OpMulUInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public UInt16 Operate(UInt16 x, Single y) => (UInt16)(x * y); }
        public static Pixel<UInt16> MulSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulUInt16Double));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt16Double));
        public static Pixel<UInt16> Mul(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulUInt16Double));
        private struct OpMulUInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public UInt16 Operate(UInt16 x, Double y) => (UInt16)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32Byte));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32Byte));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32Byte));
        private struct OpMulUInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public UInt32 Operate(UInt32 x, Byte y) => (UInt32)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32UInt16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32UInt16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32UInt16));
        private struct OpMulUInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public UInt32 Operate(UInt32 x, UInt16 y) => (UInt32)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32UInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32UInt32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32UInt32));
        private struct OpMulUInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32Int16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32Int16));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32Int16));
        private struct OpMulUInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public UInt32 Operate(UInt32 x, Int16 y) => (UInt32)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32Int32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32Int32));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32Int32));
        private struct OpMulUInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public UInt32 Operate(UInt32 x, Int32 y) => (UInt32)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32Int64));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32Int64));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32Int64));
        private struct OpMulUInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public UInt32 Operate(UInt32 x, Int64 y) => (UInt32)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32Single));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32Single));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32Single));
        private struct OpMulUInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public UInt32 Operate(UInt32 x, Single y) => (UInt32)(x * y); }
        public static Pixel<UInt32> MulSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulUInt32Double));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulUInt32Double));
        public static Pixel<UInt32> Mul(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulUInt32Double));
        private struct OpMulUInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public UInt32 Operate(UInt32 x, Double y) => (UInt32)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulInt16Byte));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16Byte));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulInt16Byte));
        private struct OpMulInt16Byte : IBinaryOperator<Int16, Byte, Int16> { public Int16 Operate(Int16 x, Byte y) => (Int16)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulInt16UInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16UInt16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulInt16UInt16));
        private struct OpMulInt16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public Int16 Operate(Int16 x, UInt16 y) => (Int16)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulInt16UInt32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16UInt32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulInt16UInt32));
        private struct OpMulInt16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public Int16 Operate(Int16 x, UInt32 y) => (Int16)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulInt16Int16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16Int16));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulInt16Int16));
        private struct OpMulInt16Int16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulInt16Int32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16Int32));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulInt16Int32));
        private struct OpMulInt16Int32 : IBinaryOperator<Int16, Int32, Int16> { public Int16 Operate(Int16 x, Int32 y) => (Int16)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulInt16Int64));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16Int64));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulInt16Int64));
        private struct OpMulInt16Int64 : IBinaryOperator<Int16, Int64, Int16> { public Int16 Operate(Int16 x, Int64 y) => (Int16)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulInt16Single));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16Single));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulInt16Single));
        private struct OpMulInt16Single : IBinaryOperator<Int16, Single, Int16> { public Int16 Operate(Int16 x, Single y) => (Int16)(x * y); }
        public static Pixel<Int16> MulSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulInt16Double));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt16Double));
        public static Pixel<Int16> Mul(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulInt16Double));
        private struct OpMulInt16Double : IBinaryOperator<Int16, Double, Int16> { public Int16 Operate(Int16 x, Double y) => (Int16)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulInt32Byte));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32Byte));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulInt32Byte));
        private struct OpMulInt32Byte : IBinaryOperator<Int32, Byte, Int32> { public Int32 Operate(Int32 x, Byte y) => (Int32)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulInt32UInt16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32UInt16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulInt32UInt16));
        private struct OpMulInt32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public Int32 Operate(Int32 x, UInt16 y) => (Int32)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulInt32UInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32UInt32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulInt32UInt32));
        private struct OpMulInt32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public Int32 Operate(Int32 x, UInt32 y) => (Int32)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulInt32Int16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32Int16));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulInt32Int16));
        private struct OpMulInt32Int16 : IBinaryOperator<Int32, Int16, Int32> { public Int32 Operate(Int32 x, Int16 y) => (Int32)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulInt32Int32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32Int32));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulInt32Int32));
        private struct OpMulInt32Int32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulInt32Int64));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32Int64));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulInt32Int64));
        private struct OpMulInt32Int64 : IBinaryOperator<Int32, Int64, Int32> { public Int32 Operate(Int32 x, Int64 y) => (Int32)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulInt32Single));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32Single));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulInt32Single));
        private struct OpMulInt32Single : IBinaryOperator<Int32, Single, Int32> { public Int32 Operate(Int32 x, Single y) => (Int32)(x * y); }
        public static Pixel<Int32> MulSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulInt32Double));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt32Double));
        public static Pixel<Int32> Mul(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulInt32Double));
        private struct OpMulInt32Double : IBinaryOperator<Int32, Double, Int32> { public Int32 Operate(Int32 x, Double y) => (Int32)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulInt64Byte));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64Byte));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulInt64Byte));
        private struct OpMulInt64Byte : IBinaryOperator<Int64, Byte, Int64> { public Int64 Operate(Int64 x, Byte y) => (Int64)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulInt64UInt16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64UInt16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulInt64UInt16));
        private struct OpMulInt64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public Int64 Operate(Int64 x, UInt16 y) => (Int64)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulInt64UInt32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64UInt32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulInt64UInt32));
        private struct OpMulInt64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public Int64 Operate(Int64 x, UInt32 y) => (Int64)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulInt64Int16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64Int16));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulInt64Int16));
        private struct OpMulInt64Int16 : IBinaryOperator<Int64, Int16, Int64> { public Int64 Operate(Int64 x, Int16 y) => (Int64)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulInt64Int32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64Int32));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulInt64Int32));
        private struct OpMulInt64Int32 : IBinaryOperator<Int64, Int32, Int64> { public Int64 Operate(Int64 x, Int32 y) => (Int64)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulInt64Int64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64Int64));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulInt64Int64));
        private struct OpMulInt64Int64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulInt64Single));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64Single));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulInt64Single));
        private struct OpMulInt64Single : IBinaryOperator<Int64, Single, Int64> { public Int64 Operate(Int64 x, Single y) => (Int64)(x * y); }
        public static Pixel<Int64> MulSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulInt64Double));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulInt64Double));
        public static Pixel<Int64> Mul(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulInt64Double));
        private struct OpMulInt64Double : IBinaryOperator<Int64, Double, Int64> { public Int64 Operate(Int64 x, Double y) => (Int64)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulSingleByte));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleByte));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulSingleByte));
        private struct OpMulSingleByte : IBinaryOperator<Single, Byte, Single> { public Single Operate(Single x, Byte y) => (Single)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulSingleUInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleUInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulSingleUInt16));
        private struct OpMulSingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public Single Operate(Single x, UInt16 y) => (Single)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulSingleUInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleUInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulSingleUInt32));
        private struct OpMulSingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public Single Operate(Single x, UInt32 y) => (Single)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulSingleInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleInt16));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulSingleInt16));
        private struct OpMulSingleInt16 : IBinaryOperator<Single, Int16, Single> { public Single Operate(Single x, Int16 y) => (Single)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulSingleInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleInt32));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulSingleInt32));
        private struct OpMulSingleInt32 : IBinaryOperator<Single, Int32, Single> { public Single Operate(Single x, Int32 y) => (Single)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulSingleInt64));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleInt64));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulSingleInt64));
        private struct OpMulSingleInt64 : IBinaryOperator<Single, Int64, Single> { public Single Operate(Single x, Int64 y) => (Single)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulSingleSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleSingle));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulSingleSingle));
        private struct OpMulSingleSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x * y); }
        public static Pixel<Single> MulSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulSingleDouble));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulSingleDouble));
        public static Pixel<Single> Mul(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulSingleDouble));
        private struct OpMulSingleDouble : IBinaryOperator<Single, Double, Single> { public Single Operate(Single x, Double y) => (Single)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleByte));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleByte));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleByte));
        private struct OpMulDoubleByte : IBinaryOperator<Double, Byte, Double> { public Double Operate(Double x, Byte y) => (Double)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleUInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleUInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleUInt16));
        private struct OpMulDoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public Double Operate(Double x, UInt16 y) => (Double)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleUInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleUInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleUInt32));
        private struct OpMulDoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public Double Operate(Double x, UInt32 y) => (Double)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleInt16));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleInt16));
        private struct OpMulDoubleInt16 : IBinaryOperator<Double, Int16, Double> { public Double Operate(Double x, Int16 y) => (Double)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleInt32));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleInt32));
        private struct OpMulDoubleInt32 : IBinaryOperator<Double, Int32, Double> { public Double Operate(Double x, Int32 y) => (Double)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleInt64));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleInt64));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleInt64));
        private struct OpMulDoubleInt64 : IBinaryOperator<Double, Int64, Double> { public Double Operate(Double x, Int64 y) => (Double)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleSingle));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleSingle));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleSingle));
        private struct OpMulDoubleSingle : IBinaryOperator<Double, Single, Double> { public Double Operate(Double x, Single y) => (Double)(x * y); }
        public static Pixel<Double> MulSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpMulDoubleDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpMulDoubleDouble));
        public static Pixel<Double> Mul(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpMulDoubleDouble));
        private struct OpMulDoubleDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x * y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivByteByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteByte));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivByteByte));
        private struct OpDivByteByte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x / y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivByteUInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteUInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivByteUInt16));
        private struct OpDivByteUInt16 : IBinaryOperator<Byte, UInt16, Byte> { public Byte Operate(Byte x, UInt16 y) => (Byte)(x / y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivByteUInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteUInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivByteUInt32));
        private struct OpDivByteUInt32 : IBinaryOperator<Byte, UInt32, Byte> { public Byte Operate(Byte x, UInt32 y) => (Byte)(x / y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivByteInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteInt16));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivByteInt16));
        private struct OpDivByteInt16 : IBinaryOperator<Byte, Int16, Byte> { public Byte Operate(Byte x, Int16 y) => (Byte)(x / y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivByteInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteInt32));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivByteInt32));
        private struct OpDivByteInt32 : IBinaryOperator<Byte, Int32, Byte> { public Byte Operate(Byte x, Int32 y) => (Byte)(x / y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivByteInt64));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteInt64));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivByteInt64));
        private struct OpDivByteInt64 : IBinaryOperator<Byte, Int64, Byte> { public Byte Operate(Byte x, Int64 y) => (Byte)(x / y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivByteSingle));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteSingle));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivByteSingle));
        private struct OpDivByteSingle : IBinaryOperator<Byte, Single, Byte> { public Byte Operate(Byte x, Single y) => (Byte)(x / y); }
        public static Pixel<Byte> DivSelf(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivByteDouble));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivByteDouble));
        public static Pixel<Byte> Div(this Pixel<Byte> src1, Pixel<Byte> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivByteDouble));
        private struct OpDivByteDouble : IBinaryOperator<Byte, Double, Byte> { public Byte Operate(Byte x, Double y) => (Byte)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16Byte));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16Byte));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16Byte));
        private struct OpDivUInt16Byte : IBinaryOperator<UInt16, Byte, UInt16> { public UInt16 Operate(UInt16 x, Byte y) => (UInt16)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16UInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16UInt16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16UInt16));
        private struct OpDivUInt16UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16UInt32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16UInt32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16UInt32));
        private struct OpDivUInt16UInt32 : IBinaryOperator<UInt16, UInt32, UInt16> { public UInt16 Operate(UInt16 x, UInt32 y) => (UInt16)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16Int16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16Int16));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16Int16));
        private struct OpDivUInt16Int16 : IBinaryOperator<UInt16, Int16, UInt16> { public UInt16 Operate(UInt16 x, Int16 y) => (UInt16)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16Int32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16Int32));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16Int32));
        private struct OpDivUInt16Int32 : IBinaryOperator<UInt16, Int32, UInt16> { public UInt16 Operate(UInt16 x, Int32 y) => (UInt16)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16Int64));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16Int64));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16Int64));
        private struct OpDivUInt16Int64 : IBinaryOperator<UInt16, Int64, UInt16> { public UInt16 Operate(UInt16 x, Int64 y) => (UInt16)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16Single));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16Single));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16Single));
        private struct OpDivUInt16Single : IBinaryOperator<UInt16, Single, UInt16> { public UInt16 Operate(UInt16 x, Single y) => (UInt16)(x / y); }
        public static Pixel<UInt16> DivSelf(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivUInt16Double));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt16Double));
        public static Pixel<UInt16> Div(this Pixel<UInt16> src1, Pixel<UInt16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivUInt16Double));
        private struct OpDivUInt16Double : IBinaryOperator<UInt16, Double, UInt16> { public UInt16 Operate(UInt16 x, Double y) => (UInt16)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32Byte));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32Byte));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32Byte));
        private struct OpDivUInt32Byte : IBinaryOperator<UInt32, Byte, UInt32> { public UInt32 Operate(UInt32 x, Byte y) => (UInt32)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32UInt16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32UInt16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32UInt16));
        private struct OpDivUInt32UInt16 : IBinaryOperator<UInt32, UInt16, UInt32> { public UInt32 Operate(UInt32 x, UInt16 y) => (UInt32)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32UInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32UInt32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32UInt32));
        private struct OpDivUInt32UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32Int16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32Int16));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32Int16));
        private struct OpDivUInt32Int16 : IBinaryOperator<UInt32, Int16, UInt32> { public UInt32 Operate(UInt32 x, Int16 y) => (UInt32)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32Int32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32Int32));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32Int32));
        private struct OpDivUInt32Int32 : IBinaryOperator<UInt32, Int32, UInt32> { public UInt32 Operate(UInt32 x, Int32 y) => (UInt32)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32Int64));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32Int64));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32Int64));
        private struct OpDivUInt32Int64 : IBinaryOperator<UInt32, Int64, UInt32> { public UInt32 Operate(UInt32 x, Int64 y) => (UInt32)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32Single));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32Single));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32Single));
        private struct OpDivUInt32Single : IBinaryOperator<UInt32, Single, UInt32> { public UInt32 Operate(UInt32 x, Single y) => (UInt32)(x / y); }
        public static Pixel<UInt32> DivSelf(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivUInt32Double));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivUInt32Double));
        public static Pixel<UInt32> Div(this Pixel<UInt32> src1, Pixel<UInt32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivUInt32Double));
        private struct OpDivUInt32Double : IBinaryOperator<UInt32, Double, UInt32> { public UInt32 Operate(UInt32 x, Double y) => (UInt32)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivInt16Byte));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16Byte));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivInt16Byte));
        private struct OpDivInt16Byte : IBinaryOperator<Int16, Byte, Int16> { public Int16 Operate(Int16 x, Byte y) => (Int16)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivInt16UInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16UInt16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivInt16UInt16));
        private struct OpDivInt16UInt16 : IBinaryOperator<Int16, UInt16, Int16> { public Int16 Operate(Int16 x, UInt16 y) => (Int16)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivInt16UInt32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16UInt32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivInt16UInt32));
        private struct OpDivInt16UInt32 : IBinaryOperator<Int16, UInt32, Int16> { public Int16 Operate(Int16 x, UInt32 y) => (Int16)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivInt16Int16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16Int16));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivInt16Int16));
        private struct OpDivInt16Int16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivInt16Int32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16Int32));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivInt16Int32));
        private struct OpDivInt16Int32 : IBinaryOperator<Int16, Int32, Int16> { public Int16 Operate(Int16 x, Int32 y) => (Int16)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivInt16Int64));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16Int64));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivInt16Int64));
        private struct OpDivInt16Int64 : IBinaryOperator<Int16, Int64, Int16> { public Int16 Operate(Int16 x, Int64 y) => (Int16)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivInt16Single));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16Single));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivInt16Single));
        private struct OpDivInt16Single : IBinaryOperator<Int16, Single, Int16> { public Int16 Operate(Int16 x, Single y) => (Int16)(x / y); }
        public static Pixel<Int16> DivSelf(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivInt16Double));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt16Double));
        public static Pixel<Int16> Div(this Pixel<Int16> src1, Pixel<Int16> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivInt16Double));
        private struct OpDivInt16Double : IBinaryOperator<Int16, Double, Int16> { public Int16 Operate(Int16 x, Double y) => (Int16)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivInt32Byte));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32Byte));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivInt32Byte));
        private struct OpDivInt32Byte : IBinaryOperator<Int32, Byte, Int32> { public Int32 Operate(Int32 x, Byte y) => (Int32)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivInt32UInt16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32UInt16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivInt32UInt16));
        private struct OpDivInt32UInt16 : IBinaryOperator<Int32, UInt16, Int32> { public Int32 Operate(Int32 x, UInt16 y) => (Int32)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivInt32UInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32UInt32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivInt32UInt32));
        private struct OpDivInt32UInt32 : IBinaryOperator<Int32, UInt32, Int32> { public Int32 Operate(Int32 x, UInt32 y) => (Int32)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivInt32Int16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32Int16));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivInt32Int16));
        private struct OpDivInt32Int16 : IBinaryOperator<Int32, Int16, Int32> { public Int32 Operate(Int32 x, Int16 y) => (Int32)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivInt32Int32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32Int32));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivInt32Int32));
        private struct OpDivInt32Int32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivInt32Int64));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32Int64));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivInt32Int64));
        private struct OpDivInt32Int64 : IBinaryOperator<Int32, Int64, Int32> { public Int32 Operate(Int32 x, Int64 y) => (Int32)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivInt32Single));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32Single));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivInt32Single));
        private struct OpDivInt32Single : IBinaryOperator<Int32, Single, Int32> { public Int32 Operate(Int32 x, Single y) => (Int32)(x / y); }
        public static Pixel<Int32> DivSelf(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivInt32Double));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt32Double));
        public static Pixel<Int32> Div(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivInt32Double));
        private struct OpDivInt32Double : IBinaryOperator<Int32, Double, Int32> { public Int32 Operate(Int32 x, Double y) => (Int32)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivInt64Byte));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64Byte));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivInt64Byte));
        private struct OpDivInt64Byte : IBinaryOperator<Int64, Byte, Int64> { public Int64 Operate(Int64 x, Byte y) => (Int64)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivInt64UInt16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64UInt16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivInt64UInt16));
        private struct OpDivInt64UInt16 : IBinaryOperator<Int64, UInt16, Int64> { public Int64 Operate(Int64 x, UInt16 y) => (Int64)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivInt64UInt32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64UInt32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivInt64UInt32));
        private struct OpDivInt64UInt32 : IBinaryOperator<Int64, UInt32, Int64> { public Int64 Operate(Int64 x, UInt32 y) => (Int64)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivInt64Int16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64Int16));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivInt64Int16));
        private struct OpDivInt64Int16 : IBinaryOperator<Int64, Int16, Int64> { public Int64 Operate(Int64 x, Int16 y) => (Int64)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivInt64Int32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64Int32));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivInt64Int32));
        private struct OpDivInt64Int32 : IBinaryOperator<Int64, Int32, Int64> { public Int64 Operate(Int64 x, Int32 y) => (Int64)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivInt64Int64));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64Int64));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivInt64Int64));
        private struct OpDivInt64Int64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivInt64Single));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64Single));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivInt64Single));
        private struct OpDivInt64Single : IBinaryOperator<Int64, Single, Int64> { public Int64 Operate(Int64 x, Single y) => (Int64)(x / y); }
        public static Pixel<Int64> DivSelf(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivInt64Double));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivInt64Double));
        public static Pixel<Int64> Div(this Pixel<Int64> src1, Pixel<Int64> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivInt64Double));
        private struct OpDivInt64Double : IBinaryOperator<Int64, Double, Int64> { public Int64 Operate(Int64 x, Double y) => (Int64)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivSingleByte));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleByte));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivSingleByte));
        private struct OpDivSingleByte : IBinaryOperator<Single, Byte, Single> { public Single Operate(Single x, Byte y) => (Single)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivSingleUInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleUInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivSingleUInt16));
        private struct OpDivSingleUInt16 : IBinaryOperator<Single, UInt16, Single> { public Single Operate(Single x, UInt16 y) => (Single)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivSingleUInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleUInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivSingleUInt32));
        private struct OpDivSingleUInt32 : IBinaryOperator<Single, UInt32, Single> { public Single Operate(Single x, UInt32 y) => (Single)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivSingleInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleInt16));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivSingleInt16));
        private struct OpDivSingleInt16 : IBinaryOperator<Single, Int16, Single> { public Single Operate(Single x, Int16 y) => (Single)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivSingleInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleInt32));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivSingleInt32));
        private struct OpDivSingleInt32 : IBinaryOperator<Single, Int32, Single> { public Single Operate(Single x, Int32 y) => (Single)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivSingleInt64));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleInt64));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivSingleInt64));
        private struct OpDivSingleInt64 : IBinaryOperator<Single, Int64, Single> { public Single Operate(Single x, Int64 y) => (Single)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivSingleSingle));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleSingle));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivSingleSingle));
        private struct OpDivSingleSingle : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x / y); }
        public static Pixel<Single> DivSelf(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivSingleDouble));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivSingleDouble));
        public static Pixel<Single> Div(this Pixel<Single> src1, Pixel<Single> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivSingleDouble));
        private struct OpDivSingleDouble : IBinaryOperator<Single, Double, Single> { public Single Operate(Single x, Double y) => (Single)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleByte));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleByte));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleByte));
        private struct OpDivDoubleByte : IBinaryOperator<Double, Byte, Double> { public Double Operate(Double x, Byte y) => (Double)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleUInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<UInt16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleUInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt16> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleUInt16));
        private struct OpDivDoubleUInt16 : IBinaryOperator<Double, UInt16, Double> { public Double Operate(Double x, UInt16 y) => (Double)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleUInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<UInt32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleUInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<UInt32> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleUInt32));
        private struct OpDivDoubleUInt32 : IBinaryOperator<Double, UInt32, Double> { public Double Operate(Double x, UInt32 y) => (Double)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Int16> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleInt16));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int16> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleInt16));
        private struct OpDivDoubleInt16 : IBinaryOperator<Double, Int16, Double> { public Double Operate(Double x, Int16 y) => (Double)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Int32> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleInt32));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int32> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleInt32));
        private struct OpDivDoubleInt32 : IBinaryOperator<Double, Int32, Double> { public Double Operate(Double x, Int32 y) => (Double)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleInt64));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Int64> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleInt64));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Int64> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleInt64));
        private struct OpDivDoubleInt64 : IBinaryOperator<Double, Int64, Double> { public Double Operate(Double x, Int64 y) => (Double)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleSingle));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Single> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleSingle));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Single> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleSingle));
        private struct OpDivDoubleSingle : IBinaryOperator<Double, Single, Double> { public Double Operate(Double x, Single y) => (Double)(x / y); }
        public static Pixel<Double> DivSelf(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1, src2, default(OpDivDoubleDouble));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> src2) => src1.Accumulate(src1.Clone(), src2, default(OpDivDoubleDouble));
        public static Pixel<Double> Div(this Pixel<Double> src1, Pixel<Double> dst, Pixel<Double> src2) => src1.Accumulate(dst, src2, default(OpDivDoubleDouble));
        private struct OpDivDoubleDouble : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x / y); }

        
        public static Pixel<Byte> ShiftLeftSelf(this Pixel<Byte> src, int value) => src.Accumulate(src, value, default(OpShiftLeftByte));
        public static Pixel<Byte> ShiftLeft(this Pixel<Byte> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftLeftByte));
        public static Pixel<Byte> ShiftLeft(this Pixel<Byte> src, Pixel<Byte> dst, int value) => src.Accumulate(dst, value, default(OpShiftLeftByte));
        private struct OpShiftLeftByte : IBinaryOperator<Byte, int, Byte> { public Byte Operate(Byte x, int y) => (Byte)(x << y); }
        public static Pixel<UInt16> ShiftLeftSelf(this Pixel<UInt16> src, int value) => src.Accumulate(src, value, default(OpShiftLeftUInt16));
        public static Pixel<UInt16> ShiftLeft(this Pixel<UInt16> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftLeftUInt16));
        public static Pixel<UInt16> ShiftLeft(this Pixel<UInt16> src, Pixel<UInt16> dst, int value) => src.Accumulate(dst, value, default(OpShiftLeftUInt16));
        private struct OpShiftLeftUInt16 : IBinaryOperator<UInt16, int, UInt16> { public UInt16 Operate(UInt16 x, int y) => (UInt16)(x << y); }
        public static Pixel<UInt32> ShiftLeftSelf(this Pixel<UInt32> src, int value) => src.Accumulate(src, value, default(OpShiftLeftUInt32));
        public static Pixel<UInt32> ShiftLeft(this Pixel<UInt32> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftLeftUInt32));
        public static Pixel<UInt32> ShiftLeft(this Pixel<UInt32> src, Pixel<UInt32> dst, int value) => src.Accumulate(dst, value, default(OpShiftLeftUInt32));
        private struct OpShiftLeftUInt32 : IBinaryOperator<UInt32, int, UInt32> { public UInt32 Operate(UInt32 x, int y) => (UInt32)(x << y); }
        public static Pixel<UInt64> ShiftLeftSelf(this Pixel<UInt64> src, int value) => src.Accumulate(src, value, default(OpShiftLeftUInt64));
        public static Pixel<UInt64> ShiftLeft(this Pixel<UInt64> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftLeftUInt64));
        public static Pixel<UInt64> ShiftLeft(this Pixel<UInt64> src, Pixel<UInt64> dst, int value) => src.Accumulate(dst, value, default(OpShiftLeftUInt64));
        private struct OpShiftLeftUInt64 : IBinaryOperator<UInt64, int, UInt64> { public UInt64 Operate(UInt64 x, int y) => (UInt64)(x << y); }
        public static Pixel<Int16> ShiftLeftSelf(this Pixel<Int16> src, int value) => src.Accumulate(src, value, default(OpShiftLeftInt16));
        public static Pixel<Int16> ShiftLeft(this Pixel<Int16> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftLeftInt16));
        public static Pixel<Int16> ShiftLeft(this Pixel<Int16> src, Pixel<Int16> dst, int value) => src.Accumulate(dst, value, default(OpShiftLeftInt16));
        private struct OpShiftLeftInt16 : IBinaryOperator<Int16, int, Int16> { public Int16 Operate(Int16 x, int y) => (Int16)(x << y); }
        public static Pixel<Int32> ShiftLeftSelf(this Pixel<Int32> src, int value) => src.Accumulate(src, value, default(OpShiftLeftInt32));
        public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftLeftInt32));
        public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, Pixel<Int32> dst, int value) => src.Accumulate(dst, value, default(OpShiftLeftInt32));
        private struct OpShiftLeftInt32 : IBinaryOperator<Int32, int, Int32> { public Int32 Operate(Int32 x, int y) => (Int32)(x << y); }
        public static Pixel<Int64> ShiftLeftSelf(this Pixel<Int64> src, int value) => src.Accumulate(src, value, default(OpShiftLeftInt64));
        public static Pixel<Int64> ShiftLeft(this Pixel<Int64> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftLeftInt64));
        public static Pixel<Int64> ShiftLeft(this Pixel<Int64> src, Pixel<Int64> dst, int value) => src.Accumulate(dst, value, default(OpShiftLeftInt64));
        private struct OpShiftLeftInt64 : IBinaryOperator<Int64, int, Int64> { public Int64 Operate(Int64 x, int y) => (Int64)(x << y); }
        public static Pixel<Byte> ShiftRightSelf(this Pixel<Byte> src, int value) => src.Accumulate(src, value, default(OpShiftRightByte));
        public static Pixel<Byte> ShiftRight(this Pixel<Byte> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftRightByte));
        public static Pixel<Byte> ShiftRight(this Pixel<Byte> src, Pixel<Byte> dst, int value) => src.Accumulate(dst, value, default(OpShiftRightByte));
        private struct OpShiftRightByte : IBinaryOperator<Byte, int, Byte> { public Byte Operate(Byte x, int y) => (Byte)(x >> y); }
        public static Pixel<UInt16> ShiftRightSelf(this Pixel<UInt16> src, int value) => src.Accumulate(src, value, default(OpShiftRightUInt16));
        public static Pixel<UInt16> ShiftRight(this Pixel<UInt16> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftRightUInt16));
        public static Pixel<UInt16> ShiftRight(this Pixel<UInt16> src, Pixel<UInt16> dst, int value) => src.Accumulate(dst, value, default(OpShiftRightUInt16));
        private struct OpShiftRightUInt16 : IBinaryOperator<UInt16, int, UInt16> { public UInt16 Operate(UInt16 x, int y) => (UInt16)(x >> y); }
        public static Pixel<UInt32> ShiftRightSelf(this Pixel<UInt32> src, int value) => src.Accumulate(src, value, default(OpShiftRightUInt32));
        public static Pixel<UInt32> ShiftRight(this Pixel<UInt32> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftRightUInt32));
        public static Pixel<UInt32> ShiftRight(this Pixel<UInt32> src, Pixel<UInt32> dst, int value) => src.Accumulate(dst, value, default(OpShiftRightUInt32));
        private struct OpShiftRightUInt32 : IBinaryOperator<UInt32, int, UInt32> { public UInt32 Operate(UInt32 x, int y) => (UInt32)(x >> y); }
        public static Pixel<UInt64> ShiftRightSelf(this Pixel<UInt64> src, int value) => src.Accumulate(src, value, default(OpShiftRightUInt64));
        public static Pixel<UInt64> ShiftRight(this Pixel<UInt64> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftRightUInt64));
        public static Pixel<UInt64> ShiftRight(this Pixel<UInt64> src, Pixel<UInt64> dst, int value) => src.Accumulate(dst, value, default(OpShiftRightUInt64));
        private struct OpShiftRightUInt64 : IBinaryOperator<UInt64, int, UInt64> { public UInt64 Operate(UInt64 x, int y) => (UInt64)(x >> y); }
        public static Pixel<Int16> ShiftRightSelf(this Pixel<Int16> src, int value) => src.Accumulate(src, value, default(OpShiftRightInt16));
        public static Pixel<Int16> ShiftRight(this Pixel<Int16> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftRightInt16));
        public static Pixel<Int16> ShiftRight(this Pixel<Int16> src, Pixel<Int16> dst, int value) => src.Accumulate(dst, value, default(OpShiftRightInt16));
        private struct OpShiftRightInt16 : IBinaryOperator<Int16, int, Int16> { public Int16 Operate(Int16 x, int y) => (Int16)(x >> y); }
        public static Pixel<Int32> ShiftRightSelf(this Pixel<Int32> src, int value) => src.Accumulate(src, value, default(OpShiftRightInt32));
        public static Pixel<Int32> ShiftRight(this Pixel<Int32> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftRightInt32));
        public static Pixel<Int32> ShiftRight(this Pixel<Int32> src, Pixel<Int32> dst, int value) => src.Accumulate(dst, value, default(OpShiftRightInt32));
        private struct OpShiftRightInt32 : IBinaryOperator<Int32, int, Int32> { public Int32 Operate(Int32 x, int y) => (Int32)(x >> y); }
        public static Pixel<Int64> ShiftRightSelf(this Pixel<Int64> src, int value) => src.Accumulate(src, value, default(OpShiftRightInt64));
        public static Pixel<Int64> ShiftRight(this Pixel<Int64> src, int value) => src.Accumulate(src.Clone(), value, default(OpShiftRightInt64));
        public static Pixel<Int64> ShiftRight(this Pixel<Int64> src, Pixel<Int64> dst, int value) => src.Accumulate(dst, value, default(OpShiftRightInt64));
        private struct OpShiftRightInt64 : IBinaryOperator<Int64, int, Int64> { public Int64 Operate(Int64 x, int y) => (Int64)(x >> y); }


        #endregion


        //Statistical
        #region Statistical

        
        public static double Average(this Pixel<Byte> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<Byte> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<Byte> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<Byte> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<Byte> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<UInt16> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<UInt16> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<UInt16> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<UInt16> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<UInt16> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<UInt32> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<UInt32> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<UInt32> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<UInt32> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<UInt32> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<UInt64> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<UInt64> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<UInt64> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<UInt64> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<UInt64> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<Int16> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<Int16> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<Int16> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<Int16> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<Int16> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<Int32> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<Int32> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<Int32> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<Int32> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<Int32> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<Int64> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<Int64> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<Int64> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<Int64> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<Int64> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<Single> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<Single> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<Single> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<Single> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<Single> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        
        public static double Average(this Pixel<Double> src, string color)
        {
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += src[i];
            }
            return dst / src.GetCount(color);
        }
		public static double Deviation(this Pixel<Double> src, string color, double? average = null)
        {
            var ave = average ?? Average(src, color);
            double dst = 0;
            foreach (var i in src.GetIndex(color))
            {
                dst += System.Math.Pow(src[i] - ave, 2);
            }
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<Double> src, string color)
		{
            double ave = Average(src, color);
            double dev = Deviation(src, color, ave);

            return (ave, dev);
        }

		public static double[] AverageH(this Pixel<Double> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var y in src.GetIndexY(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var x in src.GetIndexX(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        public static double[] AverageV(this Pixel<Double> src, string color)
        {
            List<double> dst = new List<double>();

            foreach (var x in src.GetIndexX(color))
            {
                int c = 0;
                double hoge = 0;
                foreach (var y in src.GetIndexY(color))
                {
                    hoge += src[x + y];
                    c++;
                }
                hoge /= c;
                dst.Add(hoge);
            }

            return dst.ToArray();
        }
        

        #endregion






        //累積度数
        public static Dictionary<double,int> CumulativeFrequency<T>(this Pixel<T> src, double[] thr, string color = null) where T : struct, IComparable
        {
            var dst = new Dictionary<double, int>();

            foreach (var i in thr) dst.Add(i, 0);

            foreach (var i in src.GetIndex(color))
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
        public static int Count<T>(this Pixel<T> src, Func<T, bool> func, string color = "M") where T : struct, IComparable
        {
            int count = 0;
            foreach (var i in src.GetIndex(color))
                if (func(src[i])) count++;
            return count;
        }
        public static Dictionary<int, T> CountDic<T>(this Pixel<T> src, Func<T, bool> func, string color = "M") where T : struct, IComparable
        {
            Dictionary<int, T> dst = new Dictionary<int, T>();
            foreach (var i in src.GetIndex(color))
                if (func(src[i])) dst.Add(i, src[i]);
            return dst;
        }

        public static int Count<T>(this (Pixel<T> src1, Pixel<T> src2) src, Func<T, T, bool> func, string color = "M") where T : struct, IComparable
        {
            int count = 0;
            foreach (var i in src.src1.GetIndex(color))
                if (func(src.src1[i], src.src2[i])) count++;
            return count;
        }
        public static List<int> CountDic<T>(this (Pixel<T> src1, Pixel<T> src2) src, Func<T, T, bool> func, string color = "M") where T : struct, IComparable
        {
            List<int> dst = new List<int>();
            foreach (var i in src.src1.GetIndex(color))
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

