
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

#if DEBUG
namespace Pixels.Base
{
    public interface IBinaryOperator<T, TResult> { TResult Operate(T x); }
    public interface IBinaryOperator<T, T1, TResult> { TResult Operate(T x, T1 y); }
    public interface IBinaryOperator<T, T1, T2, TResult> { TResult Operate(T x, T1 y, T2 z); }
    public interface IBinaryOperator<T, T1, T2, T3, TResult> { TResult Operate(T x, T1 y, T2 z, T3 w); }

    public interface ICountOperator<T, T1, T2> { int Operate(T x, T1 y, T2 z); }

    /*Accumulate Block*/
    public partial class PixelBase<T> : Pixel<T> where T : struct, IComparable
    {
        //GetIndex : イテレータでindex。MoveNext(),Currentのメソッド呼び出しオーバーヘッドで遅い
        //structは展開されることを利用しているので...



        //loop block default
        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func, Pixel<TResult> dst) where TResult : struct, IComparable
        {
            int index = 0;
            /*_loop0{*/dst.pixel[index] = func(this.pixel[index]);/*}_loop0*/
            return dst;
        }

        public Pixel<TResult> Acc<T1, TResult>(Pixel<T1> src, Func<T, T1, TResult> func, Pixel<TResult> dst)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
        {
            int index = 0;
            /*_loop0{*/dst.pixel[index] = func(this.pixel[index], src.pixel[index]);/*}_loop0*/
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
            /*_loop0{*/dst.pixel[index] = default(TOperator).Operate(this.pixel[index]);/*}_loop0*/
            return dst;
        }

        //for BinaryOperator
        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(T1 val1, Pixel<TResult> dst)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            int index = 0;
            /*_loop0{*/dst.pixel[index] = default(TOperator).Operate(this.pixel[index], val1);/*}_loop0*/
            return dst;
        }

        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(Pixel<T1> val1, Pixel<TResult> dst)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            int index = 0;
            /*_loop0{*/dst.pixel[index] = default(TOperator).Operate(this.pixel[index], val1[index]);/*}_loop0*/
            return dst;
        }


        //for Count
        public int Count(Func<T, bool> func)
        {
            int dst = 0;
            int index = 0;
            /*_loop0{*/dst += func(this.pixel[index]) ? 1 : 0;/*}_loop0*/
            return dst;
        }
        public int Count(Func<T, bool> func, List<int> indexes, int countmax)
        {
            indexes = indexes ?? new List<int>();
            int dst = 0;
            int index = 0;
            /*_loop0{*/if (func(this.pixel[index])) { dst++; if (indexes.Count < countmax) indexes.Add(index); }/*}_loop0*/
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
            /*_loop0{*/ dst += op.Operate(this.pixel[index]); count++; /*}_loop0*/
            return dst / count;
        }
        public double Deviation<TOperator>(double average)
            where TOperator : struct, IBinaryOperator<T, double>
        {
            var op = default(TOperator);
            double dst = 0;
            int count = 0;
            int index = 0;
            /*_loop0{*/ dst += System.Math.Pow(op.Operate(this.pixel[index]) - average, 2); count++; /*}_loop0*/
            return System.Math.Sqrt(dst / count);
        }

        public (int,double) Acc(Func<T,double> func)
        {
            double dst = 0;
            int count = 0;
            int index = 0;
            /*_loop0{*/ dst += func(this.pixel[index]); count++; /*}_loop0*/

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
}
#endif