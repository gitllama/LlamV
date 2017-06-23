using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pixels;

        //メソッドチェーンでfunc += hogeで並べるようにする？


/*T4{[ {"Key": [".Base"], "Value": [[""]]} ]T4h*/
namespace Pixels.Math.Base
{/*}T4*/

    public static partial class PixelMath
    {
        //二値化
        public static Pixel<bool> Binarization<T>(this Pixel<T> src, Func<T, bool, bool> func, Pixel<bool> dst = null) where T : struct, IComparable
        {
            dst = dst ?? src.Clone<bool>();
            if (func == null) func = (x, y) => x.CompareTo(0) == 0;

            foreach (var i in src.GetIndex())
                dst[i] = func(src[i], dst[i]);

            return dst;
        }


        //Statistical

        public static (double ave, double dev)Average<T>(this Pixel<T> src) where T : struct, IComparable
        {
            double i =
            /*T4{[
                {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
            ]T4h*/
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Average<PixelOp.Op_Cast_Int32Double>() :
            /*}T4*/
                throw new Exception();

            double j =
            /*T4{[
                {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
            ]T4h*/
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Deviation<PixelOp.Op_Cast_Int32Double>(i) :
            /*}T4*/
                throw new Exception();

            return (i,j);
        }
        public static (double ave, double dev) Averaget<T>(this Pixel<T> src) where T : struct, IComparable
        {
            var i =
                /*T4{[
                    {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
                ]T4h*/
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Acc(x=>(double)x) :
            /*}T4*/
                throw new Exception();

            var ave = i.Item2 / i.Item1;

            var j =
            /*T4{[
                {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
            ]T4h*/
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Acc(x => System.Math.Pow(x - ave, 2)) :
            /*}T4*/
                throw new Exception();

            return (ave, System.Math.Sqrt(j.Item2 / j.Item1));
        }




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
