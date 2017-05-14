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

        public static WriteableBitmap ToMono<T>(this Pixel<T> src, byte[] buf = null, WriteableBitmap dst = null) where T : struct, IComparable
        {
            if (buf == null) buf = new byte[src.Width * src.Height * 3];
            if (dst == null) dst = new WriteableBitmap(src.Width, src.Height, 96, 96, PixelFormats.Bgr24, null);

            using (Mat matsrc = new Mat(src.Height, src.Width, MatType.CV_8UC3, buf))
            {
                PixelMath.ConvertToByte<T>(src, buf);
                WriteableBitmapConverter.ToWriteableBitmap(matsrc, dst);
            }
            return dst;
        }
        public static WriteableBitmap ToColor<T>(this Pixel<T> src, float[] matrix, ColorConversionCodes cc, byte[] buf = null, WriteableBitmap dst = null) where T : struct, IComparable
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
                PixelMath.ConvertToByteColor<T>(src, bufraw);
                Cv2.CvtColor(matraw, mat, cc);
                Cv2.Transform(mat, mat, matmatrix);

                WriteableBitmapConverter.ToWriteableBitmap(mat, dst);
            }
            return dst;
        }
        public static WriteableBitmap ToColorBG<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerBG2BGR, buf, dst);
        public static WriteableBitmap ToColorGB<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerGB2BGR, buf, dst);
        public static WriteableBitmap ToColorRG<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerRG2BGR, buf, dst);
        public static WriteableBitmap ToColorGR<T>(this Pixel<T> src, float[] matrix = null, byte[] buf = null, WriteableBitmap dst = null) where T : struct, IComparable
            => ToColor(src, matrix, ColorConversionCodes.BayerGR2BGR, buf, dst);

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


        public static int Labling(this WriteableBitmap src)
        {
            using (Mat mat = new Mat(src.PixelHeight, src.PixelWidth, MatType.CV_8UC3))
            {
                src.ToMat(mat);

                Mat gray = mat.CvtColor(ColorConversionCodes.BGR2GRAY);

                //Cv2.NamedWindow("image", WindowMode.Normal);
                //Cv2.ImShow("image", mat);
                Mat binary = gray.Threshold(0, 255, ThresholdTypes.Otsu | ThresholdTypes.Binary);

                //Cv2.NamedWindow("image", WindowMode.Normal);
                //Cv2.ImShow("image", binary);
                //Cv2.WaitKey();
                //Cv2.DestroyWindow("image");
                ConnectedComponents cc = Cv2.ConnectedComponentsEx(binary);

                int c = 0;
                foreach(var i in cc.Blobs)
                {
                    c += i.Area > 3 ? 1 : 0;
                }


                return c;
            }
        }
    }
}
