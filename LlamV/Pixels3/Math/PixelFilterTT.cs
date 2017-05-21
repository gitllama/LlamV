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
    public static partial class PixelFilter
    {
		public static Pixel<T> t<T>(this Pixel<T> src) where T : struct, IComparable
		{
			if(typeof(T) == typeof(Byte)) return src = null;
			else if(typeof(T) == typeof(UInt16)) return src = null;
			else if(typeof(T) == typeof(UInt32)) return src = null;
			else if(typeof(T) == typeof(UInt64)) return src = null;
			else if(typeof(T) == typeof(Int16)) return src = null;
			else if(typeof(T) == typeof(Int32)) return src = null;
			else if(typeof(T) == typeof(Int64)) return src = null;
			else if(typeof(T) == typeof(Single)) return src = null;
			else if(typeof(T) == typeof(Double)) return src = null;
			else  return null;

		}
    }
}