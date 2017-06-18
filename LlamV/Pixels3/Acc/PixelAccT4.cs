
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
    public interface IBinaryOperator<T, TResult>
    {
        TResult Operate(T x);
    }
    public interface IBinaryOperator<T, T1, TResult>
    {
        TResult Operate(T x, T1 y);
    }
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

    public partial class  Pixel<T> where T : struct, IComparable
    {
        public Pixel<T> AccSelf(Func<T, T> func) => Acc(func, this);
        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func)
            where TResult : struct, IComparable
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
            
            return dst;
            void f1(int i)
            {
                dst.pixel[i] = op.Operate(this.pixel[i]);
            }
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

        public Pixel<TResult> Accumulate<TResult, TOperator>(Pixel<TResult> dst, TOperator op)
            where TResult : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, TResult>
        {
            
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
            

            return dst;
            void f1(int i)
            {
                op.Operate(ref this.pixel[i], ref dst.pixel[i]);
            }
            void f2(int x, int y)
            {
                //op.Operate(ref this.pixel[i], ref dst.pixel[i]);
            }
        }
    }
}
