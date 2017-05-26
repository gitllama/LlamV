






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

using Pixels;

namespace Pixels.Math
{
    public static partial class PixelMath
    {

        public static double Average(this Pixel<Byte> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<UInt16> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<UInt32> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<UInt64> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<Int16> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<Int32> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<Int64> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<Single> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }
        public static double Average(this Pixel<Double> src, string color)
        {
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst+=src[i];			
			}
            return dst / src.GetCount(color);
        }

		public static double Deviation(this Pixel<Byte> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<UInt16> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<UInt32> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<UInt64> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<Int16> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<Int32> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<Int64> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<Single> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }
		public static double Deviation(this Pixel<Double> src, string color, double? average = null)
        {
			var ave = average ?? Average(src, color);
			double dst = 0;
            foreach (var i in src.GetIndex(color))
			{
				dst += System.Math.Pow(src[i] - ave, 2);	
			}
            return System.Math.Sqrt(dst / src.GetCount(color));
        }

		public static (double Average, double Deviation) Signal(this Pixel<Byte> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<UInt16> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<UInt32> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<UInt64> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<Int16> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<Int32> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<Int64> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<Single> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}
		public static (double Average, double Deviation) Signal(this Pixel<Double> src, string color)
		{
			double ave = Average(src, color);
			double dev = Deviation(src, color, ave);

			return (ave, dev);
		}


        public static int Count(Pixel<Byte> src1, Byte thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<Byte> src1, Pixel<Byte> src2, Byte thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<Byte> src1, Byte thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<Byte> src1, Pixel<Byte> src2, Byte thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<UInt16> src1, UInt16 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<UInt16> src1, Pixel<UInt16> src2, UInt16 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<UInt16> src1, UInt16 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<UInt16> src1, Pixel<UInt16> src2, UInt16 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<UInt32> src1, UInt32 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<UInt32> src1, Pixel<UInt32> src2, UInt32 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<UInt32> src1, UInt32 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<UInt32> src1, Pixel<UInt32> src2, UInt32 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<UInt64> src1, UInt64 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<UInt64> src1, Pixel<UInt64> src2, UInt64 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<UInt64> src1, UInt64 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<UInt64> src1, Pixel<UInt64> src2, UInt64 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<Int16> src1, Int16 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<Int16> src1, Pixel<Int16> src2, Int16 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<Int16> src1, Int16 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<Int16> src1, Pixel<Int16> src2, Int16 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<Int32> src1, Int32 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<Int32> src1, Pixel<Int32> src2, Int32 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<Int32> src1, Int32 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<Int32> src1, Pixel<Int32> src2, Int32 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<Int64> src1, Int64 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<Int64> src1, Pixel<Int64> src2, Int64 thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<Int64> src1, Int64 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<Int64> src1, Pixel<Int64> src2, Int64 thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<Single> src1, Single thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<Single> src1, Pixel<Single> src2, Single thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<Single> src1, Single thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<Single> src1, Pixel<Single> src2, Single thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/

        public static int Count(Pixel<Double> src1, Double thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if(src1[x, y] != thr) count++;
					return count;
			}
			return -1;
        }
        public static int Count(Pixel<Double> src1, Pixel<Double> src2, Double thr, INEQUALITY ine = INEQUALITY.GreaterThan,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			int count = 0;
			switch(ine)
			{
				case INEQUALITY.GreaterThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) > thr) count++;
					return count;
				case INEQUALITY.GreaterThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) >= thr) count++;
					return count;
				case INEQUALITY.LessThan:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) < thr) count++;
					return count;
				case INEQUALITY.LessThanOrEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) <= thr) count++;
					return count;
				case INEQUALITY.Equal:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) == thr) count++;
					return count;
				case INEQUALITY.NotEqual:
					for (int y = start_y; y < src1.Height; y+=step_y)
						for (int x = start_x; x < src1.Width; x+=step_x)
							if((src1[x, y] - src2[x,y]) != thr) count++;
					return count;
			}
			return -1;
        }
		/*
		public static int[] CountBayer(Pixel<Double> src1, Double thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		public static int[] CountBayer(Pixel<Double> src1, Pixel<Double> src2, Double thr, INEQUALITY ine = INEQUALITY.GreaterThan)
        {
			List<int> dst = new List<int>();
			for (int y = 0; y < src1.BayerSizeY; y++)
				for (int x = 0; x < src1.BayerSizeX; x++)
					dst.Add(Count(src1,src2,thr,ine,x,y,src1.BayerSizeX,src1.BayerSizeY));
			return dst.ToArray();
        }
		*/









		public static double[] AverageH(this Pixel<Byte> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<UInt16> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<UInt32> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<UInt64> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<Int16> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<Int32> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<Int64> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<Single> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

		public static double[] AverageH(this Pixel<Double> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();
            for (int y = start_y; y < src.Height; y+=step_y)
			{
				int c=0;
				double hoge = 0;
				for (int x = start_x; x < src.Width; x+=step_x)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }




        public static double[] AverageV(this Pixel<Byte> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<UInt16> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<UInt32> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<UInt64> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<Int16> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<Int32> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<Int64> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<Single> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

        public static double[] AverageV(this Pixel<Double> src,int start_x = 0,int start_y = 0,int step_x=1, int step_y = 1)
        {
			List<double> dst = new List<double>();

            for (int x = start_x; x < src.Width; x+=step_x)
			{
				int c=0;
				double hoge = 0;
				for (int y = start_y; y < src.Height; y+=step_y)
				{
					hoge+=src[x,y];
					c++;				
				}
				hoge /= c;
				dst.Add(hoge);
			}
            return dst.ToArray();
        }

    }
}