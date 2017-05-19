using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixels.Math
{
    public enum INEQUALITY
    {
        GreaterThan,    // >
        LessThan,       // <
        GreaterThanOrEqual,
        LessThanOrEqual,
        Equal,
        NotEqual
    }

    //ラインプロファイルの計算
    public static class LineMath
    {
        public static (double Max, double Min, double ShaMax, double ShaMin) LineStatus(this double[] src, int boxsize = 5)
        {
            double max = double.MinValue;
            double min = double.MaxValue;

            double shamax = double.MinValue;
            double shamin = double.MaxValue;

            //移動平均
            for (int i = 0; i < src.Length - boxsize; i++)
            {
                ref double hoge = ref src[i];
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
                if (max < hoge) max = hoge;
                if (min > hoge) min = hoge;
            }

            return (max, min, shamax, shamin);
        }

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
            for (int y = 0; y< src.Height; y++)
                for (int x = 0; x< src.Width; x++)
                {
                    ref var buf = ref src[x, y];
                    if(buf.CompareTo(upper) > 0) dst[x, y] = upper;
                    else if (buf.CompareTo(lower) < 0) dst[x, y] = lower;
                    else dst[x, y] = buf;
                }
                    
            return dst;
        }

        //累積度数
        public static Dictionary<double,int> CumulativeFrequency<T>(this Pixel<T> src, double[] thr) where T : struct, IComparable
        {
            //
            var dst = new Dictionary<double, int>();

            foreach (var i in thr)
                dst.Add(i, 0);

            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                {
                    double buf = (dynamic)src[x, y];
                    //ref var buf = ref src[x, y];
                    foreach (var i in thr)
                    {
                        if (buf.CompareTo(i) > 0) dst[i]++;
                        else break;
                    }
                }
            return dst;
        }

    }
}
