using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixels.Math
{
    public enum BMPColor
    {
        R, G, B, A
    }


    public static class PixelFilter
    {
        //切り出し

        public static Pixel<T> Cut<T>(this Pixel<T> src) where T : struct, IComparable
        {
            var dst = new T[src.Width * src.Height];
            int i = 0;
            for (int y = 0; y < src.Height; y++)
                for (int x = 0; x < src.Width; x++)
                    dst[i++] = src[x,y];
            return PixelFactory.Create(src.Width, src.Height, dst);
        }
        public static Pixel<T> Cut<T>(this Pixel<T> src, int x, int y,int width, int height) where T : struct, IComparable
        {
            src.SetMap("Full");
            var dst = new T[width * height];
            int i = 0;
            for (int yy = y; yy < height + y; yy++)
                for (int xx = x; xx < width + x; xx++)
                    dst[i++] = src[xx, yy];
            return PixelFactory.Create(width, height, dst);
        }


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
            => Stagger(src, src, 1);
        public static Pixel<T> StaggerLSelf<T>(this Pixel<T> src) where T : struct, IComparable
            => Stagger(src, src, -1);
        public static Pixel<T> StaggerR<T>(this Pixel<T> src) where T : struct, IComparable
            => Stagger(src, src.Clone(), 1);
        public static Pixel<T> StaggerL<T>(this Pixel<T> src) where T : struct, IComparable
            => Stagger(src, src.Clone(), -1);


        public static Pixel<float> FilterAverageV(this Pixel<float> src, Pixel<float> dst = null)
        {
            dst = dst ?? src.Clone();
            var i = src.AverageV();

            int c = 0;
            for (int x = 0; x < src.Width; x ++)
            {
                for (int y = 0; y < src.Height; y ++)
                {
                    dst[x, y] = (float)i[x];
                }
                c++;
            }
            return dst;
        }
        public static Pixel<float> FilterAverageH(this Pixel<float> src, Pixel<float> dst = null)
        {
            dst = dst ?? src.Clone();
            var i = src.AverageH();

            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    dst[x, y] = (float)i[y];
                }
            }
            return dst;
        }

        private static void _FilterAverage(Pixel<float> src, Pixel<float> dst, int[] matrix, int sx, int sy, int ex, int ey)
        {
            double buf;
            for (int y = sy; y < src.Height - ey; y++)
                for (int x = sx; x < src.Width - ex; x++)
                {
                    buf = 0;
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        buf += src.pixel[src.ConvMapPoison(x, y) + matrix[i]];
                    }
                    dst.pixel[dst.ConvMapPoison(x, y)] = (float)(buf / matrix.Length);
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


        private static void _FilterMedian<T>(Pixel<T> src, Pixel<T> dst, int rank, int[] matrix, int sx,int sy,int ex,int ey) where T : struct, IComparable
        {
            T[] box = new T[matrix.Length];
            for (int y = sy; y < src.Height - ey; y++)
                for (int x = sx; x < src.Width - ex; x++)
                {
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        box[i] = src.pixel[src.ConvMapPoison(x, y) + matrix[i]];
                    }
                    Array.Sort(box);
                    dst.pixel[dst.ConvMapPoison(x, y)] = box[rank];
                }
        }

        public static Pixel<T> FilterMedian<T>(this Pixel<T> src, int WindowX = 5, int WindowY = 5, int rank = 12) where T : struct, IComparable
            => src.FilterMedian(null, WindowX, WindowY, rank);

        public static Pixel<T> FilterMedian<T>(this Pixel<T> src, Pixel<T> dst, int WindowX = 5, int WindowY = 5, int rank = 12) where T : struct, IComparable
        {
            if (dst == null) dst = src.Clone();

            int boxsize = WindowX * WindowY;

            int before_center = rank - 1;

            int startX = WindowX / 2;
            int startY = WindowY / 2;
            int endX = src.Width - (WindowX - startX - 1);
            int endY = src.Height - (WindowY - startY - 1);

            int endline = WindowX - 1;

            //配列生成
            T[] box = new T[boxsize];

            //参照座標生成
            int[] col = new int[boxsize];
            int i = 0;
            for (int y = 0; y < WindowY; y++)
                for (int x = 0; x < WindowX; x++)
                    col[i++] = x + y * src.Width;
            //本体
            for (int y = startY; y < endY; y++)
            {
                for (int x = startX; x < endX; x++)
                {
                    for (int n = 0; n < boxsize; n++) box[n] = src.pixel[col[n]++];
                    Array.Sort(box);
                    dst[x,y] = box[rank];
                }
                //ライン送り
                for (int n = 0; n < boxsize; n++) col[n] += endline;
                //token.Token.ThrowIfCancellationRequested();
            }
            return dst;
        }




        public static Pixel<T> FilterMedianBayer<T>(this Pixel<T> src, int WindowX = 5, int WindowY = 5, int rank = 12) where T : struct, IComparable
        {
            return src.FilterMedianBayer(null, WindowX, WindowY, rank);
        }
        public static Pixel<T> FilterMedianBayer<T>(this Pixel<T> src, Pixel<T> dst, int WindowX = 5, int WindowY = 5, int rank = 12) where T : struct, IComparable
        {
            if (dst == null) dst = src.Clone();

            //matrix
            int[] matrix = new int[WindowX * WindowY];
            int c = 0;
            for (int y = 0; y < WindowY; y++)
                for (int x = 0; x < WindowX; x++)
                    matrix[c++] = src.ConvBayerPoison(x - (WindowX / 2), y - (WindowY / 2));

            //本体
            _FilterMedian(
                src, 
                dst, 
                rank,
                matrix,
                (WindowX / 2) * src.BayerSizeX,
                (WindowY / 2) * src.BayerSizeY,
                (WindowX - WindowX / 2) * src.BayerSizeX,
                (WindowY - WindowY / 2) * src.BayerSizeY);

            
                return dst;
        }


    }
}


//switch (Type.GetTypeCode(type))
//{
//    case TypeCode.Int32:
//        // It's an int
//        break;

//    case TypeCode.String:
//        // It's a string
//        break;

//public static Pixel<T> BitShift<T>(this Pixel<T> src, int value) where T : struct, IComparable
//{
//    switch ((object)src)
//    {
//        case Pixel<int> p:
//            for (int y = 0; y < p.Height; y++)
//                for (int x = 0; x < p.Width; x++)
//                    p[x, y].BitShiftR(value);
//            break;
//    }
//    return src;
//}