﻿using Pixels;
using Pixels.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pixels
{
    public class PixelFormat
    {
        public string Model { get; set; } = "unknown";
        public List<string> FileName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Offset { get; set; } = 0;
        //public Type _type;
        //public string Type { get => _type?.Name; set => _type = System.Type.GetType($"System.{value}"); }
        public string Type { get; set; }
        public string Note { get; set; }
        public Dictionary<string, PixelMap> Maps { get; set; }
        public Dictionary<string, PixelColor> Colors { get; set; }

        public string Script { get; set; }
    }

    public static class PixelFactory
    {
        public static Pixel<T> Create<T>(int width, int height) where T : struct, IComparable
        {
            return Create<T>(width, height, new T[width * height]);
        }

        public static Pixel<T> Create<T>(int width, int height, T[] src) where T : struct, IComparable
        {
            var dst = new Pixel<T>(width, height);
            dst.pixel = src;
            return dst;
        }


        public static Pixel<T> Create<T>(Dictionary<string, PixelMap> maps) where T : struct, IComparable
        {
            var i = new Pixel<T>();
            i.Maps = maps;
            i.Type = typeof(T).Name;
            i.Clear();
            return i;
        }
        public static Pixel<T> Create<T>(Dictionary<string, PixelMap> maps, T[] src) where T : struct, IComparable
        {
            var i = new Pixel<T>();
            i.Maps = maps;
            i.Type = typeof(T).Name;
            i.pixel = src;
            return i;
        }


        public static Pixel<T> Create<T>(List<PixelFormat> formats, string filename) where T : struct, IComparable
        {
            //ファイルの一致
            foreach (var i in formats)
            {
                if (Check(i))
                {
                    switch(i.Type)
                    {
                        case "Bmp":
                            return PixelStream.ReadBMP<T>(filename);
                        default:
                            return PixelStream.Read(Make<T>(i), filename, i.Offset, i.Type);
                    }
                }
            }
            throw new KeyNotFoundException("Mismatched file format");

            /***********/
            bool Check(PixelFormat hoge)
            {
                foreach (var j in hoge.FileName)
                {
                    Regex r = new Regex(j, RegexOptions.IgnoreCase);
                    Match m = r.Match(filename);
                    if (m.Success) return true;
                }
                return false;
            }

            Pixel<TT> Make<TT>(PixelFormat hoge) where TT : struct, IComparable
            {
                var dst = hoge.Maps != null ?  
                    Create<TT>(hoge.Maps) :
                    Create<TT>(hoge.Width, hoge.Height);

                if (hoge.Colors != null)
                    dst.Colors = hoge.Colors;

                return dst;
            }


        }

    }
}
