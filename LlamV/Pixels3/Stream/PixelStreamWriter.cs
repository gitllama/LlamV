using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

using System.Reflection;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

using System.IO.Compression;
using System.Threading.Tasks;

namespace Pixels.Stream
{
    public static partial class PixelStream
    {
        private static void WriteArray<T>(T[] src, FileStream sw) where T : struct, IComparable
        {
			switch((object)src)
			{
				case Byte[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(Byte));
					}
					break;
				case UInt16[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(UInt16));
					}
					break;
				case UInt32[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(UInt32));
					}
					break;
				case UInt64[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(UInt64));
					}
					break;
				case Int16[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(Int16));
					}
					break;
				case Int32[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(Int32));
					}
					break;
				case Int64[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(Int64));
					}
					break;
				case Single[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(Single));
					}
					break;
				case Double[] n:
					foreach (var i in n)
					{
						sw.Write(BitConverter.GetBytes(i), 0, sizeof(Double));
					}
					break;
				default:
					break;
            }
        }
    }
}