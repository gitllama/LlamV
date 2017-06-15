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

namespace Pixels.Extend/*T4namespace{*/.Base/*}T4namespace*/
{
    public static class PixelOpenCV
    {
        #region Filter

       public static List<(int Left,int Top, int Width, int Height, int Area)> Labling(this Pixel<bool> src, Func<ConnectedComponents.Blob, bool> func, bool connectivity8 = true)
        {
            var hoge = src["Full"].ToPixel<byte>();

            using (Mat mat = new Mat(src.Height, src.Width, MatType.CV_8UC1, hoge.pixel))
            {
                ConnectedComponents cc = connectivity8 
                    ? Cv2.ConnectedComponentsEx(mat, PixelConnectivity.Connectivity8) 
                    : Cv2.ConnectedComponentsEx(mat, PixelConnectivity.Connectivity4);

                var dst = cc.Blobs
                    .Where(x => func(x)) //.Area >= thr
                    .Where(x => x.Label != 0) //0が背景
                    .OrderByDescending(x => x.Area)
                    .Select(x => (x.Left, x.Top,x.Width, x.Height, x.Area))
                    .ToList();
                    
                return dst;
            }

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
                        /*T4{[
                            {"Key": ["Byte"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
                        ]T4h*/
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
                            break;/*}T4*/
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
                        /*T4{[
                            {"Key": ["Byte"], "Value": [["Byte"],["UInt16"],["UInt32"],["UInt64"],["Int16"],["Int32"],["Int64"],["Single"],["Double"]]}
                        ]T4h*/
                        case Pixel<Byte> h:
                            for (int y = 0; y < h.Height; y++)
                                for (int x = 0; x < h.Width; x++)
                                {
                                    ref var value = ref h[x, y];
                                    bufraw[c++] = value > 255 ? (byte)255 : value < 0 ? (byte)0 : (byte)value;
                                }
                            break;/*}T4*/
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
