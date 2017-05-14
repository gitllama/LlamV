using Pixels;
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
    }

    public static class PixelFactory
    {
        public static Pixel<T> Create<T>(this Pixel<T> src) where T : struct, IComparable
        {
            src = src["Full"];
            src.Stride = src.Width;
            src.pixel = new T[src.Width * src.Height];
            return src;
        }
        public static Pixel<T> Create<T>(Dictionary<string, PixelMap> maps) where T : struct, IComparable
        {
            var i = new Pixel<T>();
            i.Maps = maps;
            i.Type = typeof(T).Name;
            i.Create();
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
        public static Pixel<T> Create<T>(int width, int height) where T : struct, IComparable
        {
            return Create<T>(width, height, new T[width * height]);
        }

        public static Pixel<T> Create<T>(int width, int height, T[] src) where T : struct, IComparable
        {
            return (new Pixel<T>()
            {
                Width = width,
                Height = height,
                Stride = width,
                Maps = new Dictionary<string, PixelMap>()
                {
                    ["Full"] = new PixelMap()
                    {
                        Left = 0,
                        Top = 0,
                        Width = width,
                        Height = height
                    }
                },
                pixel = src
            });
        }

        public static Pixel<T> Create<T>(List<PixelFormat> formats, string filename) where T : struct, IComparable
        {
            //ファイルの一致
            foreach (var i in formats)
            {
                if (Check(i))
                {
                    //ファイルの読み込み
                    return PixelStream.Read((dynamic)Make<T>(i), filename, i.Offset, i.Type);
                }
            }
            throw new KeyNotFoundException("一致するファイル形式がありません");

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
                if (hoge.Maps != null)
                {
                    return Create<TT>(hoge.Maps);
                }
                else
                {
                    return Create<TT>(hoge.Width, hoge.Height);
                }
            }
        }
    }
}
