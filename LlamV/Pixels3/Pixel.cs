using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

using Pixels.Stream;

namespace Pixels
{
    [Serializable]
    public class PixelMap
    {
        public int Left { get; set; } = 0;
        public int Top { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;
    }

    [Serializable]
    public class PixelColor
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public int step_x { get; set; } = 0;
        public int step_y { get; set; } = 0;
    }

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


    [Serializable]
    public partial class Pixel<T> where T : struct, IComparable
    {
        [NonSerialized]
        public T[] pixel;

        public Type _type;
        public string Type { get => _type?.Name; set => _type = System.Type.GetType($"System.{value}"); }

        [NonSerialized]
        public CancellationTokenSource token;

        public Dictionary<string, PixelMap> Maps { get; set; }

        public int Stride { get; protected set; } = 1;

        public int FullSize { get => pixel.Length; }

        public int Left { get; protected set; } = 0;
        public int Top { get; protected set; } = 0;
        public int Width { get; protected set; } = 1;
        public int Height { get; protected set; } = 1;
        public int StepX { get; protected set; } = 1;
        public int StepY { get; protected set; } = 1;



        public int Size { get => Width * Height; }

        public ref T this[int value] { get => ref pixel[value]; }

        public ref T this[int x, int y] { get => ref pixel[ConvPoisonMap(x, y)]; }

        public int ConvPoisonMap(int x, int y) => (x + Left) + (y + Top) * Stride;
        public (int x, int y) ConvPoisonMap(int index) => ((index % Stride) - Left, (index / Stride) - Top);


        public Dictionary<string, PixelColor> Colors { get; set; }

        public string Map { get; protected set; } = "Full";
        public string[] Color { get; protected set; } = null;

        public Pixel<T> this[string map] => SetMap(map, null);
        public Pixel<T> this[string map, params string[] colors] => SetMap(map, colors);
        public Pixel<T> SetMap(string map, params string[] colors)
        {
            Map = map;

            if ((colors?.Length ?? 0) > 0)
            {
                var color = colors[0];
                Left = Maps[map].Left + Colors[color].step_x - 1 - (Maps[map].Left + Colors[color].step_x - Colors[color].x - 1) % Colors[color].step_x;
                Top = Maps[map].Top + Colors[color].step_y - 1 - (Maps[map].Top + Colors[color].step_y - Colors[color].y - 1) % Colors[color].step_y;

                Width = (Maps[map].Left + Maps[map].Width + (Colors[color].step_x - Colors[color].x - 1)) / Colors[color].step_x
                 - (Maps[map].Left + (Colors[color].step_x - Colors[color].x - 1)) / Colors[color].step_x;
                Height = (Maps[map].Top + Maps[map].Height + (Colors[color].step_y - Colors[color].y - 1)) / Colors[color].step_y
                             - (Maps[map].Top + (Colors[color].step_y - Colors[color].y - 1)) / Colors[color].step_y;

                StepX = Colors[color].step_x;
                StepY = Colors[color].step_y;
            }
            else
            {
                Left = Maps[map].Left;
                Top = Maps[map].Top;

                Width = Maps[map].Width;
                Height = Maps[map].Height;

                StepX = 1;
                StepY = 1;
            }


            Color = colors;
            return this;
        }


        public void AddMap(string key, int left, int top, int width, int height)
        {
            if (key == "Full") return;
            Maps[key] = new PixelMap()
            {
                Left = left,
                Top = top,
                Width = width,
                Height = height
            };
        }


        public (int Left, int Top, int Width, int Height) GetMap(string key = null)
        {
            var i = key ?? Map;

            //if(Maps.ContainsKey(i))
            //{
            //    return (null,null,null,null);
            //}

            return
            (
                Maps[i].Left,
                Maps[i].Top,
                Maps[i].Width,
                Maps[i].Height
            );
        }


        public Pixel() { }
        public Pixel(int width, int height)
        {
            Maps = new Dictionary<string, PixelMap>()
            {
                ["Full"] = new PixelMap()
                {
                    Left = 0,
                    Top = 0,
                    Width = width,
                    Height = height
                }
            };
            this.Stride = Maps["Full"].Width;
        }

        //deepcopy
        public Pixel<T> Clone(bool alldata = true)
        {
            using (var memoryStream = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(memoryStream, this); // シリアライズ
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                var dst = (Pixel<T>)formatter.Deserialize(memoryStream); // デシリアライ

                if (alldata && this.pixel != null)
                {
                    var i = new T[this.pixel.Length];
                    ((T[])pixel).CopyTo(i, 0);
                    dst.pixel = i;
                }

                return dst;
            }
        }
        public Pixel<U> Clone<U>() where U : struct, IComparable
        {
            var w = this.Maps["Full"].Width;
            var h = this.Maps["Full"].Height;
            var dst = PixelFactory.Create<U>(w, h, new U[w * h]);

            dst.Maps = this.Maps;
            dst.Colors = this.Colors;

            return dst[Map];
        }

        public Pixel<T> Cancellation(CancellationTokenSource token)
        {
            this.token = token;
            return this;
        }




        /// <summary>
        /// 配列の定義し直し
        /// </summary>
        /// <returns></returns>
        public Pixel<T> Clear()
        {
            this.Stride = Maps["Full"].Width;
            this.pixel = new T[Maps["Full"].Width * Maps["Full"].Height];

            return this["Full"];
        }

        #region チェック

        protected static void OperatorCheck(Pixel<T> x, Pixel<T> y)
        {
            if (x.Width != y.Width)
                throw new ArgumentOutOfRangeException("OperatorCheck");
            if (x.Height != y.Height)
                throw new ArgumentOutOfRangeException("OperatorCheck");

        }

        public bool IsNaN<Tin>()
        {
            //Func<T, bool> IsNaN;

            //if (typeof(Tin) == typeof(float)) IsNaN = (n) => float.IsNaN((dynamic)n);
            //else if (typeof(Tin) == typeof(double)) IsNaN = (n) => double.IsNaN((dynamic)n);
            //else throw new ArgumentOutOfRangeException("typeof");

            //for (int i = 0; i < this.Size; i++)
            //    if (IsNaN(this[i])) return true;

            return false;
        }
        public bool IsInfinity<Tin>()
        {
            //Func<T, bool> IsInfinity;

            //if (typeof(Tin) == typeof(float)) IsInfinity = (n) => float.IsInfinity((dynamic)n);
            //else if (typeof(Tin) == typeof(double)) IsInfinity = (n) => double.IsInfinity((dynamic)n);
            //else throw new ArgumentOutOfRangeException("typeof");

            //for (int i = 0; i < this.Size; i++)
            //    if (IsInfinity(this[i])) return true;

            return false;
        }


        #endregion
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
                    switch (i.Type)
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