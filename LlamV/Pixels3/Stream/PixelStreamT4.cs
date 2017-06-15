using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Runtime.InteropServices;

using System.Windows.Media.Imaging;
using System.Windows.Media;
using Pixels.Math;

namespace Pixels.Stream
{
    public static partial class PixelStream
    {


        /*** read ***/

        public enum ColorChannel
        {
            R, G, B, A
        }

        public static Pixel<T> Read<T>(this Pixel<T> src, string filename, int offsetbyte, String type) where T : struct, IComparable
        {
            //type?.Name
            byte[] data = System.IO.File.ReadAllBytes(filename);
            switch (type)
            {
                
                case "Byte": ReadByte((dynamic)src.pixel, data, offsetbyte); break;
                case "UInt16": ReadUInt16((dynamic)src.pixel, data, offsetbyte); break;
                case "UInt32": ReadUInt32((dynamic)src.pixel, data, offsetbyte); break;
                case "UInt64": ReadUInt64((dynamic)src.pixel, data, offsetbyte); break;
                case "Int16": ReadInt16((dynamic)src.pixel, data, offsetbyte); break;
                case "Int32": ReadInt32((dynamic)src.pixel, data, offsetbyte); break;
                case "Int64": ReadInt64((dynamic)src.pixel, data, offsetbyte); break;
                case "Single": ReadSingle((dynamic)src.pixel, data, offsetbyte); break;
                case "Double": ReadDouble((dynamic)src.pixel, data, offsetbyte); break;
                default:
                    break;
            }
            return src;
        }

        #region Read

        
        private static void ReadByte(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        private static void ReadByte(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
                _src[i] = (Byte)_data[count_byte++];
        }
        
        private static void ReadUInt16(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt16(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToUInt16(_data, count_byte);
                count_byte += sizeof(UInt16);
            }
        }
        private static void ReadUInt32(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt32(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToUInt32(_data, count_byte);
                count_byte += sizeof(UInt32);
            }
        }
        private static void ReadUInt64(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadUInt64(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToUInt64(_data, count_byte);
                count_byte += sizeof(UInt64);
            }
        }
        private static void ReadInt16(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt16(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToInt16(_data, count_byte);
                count_byte += sizeof(Int16);
            }
        }
        private static void ReadInt32(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt32(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToInt32(_data, count_byte);
                count_byte += sizeof(Int32);
            }
        }
        private static void ReadInt64(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadInt64(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToInt64(_data, count_byte);
                count_byte += sizeof(Int64);
            }
        }
        private static void ReadSingle(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadSingle(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToSingle(_data, count_byte);
                count_byte += sizeof(Single);
            }
        }
        private static void ReadDouble(Byte[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Byte)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(UInt16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt16)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(UInt32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt32)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(UInt64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (UInt64)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(Int16[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int16)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(Int32[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int32)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(Int64[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Int64)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(Single[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Single)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }
        private static void ReadDouble(Double[] _src, byte[] _data, int _offsetbyte)
        {
            int count_byte = _offsetbyte;
            for (int i = 0; i < _src.Length; i++)
            {
                _src[i] = (Double)BitConverter.ToDouble(_data, count_byte);
                count_byte += sizeof(Double);
            }
        }

        #endregion

        public static Pixel<T> ReadBMP<T>(string filename, ColorChannel ch = ColorChannel.G) where T : struct, IComparable
        {
            using (MemoryStream data = new MemoryStream(File.ReadAllBytes(filename)))
            {
                WriteableBitmap wbmp = new WriteableBitmap(BitmapFrame.Create(data));
                data.Close();
                // フォーマットが異なるならば変換
                BitmapSource s = wbmp;
                if (s.Format != PixelFormats.Bgra32)
                {
                    s = new FormatConvertedBitmap(
                        s,
                        PixelFormats.Bgra32,
                        null,
                        0);
                    s.Freeze();
                }

                //byteへの変換
                int stride = s.PixelWidth * s.Format.BitsPerPixel / 8;
                byte[] src = new byte[stride * s.PixelWidth];
                s.CopyPixels(src, stride, 0);

                //配列の確保
                T[] dst = new T[s.PixelWidth * s.PixelHeight];

                int c = 1;
                switch (ch)
                {
                    case ColorChannel.R: c = 2; break;
                    case ColorChannel.B: c = 0; break;
                    case ColorChannel.A: c = 3; break;
                    case ColorChannel.G: c = 1; break;
                    default: c = 1; break;
                }

                switch ((object)dst)
                {
                    
                    case Byte[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (Byte)src[c];
                            c += 4;
                        }
                        break;
                    case UInt16[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (UInt16)src[c];
                            c += 4;
                        }
                        break;
                    case UInt32[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (UInt32)src[c];
                            c += 4;
                        }
                        break;
                    case UInt64[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (UInt64)src[c];
                            c += 4;
                        }
                        break;
                    case Int16[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (Int16)src[c];
                            c += 4;
                        }
                        break;
                    case Int32[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (Int32)src[c];
                            c += 4;
                        }
                        break;
                    case Int64[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (Int64)src[c];
                            c += 4;
                        }
                        break;
                    case Single[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (Single)src[c];
                            c += 4;
                        }
                        break;
                    case Double[] n:
                        for (int i = 0; i < dst.Length; i++)
                        {
                            n[i] = (Double)src[c];
                            c += 4;
                        }
                        break;
                    default:
                        break;
                }

                return PixelFactory.Create<T>(s.PixelWidth, s.PixelHeight, dst);
            }
        }



        /*** write ***/

        public static void Write<T>(this Pixel<T> src, string filename, bool selected = false) where T : struct, IComparable
        {
            if (!System.IO.Directory.Exists(Path.GetDirectoryName(filename)))
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(filename));

            if (!selected)
            {
                src = src["Full"];
            }

            using (FileStream sw = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                int bytesize = Marshal.SizeOf<T>();
                switch ((object)src)
                {
                    
                    case Byte[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(Byte));
                        break;
                    case UInt16[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(UInt16));
                        break;
                    case UInt32[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(UInt32));
                        break;
                    case UInt64[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(UInt64));
                        break;
                    case Int16[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(Int16));
                        break;
                    case Int32[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(Int32));
                        break;
                    case Int64[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(Int64));
                        break;
                    case Single[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(Single));
                        break;
                    case Double[] n:
                        foreach (var i in n)
                            sw.Write(BitConverter.GetBytes(i), 0, sizeof(Double));
                        break;
                    default:
                        break;
                }
            }
        }

        public static void WriteText<T>(this Pixel<T> src, string filename, string delimiter = ", ", bool selected = false) where T : struct, IComparable
        {
            if(!selected)
            {
                src = src["Full"];
            }
            int w = src.Width;
            int h = src.Height;
            int depth = 255;

            using (StreamWriter sw = new StreamWriter(filename))
            {
                /* 
                bool pgmheader = false
                if (pgmheader)
                {
                    sw.Write($"P2\r\n");
                    sw.Write($"{w} {h}\r\n");
                    sw.Write($"{depth}\r\n");
                }
                */
                for (int y = 0; y < h; y++)
                {
                    StringBuilder buf = new StringBuilder();
                    for (int x = 0; x < w - 1; x++)
                    {
                        buf.Append(src[x,y]);
                        buf.Append(delimiter);
                    }
                    buf.Append(src[w - 1, y]);
                    buf.Append("\r\n");
                    sw.Write(buf);
                }
            }
        }

        public static void WriteBitmap(this Pixel<byte> src, string filename, bool selected = false)
        { 
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                var i = ToBitmapSource(src, selected);
                encoder.Frames.Add(BitmapFrame.Create(i));
                encoder.Save(stream);
            }
        }
        public static WriteableBitmap ToWriteableBitmap(this Pixel<byte> src, bool selected = false)
        {
            return new WriteableBitmap(ToBitmapSource(src, selected));
        }
        public static BitmapSource ToBitmapSource(this Pixel<byte> src, bool selected = false)
        {
            var buf = src.Clone();
            if (!selected)
            {
                buf = buf["Full"];
            }
            else
            {
                buf = buf.Cut();
            }

            var _buf = BitmapImage.Create(
                buf.Width, buf.Height, 96, 96,
                System.Windows.Media.PixelFormats.Gray8,
                null,
                buf.pixel,
                (buf.Width * PixelFormats.Gray8.BitsPerPixel + 7) / 8);
            _buf.Freeze();
            return _buf;
        }


        public static string ToText<T>(this Pixel<T> src, string delimiter = ", ") where T : struct, IComparable
        {
            StringBuilder buf = new StringBuilder();

            buf.Append($"\"(Left, Top) = ({src.Left},{src.Top})\"\r\n");

            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width - 1; x++)
                {
                    buf.Append(src[x, y]);
                    buf.Append(delimiter);
                }
                buf.Append(src[src.Width - 1, y]);
                buf.Append("\r\n");
            }

            return buf.ToString();
        }

    }
}
