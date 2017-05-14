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
    }
}
