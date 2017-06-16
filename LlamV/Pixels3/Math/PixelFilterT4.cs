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
        //切り出し
        public static Pixel<T> Cut<T>(this Pixel<T> src) where T : struct, IComparable
        {
            var dst = new T[src.Size];
            int c = 0;
            foreach (var i in src.GetIndex())
            {
                dst[c++] = src[i];
            }
            return PixelFactory.Create(src.Width, src.Height, dst);
        }



        //public static Pixel<T> Cut<T>(this Pixel<T> src, string color) where T : struct, IComparable
        //{
        //    var dst = new T[src.GetCount(color)];
        //    int c = 0;
        //    foreach (var i in src.GetIndex(color))
        //    {
        //        dst[c++] = src[i];
        //    }
        //    return PixelFactory.Create(src.GetWidth(color), src.GetHeight(color), dst);
        //}
        //public static Pixel<T> Cut<T>(this Pixel<T> src, int x, int y, int width, int height) where T : struct, IComparable
        //{
        //    src.SetMap("Full");
        //    var dst = new T[width * height];
        //    int i = 0;
        //    for (int yy = y; yy < height + y; yy++)
        //        for (int xx = x; xx < width + x; xx++)
        //            dst[i++] = src[xx, yy];
        //    return PixelFactory.Create(width, height, dst);
        //}


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



        public static List<System.Windows.Point> Matching(this Pixel<bool> src, string color)
        {
            var dst = new List<System.Windows.Point>();

            foreach(var i in src.GetIndexPlus(color))
            {
                if(src[i.center])
                {
                    var j = 0;
                    if (src[i.top]) j++;
                    if (src[i.bottom]) j++;
                    if (src[i.left]) j++;
                    if (src[i.right]) j++;

                    if (j >= 3)
                    {
                        dst.Add(new System.Windows.Point(i.center % src.Stride, i.center / src.Stride));
                    }
                }
                else
                {
                    if (src[i.top] && src[i.bottom] && src[i.left] && src[i.right])
                    {
                        dst.Add(new System.Windows.Point(i.center % src.Stride, i.center / src.Stride));
                    }
                }
            }
            return dst;
        }
        public static List<System.Windows.Point> MatchingG(this Pixel<bool> _src)
        {
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
            return dst;
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

        public static Pixel<T> FilterMedian<T>(this Pixel<T> src, Pixel<T> dst, int WindowX, int WindowY, int rank, params string[] colors) where T : struct, IComparable
        {
            if (dst == null) dst = src.Clone();
            if (colors == null) colors = new string[] { "M" };

            foreach (var color in colors)
            {
                //作業領域の生成
                int[] coordinate = new int[src.Size];

                int c = 0;
                src = src[src.Map, color];
                foreach (int i in src.GetIndex())
                    coordinate[c++] = i;

                //Boxの生成
                int boxsize = WindowX * WindowY;
                int center = WindowX * WindowY / 2;

                int startX = WindowX / 2;
                int startY = WindowY / 2;
                int endX = src.Width - (WindowX - startX - 1);
                int endY = src.Height - (WindowY - startY - 1);

                int endline = WindowX - 1;

                //配列生成
                T[] box = new T[boxsize];

                //参照座標生成
                int[] col = new int[boxsize];
                c = 0;
                for (int y = 0; y < WindowY; y++)
                    for (int x = 0; x < WindowX; x++)
                        col[c++] = x + y * src.Width;

                //本体
                for (int y = startY; y < endY; y++)
                {
                    for (int x = startX; x < endX; x++)
                    {
                        for (int n = 0; n < boxsize; n++) box[n] = src[coordinate[col[n]]];
                        Array.Sort(box);
                        dst[coordinate[col[center]]] = box[rank];

                        for (int n = 0; n < boxsize; n++) col[n]++;
                    }
                    //ライン送り
                    for (int n = 0; n < boxsize; n++) col[n] += endline;

                    //token.Token.ThrowIfCancellationRequested();
                }
            }

            return dst;
        }
        public static Pixel<T> FilterMedian<T>(this Pixel<T> src, int WindowX = 5, int WindowY = 5, int rank = 12, params string[] colors) where T : struct, IComparable
            => src.FilterMedian(null, WindowX, WindowY, rank, colors);



        private static void _FilterAverage(Pixel<float> src, Pixel<float> dst, int[] matrix, int sx, int sy, int ex, int ey)
        {
            double buf;
            for (int y = sy; y < src.Height - ey; y++)
                for (int x = sx; x < src.Width - ex; x++)
                {
                    buf = 0;
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        buf += src.pixel[src.ConvPoisonMap(x, y) + matrix[i]];
                    }
                    dst.pixel[dst.ConvPoisonMap(x, y)] = (float)(buf / matrix.Length);
                }
        }
        //public static Pixel<T> FilterAverage<T>(this Pixel<T> src, Pixel<T> dst, int WindowX = 5, int WindowY = 5) where T : struct, IComparable
        //{
        //    if (dst == null) dst = src.Clone();

        //    int boxsize = WindowX * WindowY;

        //    int before_center = rank - 1;

        //    int startX = WindowX / 2;
        //    int startY = WindowY / 2;
        //    int endX = src.Width - (WindowX - startX - 1);
        //    int endY = src.Height - (WindowY - startY - 1);

        //    int endline = WindowX - 1;

        //    //配列生成
        //    T[] box = new T[boxsize];

        //    //参照座標生成
        //    int[] col = new int[boxsize];
        //    int i = 0;
        //    for (int y = 0; y < WindowY; y++)
        //        for (int x = 0; x < WindowX; x++)
        //            col[i++] = x + y * src.Width;
        //    //本体
        //    for (int y = startY; y < endY; y++)
        //    {
        //        for (int x = startX; x < endX; x++)
        //        {
        //            for (int n = 0; n < boxsize; n++) box[n] = src.pixel[col[n]++];
        //            Array.Sort(box);
        //            dst[x, y] = box[rank];
        //        }
        //        //ライン送り
        //        for (int n = 0; n < boxsize; n++) col[n] += endline;
        //        //token.Token.ThrowIfCancellationRequested();
        //    }
        //    return dst;
        //}
        //public static Pixel<T> FilterAverage<T>(this Pixel<T> src, int WindowX = 5, int WindowY = 5, int rank = 12) where T : struct, IComparable
        //    => src.FilterMedian(null, WindowX, WindowY, rank);


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
