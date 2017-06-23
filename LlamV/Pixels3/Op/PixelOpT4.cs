
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

using Pixels.Stream;


namespace Pixels
{
    public interface IBinaryOperator<T, TResult> { TResult Operate(T x); }
    public interface IBinaryOperator<T, T1, TResult> { TResult Operate(T x, T1 y); }
    public interface IBinaryOperator<T, T1, T2, TResult> { TResult Operate(T x, T1 y, T2 z); }
    public interface IBinaryOperator<T, T1, T2, T3, TResult> { TResult Operate(T x, T1 y, T2 z, T3 w); }

    public interface ICountOperator<T, T1, T2> { int Operate(T x, T1 y, T2 z); }

    /*Accumulate Block*/
    public partial class  Pixel<T> where T : struct, IComparable
    {
        //GetIndex : イテレータでindex。MoveNext(),Currentのメソッド呼び出しオーバーヘッドで遅い
        //structは展開されることを利用しているので...



        //loop block default
        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func, Pixel<TResult> dst) where TResult : struct, IComparable
        {
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                    dst.pixel[index] = func(this.pixel[index]);
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            dst.pixel[index] = func(this.pixel[index]);
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst;
        }

        public Pixel<TResult> Acc<T1, TResult>(Pixel<T1> src, Func<T, T1, TResult> func, Pixel<TResult> dst)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
        {
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                    dst.pixel[index] = func(this.pixel[index], src.pixel[index]);
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            dst.pixel[index] = func(this.pixel[index], src.pixel[index]);
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst;
        }

        //loop block box
        public Pixel<TResult> Acc<T1, TResult>(List<(int x,int y)> conv, Func<T[], TResult> func, Pixel<TResult> dst)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
        {
            /*loop1{*/
            if (this.Map == "Full" && this.Color == null)
            {
                var buf = conv.Select(x => this.ConvPoison(x.x, x.y) - this.ConvPoison(0, 0)).ToArray();
                var buf2 = new T[buf.Length];
                for (int i = 0; i < this.pixel.Length; i++)
                {
                    int k = 0;
                    foreach(var n in buf)
                    {
                        buf2[k++] = this[n + i];
                    }
                    f(i, buf2);
                }    
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var buf = conv.Select(x => this.ConvPoison(x.x, x.y) - this.ConvPoison(0, 0)).ToArray();
                    var buf2 = new T[buf.Length];

                    var hoge = utilLoop();
                    int i = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            int k = 0;
                            foreach (var n in buf)
                            {
                                buf2[k++] = this[n + i];
                            }
                            f(i, buf2);
                            i += hoge.inc_col;
                        }
                        i += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            /*}loop1*/
            return dst;
            void f(int i, T[] box) => dst.pixel[i] = func(box);
        }

        //for Cast
        public Pixel<TResult> Accumulate<TResult, TOperator>(Pixel<TResult> dst)
            where TResult : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, TResult>
        {
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                    dst.pixel[index] = default(TOperator).Operate(this.pixel[index]);
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            dst.pixel[index] = default(TOperator).Operate(this.pixel[index]);
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst;
        }

        //for BinaryOperator
        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(T1 val1, Pixel<TResult> dst)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                    dst.pixel[index] = default(TOperator).Operate(this.pixel[index], val1);
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            dst.pixel[index] = default(TOperator).Operate(this.pixel[index], val1);
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst;
        }

        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(Pixel<T1> val1, Pixel<TResult> dst)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                    dst.pixel[index] = default(TOperator).Operate(this.pixel[index], val1[index]);
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            dst.pixel[index] = default(TOperator).Operate(this.pixel[index], val1[index]);
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst;
        }


        //for Count
        public int Count(Func<T, bool> func)
        {
            int dst = 0;
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                    dst += func(this.pixel[index]) ? 1 : 0;
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            dst += func(this.pixel[index]) ? 1 : 0;
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst;
        }
        public int Count(Func<T, bool> func, List<int> indexes, int countmax)
        {
            indexes = indexes ?? new List<int>();
            int dst = 0;
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                    if (func(this.pixel[index])) { dst++; if (indexes.Count < countmax) indexes.Add(index); }
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                            if (func(this.pixel[index])) { dst++; if (indexes.Count < countmax) indexes.Add(index); }
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst;
        }
        public int Count(List<(int x, int y)> conv, Func<T[], bool> func)
        {
            int dst = 0;
            throw new Exception("loop1");
            return dst;
            void f(int i, T[] box) => dst += func(box) ? 1 : 0; ;
        }

        public List<int> CountList(List<(int x, int y)> conv, Func<T[], bool> func)
        {
            List<int> dst = new List<int>();
            throw new Exception("loop1");
            return dst;
            void f(int i, T[] box)
            {
                if (func(box)) dst.Add(i);    
            }
        }


        //for Statistical

        //デリゲート扱いなのでおそい
        public double Average<TOperator>()
            where TOperator : struct, IBinaryOperator<T, double>
        {
            var op = default(TOperator);
            double dst = 0;
            int count = 0;
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                     dst += op.Operate(this.pixel[index]); count++; 
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                             dst += op.Operate(this.pixel[index]); count++; 
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return dst / count;
        }
        public double Deviation<TOperator>(double average)
            where TOperator : struct, IBinaryOperator<T, double>
        {
            var op = default(TOperator);
            double dst = 0;
            int count = 0;
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                     dst += System.Math.Pow(op.Operate(this.pixel[index]) - average, 2); count++; 
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                             dst += System.Math.Pow(op.Operate(this.pixel[index]) - average, 2); count++; 
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            
            return System.Math.Sqrt(dst / count);
        }

        public (int,double) Acc(Func<T,double> func)
        {
            double dst = 0;
            int count = 0;
            int index = 0;
            
            if (Map == "Full" && Color == null)
            {
                for (index = 0; index < this.pixel.Length; index++)
                {
                     dst += func(this.pixel[index]); count++; 
                }
            }
            else
            {
                var hogehoge = Color ?? new string[] { "Flat" };
                foreach (var c in hogehoge)
                {
                    if (c == "Flat") SetMap(Map, null);
                    else SetMap(Map, c);

                    var hoge = utilLoop();
                    index = hoge.c;
                    for (int y = 0; y < hoge.h; y++)
                    {
                        for (int x = 0; x < hoge.w; x++)
                        {
                             dst += func(this.pixel[index]); count++; 
                            index += hoge.inc_col;
                        }
                        index += hoge.inc_line;
                    }
                }
                //あとしまつ
                if (Color != null) SetMap(Map, Color[0]);
            }
            

            return (count,dst);
        }





        public Pixel<T> AccSelf(Func<T, T> func)
    => Acc(func, this);
        public Pixel<T> Acc(Func<T, T> func)
            => Acc(func, this.Clone());
        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func)
            where TResult : struct, IComparable
            => Acc(func, this.Clone<TResult>());

        public Pixel<T> AccSelf<T1>(Pixel<T1> src, Func<T, T1, T> func)
            where T1 : struct, IComparable
            => Acc<T1, T>(src, func, this);
        public Pixel<TResult> Acc<T1, TResult>(Pixel<T1> src, Func<T, T1, TResult> func)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
            => Acc<T1, TResult>(src, func, this.Clone<TResult>());
    }
    /*
    public static class PixelAcc
    {
        public static Pixel<T> Acc<T>(this Pixel<T> src, Func<T, T> func)
            where T : struct, IComparable
            => Acc(src, func, src.Clone());
        public static Pixel<TResult> Acc<T, TResult>(this Pixel<T> src, Func<T, TResult> func, Pixel<TResult> dst = null)
            where T : struct, IComparable
            where TResult : struct, IComparable
        {
            dst = dst ?? src.Clone<TResult>();
            throw new Exception("T4");
            return dst;
            void f(int i) => dst.pixel[i] = func(src.pixel[i]);
        }
        public static Pixel<T1> Acc<T1, T2>(this (Pixel<T1> x, Pixel<T2> y) src, Func<T1, T2, T1> func)
            where T1 : struct, IComparable
            where T2 : struct, IComparable
            => Acc(src, func, src.x.Clone());
        public static Pixel<TResult> Acc<T1, T2, TResult>(this (Pixel<T1> x, Pixel<T2> y) src, Func<T1,T2, TResult> func, Pixel<TResult> dst = null)
            where T1 : struct, IComparable
            where T2 : struct, IComparable
            where TResult : struct, IComparable
        {
            dst = dst ?? src.x.Clone<TResult>();

            throw new Exception("T4");
            return dst;
            void f(int i) => dst.pixel[i] = func(src.x.pixel[i], src.y.pixel[i]);
        }
    }
    */


	public static class PixelOp
	{




		public struct Op_Cast_DoubleDouble : IBinaryOperator<Double, Double> { public Double Operate(Double x) => (Double)x; }
		public struct Op_Cast_SingleDouble : IBinaryOperator<Single, Double> { public Double Operate(Single x) => (Double)x; }
		public struct Op_Cast_Int64Double : IBinaryOperator<Int64, Double> { public Double Operate(Int64 x) => (Double)x; }
		public struct Op_Cast_Int32Double : IBinaryOperator<Int32, Double> { public Double Operate(Int32 x) => (Double)x; }
		public struct Op_Cast_Int16Double : IBinaryOperator<Int16, Double> { public Double Operate(Int16 x) => (Double)x; }
		public struct Op_Cast_UInt64Double : IBinaryOperator<UInt64, Double> { public Double Operate(UInt64 x) => (Double)x; }
		public struct Op_Cast_UInt32Double : IBinaryOperator<UInt32, Double> { public Double Operate(UInt32 x) => (Double)x; }
		public struct Op_Cast_UInt16Double : IBinaryOperator<UInt16, Double> { public Double Operate(UInt16 x) => (Double)x; }
		public struct Op_Cast_ByteDouble : IBinaryOperator<Byte, Double> { public Double Operate(Byte x) => (Double)x; }
		public struct Op_Cast_DoubleSingle : IBinaryOperator<Double, Single> { public Single Operate(Double x) => (Single)x; }
		public struct Op_Cast_SingleSingle : IBinaryOperator<Single, Single> { public Single Operate(Single x) => (Single)x; }
		public struct Op_Cast_Int64Single : IBinaryOperator<Int64, Single> { public Single Operate(Int64 x) => (Single)x; }
		public struct Op_Cast_Int32Single : IBinaryOperator<Int32, Single> { public Single Operate(Int32 x) => (Single)x; }
		public struct Op_Cast_Int16Single : IBinaryOperator<Int16, Single> { public Single Operate(Int16 x) => (Single)x; }
		public struct Op_Cast_UInt64Single : IBinaryOperator<UInt64, Single> { public Single Operate(UInt64 x) => (Single)x; }
		public struct Op_Cast_UInt32Single : IBinaryOperator<UInt32, Single> { public Single Operate(UInt32 x) => (Single)x; }
		public struct Op_Cast_UInt16Single : IBinaryOperator<UInt16, Single> { public Single Operate(UInt16 x) => (Single)x; }
		public struct Op_Cast_ByteSingle : IBinaryOperator<Byte, Single> { public Single Operate(Byte x) => (Single)x; }
		public struct Op_Cast_DoubleInt64 : IBinaryOperator<Double, Int64> { public Int64 Operate(Double x) => (Int64)x; }
		public struct Op_Cast_SingleInt64 : IBinaryOperator<Single, Int64> { public Int64 Operate(Single x) => (Int64)x; }
		public struct Op_Cast_Int64Int64 : IBinaryOperator<Int64, Int64> { public Int64 Operate(Int64 x) => (Int64)x; }
		public struct Op_Cast_Int32Int64 : IBinaryOperator<Int32, Int64> { public Int64 Operate(Int32 x) => (Int64)x; }
		public struct Op_Cast_Int16Int64 : IBinaryOperator<Int16, Int64> { public Int64 Operate(Int16 x) => (Int64)x; }
		public struct Op_Cast_UInt64Int64 : IBinaryOperator<UInt64, Int64> { public Int64 Operate(UInt64 x) => (Int64)x; }
		public struct Op_Cast_UInt32Int64 : IBinaryOperator<UInt32, Int64> { public Int64 Operate(UInt32 x) => (Int64)x; }
		public struct Op_Cast_UInt16Int64 : IBinaryOperator<UInt16, Int64> { public Int64 Operate(UInt16 x) => (Int64)x; }
		public struct Op_Cast_ByteInt64 : IBinaryOperator<Byte, Int64> { public Int64 Operate(Byte x) => (Int64)x; }
		public struct Op_Cast_DoubleInt32 : IBinaryOperator<Double, Int32> { public Int32 Operate(Double x) => (Int32)x; }
		public struct Op_Cast_SingleInt32 : IBinaryOperator<Single, Int32> { public Int32 Operate(Single x) => (Int32)x; }
		public struct Op_Cast_Int64Int32 : IBinaryOperator<Int64, Int32> { public Int32 Operate(Int64 x) => (Int32)x; }
		public struct Op_Cast_Int32Int32 : IBinaryOperator<Int32, Int32> { public Int32 Operate(Int32 x) => (Int32)x; }
		public struct Op_Cast_Int16Int32 : IBinaryOperator<Int16, Int32> { public Int32 Operate(Int16 x) => (Int32)x; }
		public struct Op_Cast_UInt64Int32 : IBinaryOperator<UInt64, Int32> { public Int32 Operate(UInt64 x) => (Int32)x; }
		public struct Op_Cast_UInt32Int32 : IBinaryOperator<UInt32, Int32> { public Int32 Operate(UInt32 x) => (Int32)x; }
		public struct Op_Cast_UInt16Int32 : IBinaryOperator<UInt16, Int32> { public Int32 Operate(UInt16 x) => (Int32)x; }
		public struct Op_Cast_ByteInt32 : IBinaryOperator<Byte, Int32> { public Int32 Operate(Byte x) => (Int32)x; }
		public struct Op_Cast_DoubleInt16 : IBinaryOperator<Double, Int16> { public Int16 Operate(Double x) => (Int16)x; }
		public struct Op_Cast_SingleInt16 : IBinaryOperator<Single, Int16> { public Int16 Operate(Single x) => (Int16)x; }
		public struct Op_Cast_Int64Int16 : IBinaryOperator<Int64, Int16> { public Int16 Operate(Int64 x) => (Int16)x; }
		public struct Op_Cast_Int32Int16 : IBinaryOperator<Int32, Int16> { public Int16 Operate(Int32 x) => (Int16)x; }
		public struct Op_Cast_Int16Int16 : IBinaryOperator<Int16, Int16> { public Int16 Operate(Int16 x) => (Int16)x; }
		public struct Op_Cast_UInt64Int16 : IBinaryOperator<UInt64, Int16> { public Int16 Operate(UInt64 x) => (Int16)x; }
		public struct Op_Cast_UInt32Int16 : IBinaryOperator<UInt32, Int16> { public Int16 Operate(UInt32 x) => (Int16)x; }
		public struct Op_Cast_UInt16Int16 : IBinaryOperator<UInt16, Int16> { public Int16 Operate(UInt16 x) => (Int16)x; }
		public struct Op_Cast_ByteInt16 : IBinaryOperator<Byte, Int16> { public Int16 Operate(Byte x) => (Int16)x; }
		public struct Op_Cast_DoubleUInt64 : IBinaryOperator<Double, UInt64> { public UInt64 Operate(Double x) => (UInt64)x; }
		public struct Op_Cast_SingleUInt64 : IBinaryOperator<Single, UInt64> { public UInt64 Operate(Single x) => (UInt64)x; }
		public struct Op_Cast_Int64UInt64 : IBinaryOperator<Int64, UInt64> { public UInt64 Operate(Int64 x) => (UInt64)x; }
		public struct Op_Cast_Int32UInt64 : IBinaryOperator<Int32, UInt64> { public UInt64 Operate(Int32 x) => (UInt64)x; }
		public struct Op_Cast_Int16UInt64 : IBinaryOperator<Int16, UInt64> { public UInt64 Operate(Int16 x) => (UInt64)x; }
		public struct Op_Cast_UInt64UInt64 : IBinaryOperator<UInt64, UInt64> { public UInt64 Operate(UInt64 x) => (UInt64)x; }
		public struct Op_Cast_UInt32UInt64 : IBinaryOperator<UInt32, UInt64> { public UInt64 Operate(UInt32 x) => (UInt64)x; }
		public struct Op_Cast_UInt16UInt64 : IBinaryOperator<UInt16, UInt64> { public UInt64 Operate(UInt16 x) => (UInt64)x; }
		public struct Op_Cast_ByteUInt64 : IBinaryOperator<Byte, UInt64> { public UInt64 Operate(Byte x) => (UInt64)x; }
		public struct Op_Cast_DoubleUInt32 : IBinaryOperator<Double, UInt32> { public UInt32 Operate(Double x) => (UInt32)x; }
		public struct Op_Cast_SingleUInt32 : IBinaryOperator<Single, UInt32> { public UInt32 Operate(Single x) => (UInt32)x; }
		public struct Op_Cast_Int64UInt32 : IBinaryOperator<Int64, UInt32> { public UInt32 Operate(Int64 x) => (UInt32)x; }
		public struct Op_Cast_Int32UInt32 : IBinaryOperator<Int32, UInt32> { public UInt32 Operate(Int32 x) => (UInt32)x; }
		public struct Op_Cast_Int16UInt32 : IBinaryOperator<Int16, UInt32> { public UInt32 Operate(Int16 x) => (UInt32)x; }
		public struct Op_Cast_UInt64UInt32 : IBinaryOperator<UInt64, UInt32> { public UInt32 Operate(UInt64 x) => (UInt32)x; }
		public struct Op_Cast_UInt32UInt32 : IBinaryOperator<UInt32, UInt32> { public UInt32 Operate(UInt32 x) => (UInt32)x; }
		public struct Op_Cast_UInt16UInt32 : IBinaryOperator<UInt16, UInt32> { public UInt32 Operate(UInt16 x) => (UInt32)x; }
		public struct Op_Cast_ByteUInt32 : IBinaryOperator<Byte, UInt32> { public UInt32 Operate(Byte x) => (UInt32)x; }
		public struct Op_Cast_DoubleUInt16 : IBinaryOperator<Double, UInt16> { public UInt16 Operate(Double x) => (UInt16)x; }
		public struct Op_Cast_SingleUInt16 : IBinaryOperator<Single, UInt16> { public UInt16 Operate(Single x) => (UInt16)x; }
		public struct Op_Cast_Int64UInt16 : IBinaryOperator<Int64, UInt16> { public UInt16 Operate(Int64 x) => (UInt16)x; }
		public struct Op_Cast_Int32UInt16 : IBinaryOperator<Int32, UInt16> { public UInt16 Operate(Int32 x) => (UInt16)x; }
		public struct Op_Cast_Int16UInt16 : IBinaryOperator<Int16, UInt16> { public UInt16 Operate(Int16 x) => (UInt16)x; }
		public struct Op_Cast_UInt64UInt16 : IBinaryOperator<UInt64, UInt16> { public UInt16 Operate(UInt64 x) => (UInt16)x; }
		public struct Op_Cast_UInt32UInt16 : IBinaryOperator<UInt32, UInt16> { public UInt16 Operate(UInt32 x) => (UInt16)x; }
		public struct Op_Cast_UInt16UInt16 : IBinaryOperator<UInt16, UInt16> { public UInt16 Operate(UInt16 x) => (UInt16)x; }
		public struct Op_Cast_ByteUInt16 : IBinaryOperator<Byte, UInt16> { public UInt16 Operate(Byte x) => (UInt16)x; }
		public struct Op_Cast_DoubleByte : IBinaryOperator<Double, Byte> { public Byte Operate(Double x) => (Byte)x; }
		public struct Op_Cast_SingleByte : IBinaryOperator<Single, Byte> { public Byte Operate(Single x) => (Byte)x; }
		public struct Op_Cast_Int64Byte : IBinaryOperator<Int64, Byte> { public Byte Operate(Int64 x) => (Byte)x; }
		public struct Op_Cast_Int32Byte : IBinaryOperator<Int32, Byte> { public Byte Operate(Int32 x) => (Byte)x; }
		public struct Op_Cast_Int16Byte : IBinaryOperator<Int16, Byte> { public Byte Operate(Int16 x) => (Byte)x; }
		public struct Op_Cast_UInt64Byte : IBinaryOperator<UInt64, Byte> { public Byte Operate(UInt64 x) => (Byte)x; }
		public struct Op_Cast_UInt32Byte : IBinaryOperator<UInt32, Byte> { public Byte Operate(UInt32 x) => (Byte)x; }
		public struct Op_Cast_UInt16Byte : IBinaryOperator<UInt16, Byte> { public Byte Operate(UInt16 x) => (Byte)x; }
		public struct Op_Cast_ByteByte : IBinaryOperator<Byte, Byte> { public Byte Operate(Byte x) => (Byte)x; }
		public struct Op_Cast_BooleanDouble : IBinaryOperator<Boolean, Double> { public Double Operate(Boolean x) => x ? Double.MaxValue: Double.MinValue; }
		public struct Op_Cast_BooleanSingle : IBinaryOperator<Boolean, Single> { public Single Operate(Boolean x) => x ? Single.MaxValue: Single.MinValue; }
		public struct Op_Cast_BooleanInt64 : IBinaryOperator<Boolean, Int64> { public Int64 Operate(Boolean x) => x ? Int64.MaxValue: Int64.MinValue; }
		public struct Op_Cast_BooleanInt32 : IBinaryOperator<Boolean, Int32> { public Int32 Operate(Boolean x) => x ? Int32.MaxValue: Int32.MinValue; }
		public struct Op_Cast_BooleanInt16 : IBinaryOperator<Boolean, Int16> { public Int16 Operate(Boolean x) => x ? Int16.MaxValue: Int16.MinValue; }
		public struct Op_Cast_BooleanUInt64 : IBinaryOperator<Boolean, UInt64> { public UInt64 Operate(Boolean x) => x ? UInt64.MaxValue: UInt64.MinValue; }
		public struct Op_Cast_BooleanUInt32 : IBinaryOperator<Boolean, UInt32> { public UInt32 Operate(Boolean x) => x ? UInt32.MaxValue: UInt32.MinValue; }
		public struct Op_Cast_BooleanUInt16 : IBinaryOperator<Boolean, UInt16> { public UInt16 Operate(Boolean x) => x ? UInt16.MaxValue: UInt16.MinValue; }
		public struct Op_Cast_BooleanByte : IBinaryOperator<Boolean, Byte> { public Byte Operate(Boolean x) => x ? Byte.MaxValue: Byte.MinValue; }
	}


	/*Op Block*/
    public partial class Pixel<T>
    {
		//明示キャスト
		public static explicit operator Pixel<Double>(Pixel<T> x)
		{
            Pixel<Double> dst = x.Clone<Double>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Double, PixelOp.Op_Cast_DoubleDouble>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Double, PixelOp.Op_Cast_SingleDouble>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Double, PixelOp.Op_Cast_Int64Double>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Double, PixelOp.Op_Cast_Int32Double>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Double, PixelOp.Op_Cast_Int16Double>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<Double, PixelOp.Op_Cast_UInt64Double>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<Double, PixelOp.Op_Cast_UInt32Double>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<Double, PixelOp.Op_Cast_UInt16Double>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Double, PixelOp.Op_Cast_ByteDouble>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<Double, PixelOp.Op_Cast_BooleanDouble>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<Single>(Pixel<T> x)
		{
            Pixel<Single> dst = x.Clone<Single>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Single, PixelOp.Op_Cast_DoubleSingle>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Single, PixelOp.Op_Cast_SingleSingle>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Single, PixelOp.Op_Cast_Int64Single>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Single, PixelOp.Op_Cast_Int32Single>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Single, PixelOp.Op_Cast_Int16Single>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<Single, PixelOp.Op_Cast_UInt64Single>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<Single, PixelOp.Op_Cast_UInt32Single>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<Single, PixelOp.Op_Cast_UInt16Single>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Single, PixelOp.Op_Cast_ByteSingle>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<Single, PixelOp.Op_Cast_BooleanSingle>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<Int64>(Pixel<T> x)
		{
            Pixel<Int64> dst = x.Clone<Int64>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Int64, PixelOp.Op_Cast_DoubleInt64>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Int64, PixelOp.Op_Cast_SingleInt64>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Int64, PixelOp.Op_Cast_Int64Int64>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Int64, PixelOp.Op_Cast_Int32Int64>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Int64, PixelOp.Op_Cast_Int16Int64>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<Int64, PixelOp.Op_Cast_UInt64Int64>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<Int64, PixelOp.Op_Cast_UInt32Int64>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<Int64, PixelOp.Op_Cast_UInt16Int64>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Int64, PixelOp.Op_Cast_ByteInt64>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<Int64, PixelOp.Op_Cast_BooleanInt64>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<Int32>(Pixel<T> x)
		{
            Pixel<Int32> dst = x.Clone<Int32>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Int32, PixelOp.Op_Cast_DoubleInt32>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Int32, PixelOp.Op_Cast_SingleInt32>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Int32, PixelOp.Op_Cast_Int64Int32>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Int32, PixelOp.Op_Cast_Int32Int32>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Int32, PixelOp.Op_Cast_Int16Int32>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<Int32, PixelOp.Op_Cast_UInt64Int32>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<Int32, PixelOp.Op_Cast_UInt32Int32>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<Int32, PixelOp.Op_Cast_UInt16Int32>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Int32, PixelOp.Op_Cast_ByteInt32>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<Int32, PixelOp.Op_Cast_BooleanInt32>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<Int16>(Pixel<T> x)
		{
            Pixel<Int16> dst = x.Clone<Int16>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Int16, PixelOp.Op_Cast_DoubleInt16>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Int16, PixelOp.Op_Cast_SingleInt16>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Int16, PixelOp.Op_Cast_Int64Int16>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Int16, PixelOp.Op_Cast_Int32Int16>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Int16, PixelOp.Op_Cast_Int16Int16>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<Int16, PixelOp.Op_Cast_UInt64Int16>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<Int16, PixelOp.Op_Cast_UInt32Int16>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<Int16, PixelOp.Op_Cast_UInt16Int16>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Int16, PixelOp.Op_Cast_ByteInt16>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<Int16, PixelOp.Op_Cast_BooleanInt16>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<UInt64>(Pixel<T> x)
		{
            Pixel<UInt64> dst = x.Clone<UInt64>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<UInt64, PixelOp.Op_Cast_DoubleUInt64>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<UInt64, PixelOp.Op_Cast_SingleUInt64>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<UInt64, PixelOp.Op_Cast_Int64UInt64>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<UInt64, PixelOp.Op_Cast_Int32UInt64>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<UInt64, PixelOp.Op_Cast_Int16UInt64>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<UInt64, PixelOp.Op_Cast_UInt64UInt64>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<UInt64, PixelOp.Op_Cast_UInt32UInt64>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<UInt64, PixelOp.Op_Cast_UInt16UInt64>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<UInt64, PixelOp.Op_Cast_ByteUInt64>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<UInt64, PixelOp.Op_Cast_BooleanUInt64>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<UInt32>(Pixel<T> x)
		{
            Pixel<UInt32> dst = x.Clone<UInt32>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<UInt32, PixelOp.Op_Cast_DoubleUInt32>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<UInt32, PixelOp.Op_Cast_SingleUInt32>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<UInt32, PixelOp.Op_Cast_Int64UInt32>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<UInt32, PixelOp.Op_Cast_Int32UInt32>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<UInt32, PixelOp.Op_Cast_Int16UInt32>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<UInt32, PixelOp.Op_Cast_UInt64UInt32>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<UInt32, PixelOp.Op_Cast_UInt32UInt32>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<UInt32, PixelOp.Op_Cast_UInt16UInt32>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<UInt32, PixelOp.Op_Cast_ByteUInt32>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<UInt32, PixelOp.Op_Cast_BooleanUInt32>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<UInt16>(Pixel<T> x)
		{
            Pixel<UInt16> dst = x.Clone<UInt16>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<UInt16, PixelOp.Op_Cast_DoubleUInt16>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<UInt16, PixelOp.Op_Cast_SingleUInt16>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<UInt16, PixelOp.Op_Cast_Int64UInt16>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<UInt16, PixelOp.Op_Cast_Int32UInt16>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<UInt16, PixelOp.Op_Cast_Int16UInt16>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<UInt16, PixelOp.Op_Cast_UInt64UInt16>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<UInt16, PixelOp.Op_Cast_UInt32UInt16>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<UInt16, PixelOp.Op_Cast_UInt16UInt16>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<UInt16, PixelOp.Op_Cast_ByteUInt16>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<UInt16, PixelOp.Op_Cast_BooleanUInt16>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static explicit operator Pixel<Byte>(Pixel<T> x)
		{
            Pixel<Byte> dst = x.Clone<Byte>();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Byte, PixelOp.Op_Cast_DoubleByte>(dst);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Byte, PixelOp.Op_Cast_SingleByte>(dst);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Byte, PixelOp.Op_Cast_Int64Byte>(dst);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Byte, PixelOp.Op_Cast_Int32Byte>(dst);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Byte, PixelOp.Op_Cast_Int16Byte>(dst);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<Byte, PixelOp.Op_Cast_UInt64Byte>(dst);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<Byte, PixelOp.Op_Cast_UInt32Byte>(dst);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<Byte, PixelOp.Op_Cast_UInt16Byte>(dst);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Byte, PixelOp.Op_Cast_ByteByte>(dst);
			else if(typeof(T) == typeof(Boolean))(x as Pixel<Boolean>).Accumulate<Byte, PixelOp.Op_Cast_BooleanByte>(dst);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}




		public static Pixel<T> operator+ (Pixel<T> x, T y)
		{
			var dst = x.Clone();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Double, Double, Op_Add_Double>((Double)(object)y, dst as Pixel<Double>);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Single, Single, Op_Add_Single>((Single)(object)y, dst as Pixel<Single>);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Int64, Int64, Op_Add_Int64>((Int64)(object)y, dst as Pixel<Int64>);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Int32, Int32, Op_Add_Int32>((Int32)(object)y, dst as Pixel<Int32>);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Int16, Int16, Op_Add_Int16>((Int16)(object)y, dst as Pixel<Int16>);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<UInt64, UInt64, Op_Add_UInt64>((UInt64)(object)y, dst as Pixel<UInt64>);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<UInt32, UInt32, Op_Add_UInt32>((UInt32)(object)y, dst as Pixel<UInt32>);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<UInt16, UInt16, Op_Add_UInt16>((UInt16)(object)y, dst as Pixel<UInt16>);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Byte, Byte, Op_Add_Byte>((Byte)(object)y, dst as Pixel<Byte>);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}
		public static Pixel<T> operator+ (Pixel<T> x, Pixel<T> y)
		{
			var dst = x.Clone();
			if(x == null) throw new ArithmeticException();
			else if(typeof(T) == typeof(Double)) (x as Pixel<Double>).Accumulate<Double, Double, Op_Add_Double>(y as Pixel<Double>, dst as Pixel<Double>);
			else if(typeof(T) == typeof(Single)) (x as Pixel<Single>).Accumulate<Single, Single, Op_Add_Single>(y as Pixel<Single>, dst as Pixel<Single>);
			else if(typeof(T) == typeof(Int64)) (x as Pixel<Int64>).Accumulate<Int64, Int64, Op_Add_Int64>(y as Pixel<Int64>, dst as Pixel<Int64>);
			else if(typeof(T) == typeof(Int32)) (x as Pixel<Int32>).Accumulate<Int32, Int32, Op_Add_Int32>(y as Pixel<Int32>, dst as Pixel<Int32>);
			else if(typeof(T) == typeof(Int16)) (x as Pixel<Int16>).Accumulate<Int16, Int16, Op_Add_Int16>(y as Pixel<Int16>, dst as Pixel<Int16>);
			else if(typeof(T) == typeof(UInt64)) (x as Pixel<UInt64>).Accumulate<UInt64, UInt64, Op_Add_UInt64>(y as Pixel<UInt64>, dst as Pixel<UInt64>);
			else if(typeof(T) == typeof(UInt32)) (x as Pixel<UInt32>).Accumulate<UInt32, UInt32, Op_Add_UInt32>(y as Pixel<UInt32>, dst as Pixel<UInt32>);
			else if(typeof(T) == typeof(UInt16)) (x as Pixel<UInt16>).Accumulate<UInt16, UInt16, Op_Add_UInt16>(y as Pixel<UInt16>, dst as Pixel<UInt16>);
			else if(typeof(T) == typeof(Byte)) (x as Pixel<Byte>).Accumulate<Byte, Byte, Op_Add_Byte>(y as Pixel<Byte>, dst as Pixel<Byte>);
			else dst = null;
			return dst ?? throw new InvalidCastException();
		}

		public struct Op_Add_Double : IBinaryOperator<Double, Double, Double> { public Double Operate(Double x, Double y) => (Double)(x + y); }
		public struct Op_Add_Single : IBinaryOperator<Single, Single, Single> { public Single Operate(Single x, Single y) => (Single)(x + y); }
		public struct Op_Add_Int64 : IBinaryOperator<Int64, Int64, Int64> { public Int64 Operate(Int64 x, Int64 y) => (Int64)(x + y); }
		public struct Op_Add_Int32 : IBinaryOperator<Int32, Int32, Int32> { public Int32 Operate(Int32 x, Int32 y) => (Int32)(x + y); }
		public struct Op_Add_Int16 : IBinaryOperator<Int16, Int16, Int16> { public Int16 Operate(Int16 x, Int16 y) => (Int16)(x + y); }
		public struct Op_Add_UInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public UInt64 Operate(UInt64 x, UInt64 y) => (UInt64)(x + y); }
		public struct Op_Add_UInt32 : IBinaryOperator<UInt32, UInt32, UInt32> { public UInt32 Operate(UInt32 x, UInt32 y) => (UInt32)(x + y); }
		public struct Op_Add_UInt16 : IBinaryOperator<UInt16, UInt16, UInt16> { public UInt16 Operate(UInt16 x, UInt16 y) => (UInt16)(x + y); }
		public struct Op_Add_Byte : IBinaryOperator<Byte, Byte, Byte> { public Byte Operate(Byte x, Byte y) => (Byte)(x + y); }


    }
}