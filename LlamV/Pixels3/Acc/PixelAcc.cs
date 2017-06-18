
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

    public interface IBinaryOperator<T, T1, T2, TResult>
    {
        TResult Operate(T x, T1 y, T2 z);
    }
    public interface IBinaryOperator<T, T1, T2, T3, TResult>
    {
        TResult Operate(T x, T1 y, T2 z, T3 w);
    }

    public interface IBinaryOperator_<T>
    {
        void Operate(int index, ref T x);
    }
    public interface IBinaryOperator_<T, T1>
    {
        void Operate(int index, ref T x, ref T1 y);
    }
    public interface IBinaryOperator_<T, T1, T2>
    {
        void Operate(int index, ref T x, ref T1 y, ref T2 z);
    }
    public interface IBinaryOperator_<T, T1, T2, T3>
    {
        void Operate(int index, ref T x, ref T1 y, ref T2 z, ref T2 w);
    }

    public partial class PixelBase<T> : Pixel<T> where T : struct, IComparable
    {
        private (int l, int t, int c, int w, int h, int inc_col, int inc_line) utilLoop()
        {
            int l = Left;
            int t = Top;
            int c = l + t * Stride;

            int w = Width;
            int h = Height;

            int inc_col = StepX;
            int inc_line =
                Stride - w * StepX
                + Stride * (StepY - 1);

            return (l, t, c, w, h, inc_col, inc_line);
        }
        //Accumulate


        /// <summary>
        /// MoveNext(),Currentのメソッド呼び出しオーバーヘッドあるので
        /// Acc()の方が速い
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> GetIndex()
        {
            if (Map == "Full" && Color == null)
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    yield return i;
            }
            else
            {
                var hoge = utilLoop();

                int c = hoge.c;
                for (int y = 0; y < hoge.h; y++)
                { 
                    for (int x = 0; x < hoge.w; x++)
                    {
                        yield return c;
                        c += hoge.inc_col;
                    }
                    c += hoge.inc_line;
                }
            }
        }
        public IEnumerable<int> GetIndexX()
        {
            int l = Left;
            int w = Width;

            int inc_col = StepX;
            int c = l;
            for (int x = 0; x < w; x++)
            {
                yield return c;
                c += inc_col;
            }
        }
        public IEnumerable<int> GetIndexY()
        {
            int t = Top;
            int h = Height;

            int inc_line = Stride * StepY;

            int c = t * Stride;
            for (int y = 0; y < h; y++)
            {
                yield return c;
                c += inc_line;
            }
        }



        public IEnumerable<(int center, int left, int right, int top, int bottom, int lefttop, int righttop, int leftbottom, int rightbottom)>
            GetIndexPlus(string color)
        {
            int l = Left;
            int t = Top;
            int c = l + t * Stride;

            int w = Width;
            int h = Height;

            int inc_col = StepX;
            int inc_line =
                Stride - w * StepY
                + Stride * (StepY - 1);

            int line = Stride * StepY;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    yield return
                    (
                        c,
                        c - inc_col,
                        c + inc_col,
                        c - line,
                        c + line,
                        c - inc_col - line,
                        c + inc_col - line,
                        c - inc_col + line,
                        c + inc_col + line
                    );
                    c += inc_col;
                }
                c += inc_line;
            }
        }


        public Pixel<T> AccSelf(Func<T, T> func)
            => Acc(func, this);
        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func) where TResult : struct, IComparable
            => Acc(func, this.Clone<TResult>());



        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func, Pixel<TResult> dst)
            where TResult : struct, IComparable
        {
            /*loop{*/
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    f1(i);
            }
            else
            {
                for (int y = 0; y < this.Height; y++)
                    for (int x = 0; x < this.Width; x++)
                        f2(x, y);
            }
            /*}loop*/

            return dst;
            void f1(int i)
            {
                dst.pixel[i] = func(this.pixel[i]);
            }
            void f2(int x, int y)
            {
                dst[x, y] = func(this[x, y]);
            }
        }

        public Pixel<TResult> Acc<T1, TResult>(Pixel<T1> src, Func<T, T1, TResult> func, Pixel<TResult> dst)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
        {
            throw new Exception("T4");
            return dst;
            void f1(int i)
            {
                dst.pixel[i] = func(this.pixel[i], src.pixel[i]);
            }
            void f2(int x, int y)
            {
                dst[x, y] = func(this[x, y], src[x, y]);
            }
        }



        //for Cast
        public Pixel<TResult> Accumulate<TResult, TOperator>()
            where TResult : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, TResult>
        {
            var op = default(TOperator);
            var dst = this.Clone<TResult>();
            throw new Exception("T4");
            return dst;
            void f1(int i) => dst.pixel[i] = op.Operate(this.pixel[i]);
            void f2(int x, int y)
            {
                //op.Operate(ref this.pixel[i], ref dst.pixel[i]);
            }
        }

        //structは展開されることを利用しているので...
        /*
        public Pixel<TResult> Accumulate<TResult, TOperator>(Pixel<TResult> dst, TOperator op)
            where TResult : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, TResult>
        {
            for (int i = 0; i < this.pixel.Length; i++)
                op.Operate(ref this.pixel[i], ref dst.pixel[i]);
            return dst;
        }
        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(Pixel<TResult> dst, T1 value, TOperator op)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            for (int i = 0; i < this.pixel.Length; i++)
                op.Operate(ref this.pixel[i], ref value, ref dst.pixel[i]);
            return dst;
        }
        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(Pixel<TResult> dst, Pixel<T1> src1, TOperator op)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            for (int i = 0; i < this.pixel.Length; i++)
                op.Operate(ref this.pixel[i], ref src1.pixel[i], ref dst.pixel[i]);
            return dst;
        }

        public void Accumulate_<T1, TResult, TOperator>(TResult dst, T1 value, TOperator op)
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator_<T[], T1, TResult>
        {
            for (int i = 0; i < this.pixel.Length; i++)
                op.Operate(i, ref this.pixel, ref value, ref dst);
        }
        */
        /*
        public void Accumulate_<TOperator>(TOperator op) where TOperator : struct, IBinaryOperator<T[]>
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    op.Operate(i, ref this.pixel);
            }
            else
            {
                int l = Left;
                int t = Top;
                int c = l + t * Stride;

                int w = Width;
                int h = Height;

                int inc_col = StepX;
                int inc_line = Stride - w * StepX + Stride * (StepY - 1);

                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        op.Operate(c, ref this.pixel);
                        c += inc_col;
                    }
                    c += inc_line;
                }
            }
        }

        public void Accumulate_<T1, TOperator>(T1 val1, TOperator op) where TOperator : struct, IBinaryOperator<T[], T1>
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    op.Operate(i, ref this.pixel, ref val1);
            }
            else
            {
                int l = Left;
                int t = Top;
                int c = l + t * Stride;

                int w = Width;
                int h = Height;

                int inc_col = StepX;
                int inc_line = Stride - w * StepX + Stride * (StepY - 1);

                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        op.Operate(c, ref this.pixel, ref val1);
                        c += inc_col;
                    }
                    c += inc_line;
                }
            }
        }

        public void Accumulate_<T1, T2, TOperator>(T1 val1, T2 val2, TOperator op) where TOperator : struct, IBinaryOperator<T[], T1, T2>
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    op.Operate(i, ref this.pixel, ref val1);
            }
            else
            {
                int l = Left;
                int t = Top;
                int c = l + t * Stride;

                int w = Width;
                int h = Height;

                int inc_col = StepX;
                int inc_line = Stride - w * StepX + Stride * (StepY - 1);

                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        op.Operate(c, ref this.pixel, ref val1);
                        c += inc_col;
                    }
                    c += inc_line;
                }
            }
        }




        public void Accumulate_<TResult, TOperator>(TResult val1, TOperator op)
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1>
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    op.Operate(ref this[i], ref val1);
            }
            else
            {
                //for (int y = 0; y < this.Height; y++)
                //    for (int x = 0; x < this.Width; x++)
                //        op.Operate(ref i, ref src1, ref src2);
            }
            return;
        }

        public void Accumulate_<T1, TResult, TOperator>(T1 val1, TResult val2, TOperator op)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            if (this.Map == "Full")
            {

                for (int i = 0; i < this.pixel.Length; i++)
                    op.Operate(ref this[i], ref val1, ref val2);
            }
            else
            {
                //for (int y = 0; y < this.Height; y++)
                //    for (int x = 0; x < this.Width; x++)
                //        op.Operate(ref i, ref src1, ref src2);
            }
            return;
        }

*/

    }
}
#endif