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

        #region Cast

        /*T4{[
            {"Key": ["Int32"], "Value": [["Boolean"],["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
        ]T4h*/
        public static Pixel<TResult> ToPixel<TResult>(this Pixel<Int32> src) where TResult : struct, IComparable
            => ToPixel<Int32, TResult>(src);/*}T4*/

        public static Pixel<TResult> ToPixel<T1, TResult>(this Pixel<T1> src)
        where T1 : struct, IComparable
        where TResult : struct, IComparable
        {
            return
                /*T4{[
                    {"Key": ["Byte"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
                    {"Key": ["Int32"], "Value": [["Boolean"],["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
                ]T4h*/
                typeof(TResult) == typeof(Byte) && typeof(T1) == typeof(Int32) 
                    ? (src as Pixel<Int32>).Accumulate(src.Clone<Byte>(), default(Op_Cast_Int32Byte)) as Pixel<TResult> :
                /*}T4*/
                throw new FormatException($"{typeof(T1)},{typeof(TResult)}");
        }

        /*T4{[
            {"Key": ["Byte"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
            {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
        ]T4h*/
        struct Op_Cast_Int32Byte : IBinaryOperator<Int32, Byte>{ public void Operate(ref Int32 x, ref Byte y) => y = (Byte)x; }/*}T4*/

        //struct Op_Cast_Int32Byte : IBinaryOperator<Int32, Byte> { public void Operate(ref Int32 x, ref Byte y) => y = (x > Byte.MaxValue ? Byte.MaxValue : x < Byte.MinValue ? Byte.MinValue : (Byte)x); }

        /*T4{[
            {"Key": ["Byte"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
        ]T4h*/
        struct Op_Cast_BooleanByte : IBinaryOperator<Boolean, Byte> { public void Operate(ref Boolean x, ref Byte y) => y = x ? Byte.MaxValue : (Byte)0; }/*}T4*/

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
        /*T4{[
            {"Key": ["Add","(x + y)"], "Value": [["Add","(x + y)"],["Sub","(x - y)"],["Mul","(x * y)"],["Div","(x / y)"]]},
            {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
            {"Key": ["Byte"], "Value": [["Byte"],["UInt16"],["UInt32"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
        ]T4h*/
        struct Op_Add_Int32Byte : IBinaryOperator<Int32, Byte, Int32> { public void Operate(ref Int32 x, ref Byte y, ref Int32 z) => z = (Int32)(x + y); }/*}T4*/

        /*T4{[
            {"Key": ["Add","(x + y)"], "Value": [["Add","(x + y)"],["Sub","(x - y)"],["Mul","(x * y)"],["Div","(x / y)"]]},
        ]T4h*/
        struct Op_Add_UInt64UInt64 : IBinaryOperator<UInt64, UInt64, UInt64> { public void Operate(ref UInt64 x, ref UInt64 y, ref UInt64 z) => z = (x + y); }/*}T4*/

        /*T4{[
            {"Key": ["ShiftLeft","(x << y)"], "Value": [["ShiftLeft","(x << y)"],["ShiftRight","(x >> y)"]]},
            {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"]]}
        ]T4h*/
        struct Op_ShiftLeft_Int32 : IBinaryOperator<Int32, int, Int32> { public void Operate(ref Int32 x, ref int y, ref Int32 z) => z = (Int32)(x << y); }/*}T4*/



        /*T4{[
            {"Key": ["Add"], "Value": [["Add"],["Sub"],["Mul"],["Div"]]},
            {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
            {"Key": ["Byte"], "Value": [["Byte"],["UInt16"],["UInt32"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]},
        ]T4h*/
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src, Byte value) => src.Accumulate(src, value, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Byte value) => src.Accumulate(src.Clone(), value, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src, Pixel<Int32> dst, Byte value) => src.Accumulate(dst, value, default(Op_Add_Int32Byte));
        public static Pixel<Int32> AddSelf(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1, src2, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Byte> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_Int32Byte));
        public static Pixel<Int32> Add(this Pixel<Int32> src1, Pixel<Int32> dst, Pixel<Byte> src2) => src1.Accumulate(dst, src2, default(Op_Add_Int32Byte));/*}T4*/

        /*T4{[
            {"Key": ["Add"], "Value": [["Add"],["Sub"],["Mul"],["Div"]]}
        ]T4h*/
        public static Pixel<UInt64> AddSelf(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1, src2, default(Op_Add_UInt64UInt64));
        public static Pixel<UInt64> Add(this Pixel<UInt64> src1, Pixel<UInt64> src2) => src1.Accumulate(src1.Clone(), src2, default(Op_Add_UInt64UInt64));
        public static Pixel<UInt64> Add(this Pixel<UInt64> src1, Pixel<UInt64> dst, Pixel<UInt64> src2) => src1.Accumulate(dst, src2, default(Op_Add_UInt64UInt64));/*}T4*/

        /*T4{[
            {"Key": ["ShiftLeft","(x << y)"], "Value": [["ShiftLeft","(x << y)"],["ShiftRight","(x >> y)"]]},
            {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"]]}
        ]T4h*/
        public static Pixel<Int32> ShiftLeftSelf(this Pixel<Int32> src, int value) => src.Accumulate(src, value, default(Op_ShiftLeft_Int32));
        public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, int value) => src.Accumulate(src.Clone(), value, default(Op_ShiftLeft_Int32));
        public static Pixel<Int32> ShiftLeft(this Pixel<Int32> src, Pixel<Int32> dst, int value) => src.Accumulate(dst, value, default(Op_ShiftLeft_Int32));/*}T4*/

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

        /*T4{[
            {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
        ]T4h*/
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
        /*}T4*/

        /*T4{[
            {"Key": ["Int32"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
        ]T4h*/
        public static double Average2(this Pixel<Int32> src)
        {
            double dst = 0;
            //src.AccumulateIndex(ref dst, default(Op_Average_Int32));
            return dst / src.Size;
        }
        private struct Op_Average_Int32 : IBinaryOperator<Int32, double> { public void Operate(ref Int32 x, ref double y) => y += x; }/*}T4*/

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
