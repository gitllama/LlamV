






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
    private static partial class PixelStream
    {
        private static void _Read<T>(byte[] src, T[] dst, int offset, string type) where T : struct, IComparable
        {
			switch((object)dst)
			{
				case Byte[] n:
					_Read(src, n, offset, type);
					break;
				case UInt16[] n:
					_Read(src, n, offset, type);
					break;
				case UInt32[] n:
					_Read(src, n, offset, type);
					break;
				case UInt64[] n:
					_Read(src, n, offset, type);
					break;
				case Int16[] n:
					_Read(src, n, offset, type);
					break;
				case Int32[] n:
					_Read(src, n, offset, type);
					break;
				case Int64[] n:
					_Read(src, n, offset, type);
					break;
				case Single[] n:
					_Read(src, n, offset, type);
					break;
				case Double[] n:
					_Read(src, n, offset, type);
					break;
				default:
					break;
            }
		}


        private static void _Read(byte[] src, Byte[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Byte)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (Byte)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, UInt16[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt16)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (UInt16)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, UInt32[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt32)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (UInt32)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, UInt64[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (UInt64)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (UInt64)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, Int16[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int16)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (Int16)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, Int32[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int32)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (Int32)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, Int64[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Int64)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (Int64)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, Single[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Single)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (Single)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}

        private static void _Read(byte[] src, Double[] dst, int offset, string type)
        {
			int count_byte = offset;
			switch(type)
			{
				case "UInt16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToUInt16(src, count_byte);
						count_byte += sizeof(UInt16);
					}
					break;
				case "UInt32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToUInt32(src, count_byte);
						count_byte += sizeof(UInt32);
					}
					break;
				case "UInt64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToUInt64(src, count_byte);
						count_byte += sizeof(UInt64);
					}
					break;
				case "Int16":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToInt16(src, count_byte);
						count_byte += sizeof(Int16);
					}
					break;
				case "Int32":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToInt32(src, count_byte);
						count_byte += sizeof(Int32);
					}
					break;
				case "Int64":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToInt64(src, count_byte);
						count_byte += sizeof(Int64);
					}
					break;
				case "Single":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToSingle(src, count_byte);
						count_byte += sizeof(Single);
					}
					break;
				case "Double":
					for (int i= 0; i< dst.Length; i++)
					{
						dst[i] = (Double)BitConverter.ToDouble(src, count_byte);
						count_byte += sizeof(Double);
					}
					break;
                case "Byte":
                    for (int i= 0; i< dst.Length; i++)
                        dst[i] = (Double)src[count_byte++];
                    break;
                case "String":
                    break;
				default:
					break;
			}
		}



    }
}