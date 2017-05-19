﻿using Pixels.Math;
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

    public class PixelMap
    {
        public int Left { get; set; } = 0;
        public int Top { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;
    }
    public class PixelColor
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public int step_x { get; set; } = 0;
        public int step_y { get; set; } = 0;
    }
    public partial class  Pixel<T> where T : struct, IComparable
    {
        public T[] pixel;

        public Type _type;
        public string Type { get => _type?.Name; set => _type = System.Type.GetType($"System.{value}"); }

        public CancellationTokenSource token;

        public Dictionary<string, PixelMap> Maps { get; set; }
        public int Stride { get; set; } = 1;

        public int Left { get; set; } = 0;
        public int Top { get; set; } = 0;
        public int Width { get; set; } = 1;
        public int Height { get; set; } = 1;

        public ref T this[int value] { get => ref pixel[value]; }

        public ref T this[int x, int y] { get => ref pixel[ConvPoisonMap(x, y)]; }
        public int ConvPoisonMap(int x,int y) => (x + Left) + (y + Top) * Stride;

        public List<PixelColor> Colors { get; set; }
        public int WidthColor(int color) => (Width - Colors[color].x) / Colors[color].step_x;
        public int HeightColor(int color) => (Height - Colors[color].y) / Colors[color].step_y;
        public int BayerX { get; set; } = 0;
        public int BayerY { get; set; } = 0;

        /// <summary>
        /// Mapsによってズレマスよ
        /// </summary>
        /// <param name="color"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ref T this[int color, int x, int y] { get => ref pixel[ConvPoisonColor(color, x, y)]; }
        public int ConvPoisonColor(int color, int x, int y)
        {
            var c = Colors[color];
            return
                ((x * c.step_x + c.x) + Left) +
                ((y * c.step_y + c.y) + Top) * Stride;
        }


        public string Map { get; private set; } = "Full";
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
        public (int Left,int Top,int Width,int Height) GetMap(string key)
        {
            var i = key ?? Map;

            //if(Maps.ContainsKey(i))
            //{
            //    return (null,null,null,null);
            //}

            return
            (
                Left = Maps[i].Left,
                Top = Maps[i].Top,
                Width = Maps[i].Width,
                Height = Maps[i].Height
            );
        }
        public Pixel(){  }





        public Pixel<T> Cancellation(CancellationTokenSource token)
        {
            this.token = token;
            return this;
        }

        //deepcopyに書き換え
        public Pixel<T> Clone()
        {
            var i = PixelFactory.Create(Maps["Full"].Width, Maps["Full"].Height, (T[])pixel.Clone());
            i.Maps = Maps;
            i.Type = Type;

            //マップ合わせ
            i.SetMap(Map);
            i.Colors = this.Colors;

            return i;
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
            => PixelFactory.Create<T>(x.Maps, (new T[x.pixel.Length]).Select((v, i) => v = Add(x.pixel[i],y.pixel[i])).ToArray());
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

}
