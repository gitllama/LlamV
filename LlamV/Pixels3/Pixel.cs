using Pixels.Math;
using Pixels.Stream;
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

namespace Pixels
{
    #region Operator

    using Binary = Func<ParameterExpression, ParameterExpression, BinaryExpression>;
    using Unary = Func<ParameterExpression, UnaryExpression>;

    internal static class Operator<T>
    {
        static readonly ParameterExpression x = Expression.Parameter(typeof(T), "x");
        static readonly ParameterExpression y = Expression.Parameter(typeof(T), "y");
        static readonly ParameterExpression z = Expression.Parameter(typeof(T), "z");
        static readonly ParameterExpression w = Expression.Parameter(typeof(T), "w");
        static readonly ParameterExpression i = Expression.Parameter(typeof(int), "i");

        //public static readonly Func<T, U> Cast<U> = LambdaCast<U>(Expression.Convert);

        public static readonly Func<T, T> Plus = Lambda(Expression.UnaryPlus);
        public static readonly Func<T, T> Negate = Lambda(Expression.Negate);

        public static readonly Func<T, T, T> Add = Lambda(Expression.Add);
        public static readonly Func<T, T, T> Subtract = Lambda(Expression.Subtract);
        public static readonly Func<T, T, T> Multiply = Lambda(Expression.Multiply);
        public static readonly Func<T, T, T> Divide = Lambda(Expression.Divide);

        public static readonly Func<T, int, T> LeftShift = LambdaInt(Expression.LeftShift);
        public static readonly Func<T, int, T> RightShift = LambdaInt(Expression.RightShift);
        //public static readonly Func<T, T, T> And = Lambda(Expression.And);
        //public static readonly Func<T, T, T> Or = Lambda(Expression.Or);

        public static Func<T, U> LambdaCast<U>(Unary op) => Expression.Lambda<Func<T, U>>(op(x), x).Compile();
        public static Func<T, T> Lambda(Unary op) => Expression.Lambda<Func<T, T>>(op(x), x).Compile();
        public static Func<T, T, T> Lambda(Binary op) => Expression.Lambda<Func<T, T, T>>(op(x, y), x, y).Compile();
        public static Func<T, int, T> LambdaInt(Binary op) => Expression.Lambda<Func<T, int, T>>(op(x, i), x, i).Compile();

        public static readonly Func<T, T, T, T, T> ProductSum =
            Expression.Lambda<Func<T, T, T, T, T>>(
                Expression.Add(
                    Expression.Multiply(x, y),
                    Expression.Multiply(z, w)),
                x, y, z, w).Compile();

        public static readonly Func<T, T, T, T, T> ProductDifference =
            Expression.Lambda<Func<T, T, T, T, T>>(
                Expression.Subtract(
                    Expression.Multiply(x, y),
                    Expression.Multiply(z, w)),
                x, y, z, w).Compile();

    }

    #endregion

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

    public interface IBinaryOperator<T1, TResult>
    {
        TResult Operate(T1 x);
    }
    public interface IBinaryOperator<T1, T2, TResult>
    {
        TResult Operate(T1 x, T2 y);
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

        public int Left { get; protected set; } = 0;
        public int Top { get; protected set; } = 0;
        public int Width { get; protected set; } = 1;
        public int Height { get; protected set; } = 1;

        public int Size { get => Width * Height; }

        public ref T this[int value] { get => ref pixel[value]; }

        public ref T this[int x, int y] { get => ref pixel[ConvPoisonMap(x, y)]; }
        public int ConvPoisonMap(int x, int y) => (x + Left) + (y + Top) * Stride;
        public (int x, int y) ConvPoisonMap(int index) => ((index % Stride) - Left, (index / Stride) - Top);

        public Dictionary<string, PixelColor> Colors { get; set; }

        public ref T this[string color, int x, int y] { get => ref pixel[ConvPoisonColor(color, x, y)]; }
        public int ConvPoisonColor(string color, int x, int y)
        {
            var c = Colors[color];
            return GetLeft(color) + x * c.step_x + (GetTop(color) + y * Colors[color].step_y) * Stride;
        }


        public string Map { get; protected set; } = "Full";
        public Pixel<T> this[string map] => SetMap(map);
        public Pixel<T> SetMap(string value)
        {
            Map = value;
            Left = Maps[value].Left;
            Top  = Maps[value].Top;
            Width = Maps[value].Width;
            Height = Maps[value].Height;

            return this;
        }

        public void AddMap(string key,int left, int top, int width,int height)
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

        public (int Left,int Top,int Width,int Height) GetMap(string key = null)
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



        //public (int Left, int Top, int Width, int Height,int StepX, int StepY) GetColor(string key = null)
        //{
        //    return
        //    (
        //        Left + Colors[key].x,
        //        Top + Colors[key].y,
        //        Width + Left,
        //        Height + Top,
        //        Colors[key].step_x,
        //        Colors[key].step_y
        //    );
        //}

        public Pixel(){  }
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

        public Pixel<T> Cancellation(CancellationTokenSource token)
        {
            this.token = token;
            return this;
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

                if(alldata && this.pixel != null)
                {
                    var i = new T[this.pixel.Length];
                    ((T[])pixel).CopyTo(i,0);
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



        /******/

        #region Accumulate

        //メソッドチェーン3つ以降は、デリゲートのオーバヘッドよりFuncでまとめたほうが速い

        public Pixel<T> AccSelf(Func<T, T> func) => Acc(func, this);
        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func)
            where TResult : struct, IComparable
            => Acc(func, this.Clone<TResult>());

        public Pixel<TResult> Acc<TResult>(Func<T, TResult> func, Pixel<TResult> dst)
            where TResult : struct, IComparable
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    dst.pixel[i] = func(this.pixel[i]);
            }
            else
            {
                for (int y = 0; y < this.Height; y++)
                    for (int x = 0; x < this.Width; x++)
                        dst[x, y] = func(this[x, y]);
            }
            return dst;
        }

        public Pixel<TResult> Acc<T1, TResult>(Pixel<T1> src, Func<T, T1, TResult> func, Pixel<TResult> dst)
            where T1 : struct, IComparable
            where TResult : struct, IComparable
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    dst.pixel[i] = func(this.pixel[i], src.pixel[i]);
            }
            else
            {
                for (int y = 0; y < this.Height; y++)
                    for (int x = 0; x < this.Width; x++)
                        dst[x, y] = func(this[x, y], src[x, y]);
            }
            return dst;
        }

        public Pixel<TResult> Accumulate<TResult, TOperator>(Pixel<TResult> dst, TOperator op)
            where TResult : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, TResult>
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    dst.pixel[i] = op.Operate(this.pixel[i]);
            }
            else
            {
                for (int y = 0; y < this.Height; y++)
                    for (int x = 0; x < this.Width; x++)
                        dst[x, y] = op.Operate(this[x, y]);
            }
            return dst;
        }
        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(Pixel<TResult> dst, T1 value, TOperator op)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    dst.pixel[i] = op.Operate(this.pixel[i], value);
            }
            else
            {
                for (int y = 0; y < this.Height; y++)
                    for (int x = 0; x < this.Width; x++)
                        dst[x, y] = op.Operate(this[x, y], value);
            }
            return dst;
        }
        public Pixel<TResult> Accumulate<T1, TResult, TOperator>(Pixel<TResult> dst, Pixel<T1> src2, TOperator op)
            where TResult : struct, IComparable
            where T1 : struct, IComparable
            where TOperator : struct, IBinaryOperator<T, T1, TResult>
        {
            if (this.Map == "Full")
            {
                for (int i = 0; i < this.pixel.Length; i++)
                    dst.pixel[i] = op.Operate(this.pixel[i], src2.pixel[i]);
            }
            else
            {
                for (int y = 0; y < this.Height; y++)
                    for (int x = 0; x < this.Width; x++)
                        dst[x, y] = op.Operate(this[x, y], src2[x, y]);
            }
            return dst;
        }

        #endregion

        /*****/



        public IEnumerable<int> GetIndex()
        {
            //MoveNext() や Current などのメソッド呼び出しのオーバーヘッドがかかる
            //のでデリゲートの方が実行効率が上がる

            //ループは少ない方が早い

            if (Map != "Full")
            {
                var e = pixel.Length;
                for (int i = 0; i < e; i++)
                {
                    yield return i;
                }
            }
            else
            {
                int c = Left + Top * Stride;
                int inc = Stride - Width;
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        yield return c;
                        c++;
                    }
                    c += inc;
                }
            }
        }
        public IEnumerable<int> GetIndex(string color) //, int dimension
        {
            int l = GetLeft(color);
            int t = GetTop(color);
            int c = l + t * Stride;

            int w = GetWidth(color);
            int h = GetHeight(color);

            int inc_col = Colors[color].step_x;
            int inc_line = 
                Stride - w * Colors[color].step_x 
                + Stride * (Colors[color].step_y - 1);

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    yield return c;
                    c += inc_col;
                }
                c += inc_line;
            }
        }

        public IEnumerable<int> GetIndexX(string color)
        {
            int l = GetLeft(color);
            int w = GetWidth(color);

            int inc_col = Colors[color].step_x;
            int c = l;
            for (int x = 0; x < w; x++)
            {
                yield return c;
                c += inc_col;
            }
        }
        public IEnumerable<int> GetIndexY(string color)
        {
            int t = GetTop(color);
            int h = GetHeight(color);

            int inc_line = Stride * (Colors[color].step_y);

            int c = t * Stride;
            for (int y = 0; y < h; y++)
            {
                yield return c;
                c += inc_line;
            }
        }

        public IEnumerable<(int center, int left,int right, int top, int bottom, int lefttop, int righttop, int leftbottom, int rightbottom)>
            GetIndexPlus(string color)
        {
            int l = GetLeft(color);
            int t = GetTop(color);
            int c = l + t * Stride;

            int w = GetWidth(color);
            int h = GetHeight(color);

            int inc_col = Colors[color].step_x;
            int inc_line =
                Stride - w * Colors[color].step_x
                + Stride * (Colors[color].step_y - 1);

            int line = Stride * Colors[color].step_y;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    yield return
                    (
                        c,
                        c - inc_col,
                        c + inc_col,
                        c - line,
                        c + line,
                        c - inc_col - line,
                        c + inc_col - line,
                        c - inc_col + line,
                        c + inc_col + line
                    );
                    c += inc_col;
                }
                c += inc_line;
            }
        }


        public int GetCount() => Width * Height;
        public int GetCount(string color) => color == null ? GetCount() : GetWidth(color) * GetHeight(color);

        public int GetLeft(string color) => Left + Colors[color].step_x - 1 - (Left + Colors[color].step_x - Colors[color].x - 1) % Colors[color].step_x;
        public int GetTop(string color) => Top + Colors[color].step_y - 1 - (Top + Colors[color].step_y - Colors[color].y - 1) % Colors[color].step_y;
        public int GetWidth(string color) 
            => (Left + Width + (Colors[color].step_x - Colors[color].x - 1)) / Colors[color].step_x
             - (Left + (Colors[color].step_x - Colors[color].x - 1)) / Colors[color].step_x;
        public int GetHeight(string color) 
            => (Top + Height + (Colors[color].step_y - Colors[color].y - 1)) / Colors[color].step_y
             - (Top + (Colors[color].step_y - Colors[color].y - 1)) / Colors[color].step_y;

        public int GetSize(string color)
        {
            return GetWidth(color) * GetHeight(color);
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


        #region Operator

        //ラッパー
        //static T Cast(T x) { return Operator<T>.Negate(x); }

        static T Add(T x, T y) { return Operator<T>.Add(x, y); }
        static T Sub(T x, T y) { return Operator<T>.Subtract(x, y); }
        static T Mul(T x, T y) { return Operator<T>.Multiply(x, y); }
        static T Div(T x, T y) { return Operator<T>.Divide(x, y); }
        static T Neg(T x) { return Operator<T>.Negate(x); }
        //static T Acc(T x, T y, T z, T w) { return Operator<T>.ProductSum(x, y, z, w); }
        //static T Det(T x, T y, T z, T w) { return Operator<T>.ProductDifference(x, y, z, w); }
        //static T Norm(T x, T y) { return Operator<T>.ProductSum(x, y, x, y); }
        static T LeftShift(T x, int y) { return Operator<T>.LeftShift(x, y); }
        static T RightShift(T x, int y) { return Operator<T>.RightShift(x, y); }
        //static T And(T x, T y) { return Operator<T>.And(x, y); }
        //static T Or(T x, T y) { return Operator<T>.Or(x, y); }

        public static Pixel<T> operator +(Pixel<T> x, Pixel<T> y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Add(x.pixel[i], y.pixel[i])).ToArray());
        public static Pixel<T> operator +(T x, Pixel<T> y)
            => PixelFactory.Create<T>(y.Maps, (new T[y.pixel.Length]).Select((v, i) => v = Add(x, y.pixel[i])).ToArray());
        public static Pixel<T> operator +(Pixel<T> x, T y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Add(x.pixel[i], y)).ToArray());

        public static Pixel<T> operator -(Pixel<T> x)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Neg(x.pixel[i])).ToArray());

        public static Pixel<T> operator -(Pixel<T> x, Pixel<T> y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Sub(x.pixel[i], y.pixel[i])).ToArray());
        public static Pixel<T> operator -(T x, Pixel<T> y)
            => PixelFactory.Create<T>(y.Maps, (new T[y.pixel.Length]).Select((v, i) => v = Sub(x, y.pixel[i])).ToArray());
        public static Pixel<T> operator -(Pixel<T> x, T y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Sub(x.pixel[i], y)).ToArray());

        public static Pixel<T> operator *(Pixel<T> x, Pixel<T> y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Mul(x.pixel[i], y.pixel[i])).ToArray());
        public static Pixel<T> operator *(T x, Pixel<T> y)
            => PixelFactory.Create<T>(y.Maps, (new T[y.pixel.Length]).Select((v, i) => v = Mul(x, y.pixel[i])).ToArray());
        public static Pixel<T> operator *(Pixel<T> x, T y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Mul(x.pixel[i], y)).ToArray());

        public static Pixel<T> operator /(Pixel<T> x, Pixel<T> y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Div(x.pixel[i], y.pixel[i])).ToArray());
        public static Pixel<T> operator /(T x, Pixel<T> y)
            => PixelFactory.Create<T>(y.Maps, (new T[y.pixel.Length]).Select((v, i) => v = Div(x, y.pixel[i])).ToArray());
        public static Pixel<T> operator /(Pixel<T> x, T y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Div(x.pixel[i], y)).ToArray());

        public static Pixel<T> operator <<(Pixel<T> x, int y)
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = LeftShift(x.pixel[i], y)).ToArray());
        public static Pixel<T> operator >>(Pixel<T> x, int y)
           => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = RightShift(x.pixel[i], y)).ToArray());
        #endregion


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
