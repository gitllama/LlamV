using OpenCvSharp;
using OpenCvSharp.Extensions;
using Pixels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PresentationCore
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Pixels.Math;
using System.IO;
using System.Windows;


namespace Pixels.Extend
{
    public static class PixelOpenCV
    {
        #region Filter

        public static List<(int Left,int Top, int Width, int Height, int Area)> Labling<T>(this Pixel<T> src, Func<ConnectedComponents.Blob, bool> func, bool connectivity8 = true)
            where T : struct, IComparable
        {
            switch((object)src)
            {
                case Pixel<byte> n:
                    using (Mat mat = new Mat(n.FullHeight, n.FullWidth, MatType.CV_8UC1, n.pixel))
                    {
                        return f(mat);
                    }
                case Pixel<bool> n:
                    {
                        var hoge = n["Full"].Acc<byte>(x => x ? byte.MaxValue : byte.MinValue);
                        using (Mat mat = new Mat(hoge.FullHeight, hoge.FullWidth, MatType.CV_8UC1, hoge.pixel))
                        {
                            return f(mat);
                        }
                    }
                default:
                    {
                        var hoge = src["Full"].Acc<byte>(x => x.CompareTo(0) > 0 ? byte.MaxValue : byte.MinValue);
                        using (Mat mat = new Mat(hoge.FullHeight, hoge.FullWidth, MatType.CV_8UC1, hoge.pixel))
                        {
                            return f(mat);
                        }
                    }
            }


            List<(int Left, int Top, int Width, int Height, int Area)> f(Mat value)
            {
                ConnectedComponents cc = connectivity8
                    ? Cv2.ConnectedComponentsEx(value, PixelConnectivity.Connectivity8)
                    : Cv2.ConnectedComponentsEx(value, PixelConnectivity.Connectivity4);

                return cc.Blobs
                    .Where(x => func(x)) //.Area >= thr
                    .Where(x => x.Label != 0) //0が背景
                    .OrderByDescending(x => x.Area)
                    .Select(x => (x.Left, x.Top, x.Width, x.Height, x.Area))
                    .ToList();
            }




            //var hoge = src["Full"].ToPixel<byte>();
            //Pixel<byte> hoge = src["Full"].Acc<byte>(x => x ? (byte)255 : (byte)0 );



            /*
                at gray = mat.CvtColor(ColorConversionCodes.BGR2GRAY);

                //Cv2.NamedWindow("image", WindowMode.Normal);
                //Cv2.ImShow("image", mat);
                Mat binary = gray.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);

                //Cv2.NamedWindow("image", WindowMode.Normal);
                //Cv2.ImShow("image", binary);
                //Cv2.WaitKey();
                //Cv2.DestroyWindow("image");
            */

        }

        #endregion

        #region Bitmap

        public static WriteableBitmap ToMono<T>(this Pixel<T> src, byte[] buf = null, WriteableBitmap dst = null, Func<T, byte> func = null) where T : struct, IComparable
        {
            if (buf == null) buf = new byte[src.Width * src.Height * 3];
            if (dst == null) dst = new WriteableBitmap(src.Width, src.Height, 96, 96, PixelFormats.Bgr24, null);

            using (Mat matsrc = new Mat(src.Height, src.Width, MatType.CV_8UC3, buf))
            {
                int c = 0;
                if(func == null)
                {
                    switch ((object)src)
                    {
                        
                        case Pixel<Byte> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<UInt16> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<UInt32> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<UInt64> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<Int16> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<Int32> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<Int64> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<Single> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        case Pixel<Double> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    var hoge = (byte)(value > 255 ? 255 : value < 0 ? 0 : value);
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                    buf[c++] = hoge;
                                }
                            break;
                        default:
                            throw new NotSupportedException($"{typeof(T)}");
                    }
                }
                else
                {
                    for (int y = 0; y < src.Height; y++)
                        for (int x = 0; x < src.Width; x++)
                        {
                            ref var value = ref src[x, y];
                            var hoge = func(value);
                            buf[c++] = hoge;
                            buf[c++] = hoge;
                            buf[c++] = hoge;
                        }
                }

                WriteableBitmapConverter.ToWriteableBitmap(matsrc, dst);
            }
            return dst;
        }

        public static WriteableBitmap ToColor<T>(this Pixel<T> src, float[] matrix, ColorConversionCodes cc, byte[] buf = null, WriteableBitmap dst = null, Func<T, byte> func = null) where T : struct, IComparable
        {
            byte[] bufraw = null;
            if (buf == null) buf = new byte[src.Width * src.Height * 3];
            if (bufraw == null) bufraw = new byte[src.Width * src.Height];
            if (dst == null) dst = new WriteableBitmap(src.Width, src.Height, 96, 96, PixelFormats.Bgr24, null);

            if (matrix == null) matrix = new float[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 };

            using (Mat matmatrix = new Mat(3, 3, MatType.CV_32FC1, matrix))
            using (Mat matraw = new Mat(src.Height, src.Width, MatType.CV_8UC1, bufraw))
            using (Mat mat = new Mat(src.Height, src.Width, MatType.CV_8UC3, buf))
            {
                int c = 0;
                if (func == null)
                {
                    switch ((object)src)
                    {
                        
                        case Pixel<Byte> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<UInt16> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<UInt32> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<UInt64> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<Int16> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<Int32> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<Int64> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<Single> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        case Pixel<Double> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;
                        default:
                            throw new NotSupportedException($"{typeof(T)}");
                    }
                }
                else
                {
                    for (int y = 0; y < src.Height; y++)
                        for (int x = 0; x < src.Width; x++)
                        {
                            bufraw[c++] = func(src[x, y]);
                        }
                }

                Cv2.CvtColor(matraw, mat, cc);
                Cv2.Transform(mat, mat, matmatrix);

                WriteableBitmapConverter.ToWriteableBitmap(mat, dst);
            }
            return dst;
        }


        public static WriteableBitmap ToColorBG<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null, Func<T, byte> func = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerBG2BGR, buf, dst, func);
        public static WriteableBitmap ToColorGB<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null, Func<T, byte> func = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerGB2BGR, buf, dst, func);
        public static WriteableBitmap ToColorRG<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null, Func<T, byte> func = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerRG2BGR, buf, dst, func);
        public static WriteableBitmap ToColorGR<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null, Func<T, byte> func = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerGR2BGR, buf, dst, func);

        #endregion




        public static void Save(this WriteableBitmap src, string filename)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                //JpegBitmapEncoder
                //BmpBitmapEncoder
                //
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(src));
                encoder.Save(stream);
            }
        }

        public static void ToClipboard(this WriteableBitmap src)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create((BitmapSource)src));
                enc.Save(outStream);

                Clipboard.SetDataObject(new System.Drawing.Bitmap(outStream), false);
            }

        }

        public static void ShowCV(this WriteableBitmap src)
        {
            using (Mat mat = new Mat(src.PixelHeight, src.PixelWidth, MatType.CV_8UC3))
            {
                src.ToMat(mat);
                Cv2.NamedWindow("image", WindowMode.Normal);
                Cv2.ImShow("image", mat);
                
                Cv2.WaitKey();
                Cv2.DestroyWindow("image");
            }
        }


     }
}

