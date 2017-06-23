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
            
                typeof(T) == typeof(Byte) ? (src as Pixel<Byte>).Average<PixelOp.Op_Cast_ByteDouble>() :
            
                typeof(T) == typeof(UInt16) ? (src as Pixel<UInt16>).Average<PixelOp.Op_Cast_UInt16Double>() :
            
                typeof(T) == typeof(UInt32) ? (src as Pixel<UInt32>).Average<PixelOp.Op_Cast_UInt32Double>() :
            
                typeof(T) == typeof(UInt64) ? (src as Pixel<UInt64>).Average<PixelOp.Op_Cast_UInt64Double>() :
            
                typeof(T) == typeof(Int16) ? (src as Pixel<Int16>).Average<PixelOp.Op_Cast_Int16Double>() :
            
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Average<PixelOp.Op_Cast_Int32Double>() :
            
                typeof(T) == typeof(Int64) ? (src as Pixel<Int64>).Average<PixelOp.Op_Cast_Int64Double>() :
            
                typeof(T) == typeof(Single) ? (src as Pixel<Single>).Average<PixelOp.Op_Cast_SingleDouble>() :
            
                typeof(T) == typeof(Double) ? (src as Pixel<Double>).Average<PixelOp.Op_Cast_DoubleDouble>() :
            
                throw new Exception();

            double j =
            
                typeof(T) == typeof(Byte) ? (src as Pixel<Byte>).Deviation<PixelOp.Op_Cast_ByteDouble>(i) :
            
                typeof(T) == typeof(UInt16) ? (src as Pixel<UInt16>).Deviation<PixelOp.Op_Cast_UInt16Double>(i) :
            
                typeof(T) == typeof(UInt32) ? (src as Pixel<UInt32>).Deviation<PixelOp.Op_Cast_UInt32Double>(i) :
            
                typeof(T) == typeof(UInt64) ? (src as Pixel<UInt64>).Deviation<PixelOp.Op_Cast_UInt64Double>(i) :
            
                typeof(T) == typeof(Int16) ? (src as Pixel<Int16>).Deviation<PixelOp.Op_Cast_Int16Double>(i) :
            
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Deviation<PixelOp.Op_Cast_Int32Double>(i) :
            
                typeof(T) == typeof(Int64) ? (src as Pixel<Int64>).Deviation<PixelOp.Op_Cast_Int64Double>(i) :
            
                typeof(T) == typeof(Single) ? (src as Pixel<Single>).Deviation<PixelOp.Op_Cast_SingleDouble>(i) :
            
                typeof(T) == typeof(Double) ? (src as Pixel<Double>).Deviation<PixelOp.Op_Cast_DoubleDouble>(i) :
            
                throw new Exception();

            return (i,j);
        }
        public static (double ave, double dev) Averaget<T>(this Pixel<T> src) where T : struct, IComparable
        {
            var i =
                
                typeof(T) == typeof(Byte) ? (src as Pixel<Byte>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(UInt16) ? (src as Pixel<UInt16>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(UInt32) ? (src as Pixel<UInt32>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(UInt64) ? (src as Pixel<UInt64>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(Int16) ? (src as Pixel<Int16>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(Int64) ? (src as Pixel<Int64>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(Single) ? (src as Pixel<Single>).Acc(x=>(double)x) :
            
                typeof(T) == typeof(Double) ? (src as Pixel<Double>).Acc(x=>(double)x) :
            
                throw new Exception();

            var ave = i.Item2 / i.Item1;

            var j =
            
                typeof(T) == typeof(Byte) ? (src as Pixel<Byte>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(UInt16) ? (src as Pixel<UInt16>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(UInt32) ? (src as Pixel<UInt32>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(UInt64) ? (src as Pixel<UInt64>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(Int16) ? (src as Pixel<Int16>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(Int32) ? (src as Pixel<Int32>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(Int64) ? (src as Pixel<Int64>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(Single) ? (src as Pixel<Single>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
                typeof(T) == typeof(Double) ? (src as Pixel<Double>).Acc(x => System.Math.Pow(x - ave, 2)) :
            
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

