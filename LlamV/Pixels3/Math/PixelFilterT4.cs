using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pixels.Math
{

    public static partial class PixelFilter
    {
        //スタッガー

        public static Pixel<T> Stagger<T>(this Pixel<T> src, Pixel<T> dst, int val = 1) where T : struct, IComparable
        {
            if(val > 0)
            {
                for (int y = 1; y < src.Height; y += 2)
                    for (int x = 0; x < src.Width - val; x++)
                        dst[x, y] = src[x + val, y];
                return src;
            }
            else
            {
                for (int y = 1; y < src.Height; y += 2)
                    for (int x = src.Width + val; x > 0; x--)
                        dst[x, y] = src[x + val, y];
                return src;
            }
        }

        public static Pixel<T> StaggerRSelf<T>(this Pixel<T> src) where T : struct, IComparable
            => Stagger(src, src, -1);
        public static Pixel<T> StaggerLSelf<T>(this Pixel<T> src) where T : struct, IComparable
            => Stagger(src, src, +1);
        public static Pixel<T> StaggerR<T>(this Pixel<T> src) where T : struct, IComparable
            => Stagger(src, src.Clone(), -1);
        public static Pixel<T> StaggerL<T>(this Pixel<T> src) where T : struct, IComparable
            => Stagger(src, src.Clone(), +1);

        //切り出し

        public static Pixel<T> Cut<T>(this Pixel<T> src) where T : struct, IComparable
        {
            var dst = new T[src.Size];
            int c = 0;
            for (int y = 0; y < src.Height; y ++)
                for (int x = 0; x < src.Width; x++)
                    dst[c++] = src[x, y];
            //foreach (var i in src.GetIndex())
            //    dst[c++] = src[i];
            return PixelFactory.Create(src.Width, src.Height, dst);
        }
        public static Pixel<T> Cut<T>(this Pixel<T> src, int left, int top, int width, int height) where T : struct, IComparable
        {
            //src = src["Full"];
            var dst = new T[width * height];
            int i = 0;
            for (int y = top; y < height + top; y++)
                for (int x = left; x < width + left; x++)
                    dst[i++] = src[x, y];
            return PixelFactory.Create(width, height, dst);
        }

        //統計・マッチング

        //Labling -> OpenCV
        public static int Matching(this Pixel<bool> src)
        {
            //Boxの生成
            var box = new List<(int x, int y)>()
            {
                (0,0),(-1,0),(1,0),(0,-1),(0,0)
            };

            var dst = src.Count(box, x =>
            {
                if (x[0])
                {
                    var j = 0;
                    if (x[1]) j++;
                    if (x[2]) j++;
                    if (x[3]) j++;
                    if (x[4]) j++;

                    return (j >= 3);
                }
                else
                {
                    return (src[1] && src[2] && src[3] && src[4]);
                }
            });

            //List < System.Windows.Point >
            return dst;
        }
        public static List<int> MatchingList(this Pixel<bool> src)
        {
            //Boxの生成
            var box = new List<(int x, int y)>()
            {
                (0,0),(-1,0),(1,0),(0,-1),(0,0)
            };

            var dst = src.CountList(box, x =>
            {
                if (x[0])
                {
                    var j = 0;
                    if (x[1]) j++;
                    if (x[2]) j++;
                    if (x[3]) j++;
                    if (x[4]) j++;

                    return (j >= 3);
                }
                else
                {
                    return (src[1] && src[2] && src[3] && src[4]);
                }
            });
            return dst;
        }


        //フィルタ

        public static Pixel<T> FilterMedian<T>(this Pixel<T> src, Pixel<T> dst, int WindowX, int WindowY, int rank) where T : struct, IComparable
        {
            if (dst == null) dst = src.Clone();

            //Boxの生成
            var box = new List<(int x, int y)>();
            for (int y = 0; y < WindowY; y++)
                for (int x = 0; x < WindowX; x++)
                    box.Add((x - (WindowX/2), y - (WindowY/2)));

            dst = src.Acc<T, T>(box, x =>
            {
                 Array.Sort(x);
                 return x[rank];
            }, dst);

            return dst;
        }
        public static Pixel<T> FilterMedian<T>(this Pixel<T> src, int WindowX = 5, int WindowY = 5, int rank = 12) where T : struct, IComparable
            => src.FilterMedian(null, WindowX, WindowY, rank);






        public static List<System.Windows.Point> MatchingG(this Pixel<bool> _src)
        {
            /*
            var dst = new List<System.Windows.Point>();

            var src = _src.Clone();
            //B,Rは削除
            foreach(var i in src["Full","R"].GetIndex()) src[i] = false;
            foreach (var i in src["Full","B"].GetIndex()) src[i] = false;

            foreach (var i in src["Effective"].GetIndexPlus("M"))
            {
                if (src[i.center])
                {
                    //中心Gr,斜め
                    var j = 0;
                    if (src[i.lefttop]) j++;
                    if (src[i.leftbottom]) j++;
                    if (src[i.righttop]) j++;
                    if (src[i.rightbottom]) j++;

                    if (j >= 3)
                        dst.Add(new System.Windows.Point(i.center % src.Stride, i.center / src.Stride));
                }
                else
                {
                    //中心B /R ,上下
                    var j = 0;
                    if (src[i.top]) j++;
                    if (src[i.bottom]) j++;
                    if (src[i.left]) j++;
                    if (src[i.right]) j++;

                    if (j >= 3)
                        dst.Add(new System.Windows.Point(i.center % src.Stride, i.center / src.Stride));
                }
            }
            */
            return null;
        }






        //FPN

        //アベレージフィルタ
        //public static Pixel<float> FilterAverageV(this Pixel<float> src, Pixel<float> dst = null, params string[] colors)
        //{
        //    dst = dst ?? src.Clone();
        //    colors = colors ?? new string[] { "M" };

        //    foreach(var color in colors)
        //    {
        //        var i = src.AverageV(color);

        //        int c = 0;
        //        src = src[src.Map, color];
        //        foreach (var x in src.GetIndexX())
        //        {
        //            foreach (var y in src.GetIndexY())
        //            {
        //                dst[x + y] = (float)i[c];
        //            }
        //            c++;
        //        }
        //    }
        //    return dst;
        //}
        //public static Pixel<float> FilterAverageH(this Pixel<float> src, Pixel<float> dst = null, params string[] colors)
        //{
        //    dst = dst ?? src.Clone();
        //    colors = colors ?? new string[] { "M" };

        //    foreach (var color in colors)
        //    {
        //        var i = src.AverageH(color);

        //        int c = 0;
        //        src = src[src.Map, color];
        //        foreach (var y in src.GetIndexY())
        //        {
        //            foreach (var x in src.GetIndexX())
        //            {
        //                dst[x + y] = (float)i[c];
        //            }
        //            c++;
        //        }
        //    }
        //    return dst;
        //}
        //public static Pixel<float> FilterAverageH(this Pixel<float> src, string fillmap, string filtermap, Pixel<float> dst = null, params string[] colors)
        //{
        //    dst = dst ?? src[fillmap].Clone();
        //    colors = colors ?? new string[] { "M" };

        //    foreach (var color in colors)
        //    {
        //        var i = src[filtermap].AverageH(color);

        //        int c = 0;
        //        src = src[filtermap, color];
        //        foreach (var y in src[fillmap].GetIndexY())
        //        {
        //            foreach (var x in src[fillmap].GetIndexX())
        //            {
        //                dst[x + y] = (float)i[c];
        //            }
        //            c++;
        //        }
        //    }
        //    return dst;
        //}



        private static Pixel<float> FilterHOB(this Pixel<float> src)
        {
            //var hob = src["HOB-Lx"].AverageH();
            //src = src["Active"];
            //var dst = src.Clone();

            //for (int y = 0; y < src.Height; y++)
            //    for (int x = 0; x < src.Width; x++)
            //    {
            //        dst[x,y] = (float)(src[x,y] - hob[y]);
            //    }
            return null;
        }

    }
}
