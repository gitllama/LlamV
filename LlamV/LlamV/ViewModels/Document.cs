using Autofac;
using AvalonDockUtil;
using Prism.Commands;
using Prism.Mvvm;
using LlamV;
using LlamV.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Media.Imaging;

using Pixels;
using Pixels.Extend;
using Prism.Interactivity.InteractionRequest;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using System.Reactive.Disposables;
using System.ComponentModel;
using LlamV.Behavior;
using YamlDotNet.Serialization;

namespace LlamV.ViewModels
{
    public class Document : DocumentContent, IDisposable
    {
        #region MyRegion

        [Browsable(false)]
        public Model model { get; private set; }
        //直接Binding ScalingMode
        //直接Binding Background

        public ReactiveProperty<string> FileName { get; private set; }

        [Browsable(false)]
        public ReactiveProperty<WriteableBitmap> img { get; private set; }

        [Browsable(false)]  //あとしまつ
        private CompositeDisposable Disposable { get; } = new CompositeDisposable();

        //public ReactiveProperty<Rect> Rect { get; private set; }

        #endregion

        [Browsable(false)]
        public ReactiveProperty<double> Width { get; private set; }
        [Browsable(false)]
        public ReactiveProperty<double> Height { get; private set; }
        [Browsable(false)]
        public ReactiveProperty<double> Scale { get; private set; }

        public Point _ScrollBar;
        [Browsable(false)]
        public ReactiveProperty<Point> ScrollBar { get; private set; }

        [Browsable(false)]
        public ReactiveProperty<bool> isLinkage { get; private set; }

        public ReactiveProperty<double> MouseWheel { get; private set; }

        public ReactiveProperty<List<Shape>> Shapes { get; private set; }
        [Browsable(false)]
        public ReactiveProperty<Point> MouseMove { get; private set; }
        [Browsable(false)]
        public ReactiveProperty<Rect> RectMove { get; private set; }

        [Browsable(false)]
        public ReactiveProperty<Brush> Background { get; private set; }

        #region Command

        public ReactiveCommand FileDropCommand { get; private set; }

        public ReactiveCommand ReLoadCommand { get; private set; }
        public ReactiveCommand ReLoadAndRunCommand { get; private set; }
        public ReactiveCommand ScriptRunCommand { get; private set; }

        public ReactiveCommand<string> CaptureCommand { get; private set; }
        public ReactiveCommand<string> RawSaveCommand { get; private set; }
        public ReactiveCommand<string> CSVCommand { get; private set; }
        public ReactiveCommand<string> ShortcutCommand { get; private set; }

        #endregion

        public Document() : base()
        {
            model = App.Container.Resolve<Model>();
            model.Add(this);//自分でmodelに登録しにいく


            #region MyRegion
            //タイトル
            FileName = model
                .ObserveProperty(x => x.DocumentDatas)
                .Select(x => x.ContainsKey(this.ContentId) ? x[this.ContentId].FileNames : null)
                .ToReactiveProperty().AddTo(this.Disposable);
            FileName.Subscribe(x =>
            {
                Title = x != null ? $"{System.IO.Path.GetFileName(x)}({x})" : "null";
            }).AddTo(this.Disposable);

            isLinkage = model.ObserveProperty(x => x.isLinkage).ToReactiveProperty().AddTo(this.Disposable);

            //MouseWheel = model.ToReactivePropertyAsSynchronized(
            //    x => x.Scale,
            //    convert: x => (int)Math.Log(x, 2),
            //    convertBack: x => Math.Pow(2, x))
            //    .AddTo(this.Disposable);
            MouseWheel = model.ToReactivePropertyAsSynchronized(
                x => x.Scale,
                convert: x => x,
                convertBack: x => x)
                .AddTo(this.Disposable);

            ScrollBar = model.ToReactivePropertyAsSynchronized(
                x => x.ScrollBar,
                convert: x => { _ScrollBar = x; return x; },
                convertBack: x => isLinkage.Value == true ? x : _ScrollBar)
                .AddTo(this.Disposable);

            Scale = model.ObserveProperty(x => x.Scale).Where(_ => isLinkage.Value == true).ToReactiveProperty().AddTo(this.Disposable);


            img = model.ObserveProperty(x => x.DocumentDatas)
                .Select(x => x.ContainsKey(this.ContentId)? x[this.ContentId].Images : null)
                .ToReactiveProperty().AddTo(this.Disposable);

            Width = img.CombineLatest(Scale, (x, y) => (x?.PixelWidth ?? 0) * y).ToReactiveProperty().AddTo(this.Disposable);
            Height = img.CombineLatest(Scale, (x, y) => (x?.PixelHeight ?? 0) * y).ToReactiveProperty().AddTo(this.Disposable);

            #endregion


            MouseMove = new ReactiveProperty<Point>().AddTo(this.Disposable);
            RectMove = model.ToReactivePropertyAsSynchronized(x => x.Rect).AddTo(this.Disposable);

            Shapes = MouseMove.CombineLatest(RectMove, (x, y) =>
            {
                var i = new List<Shape>();
                DrawL(i, x);
                DrawShift(i, y);
                return i;
            }).ToReactiveProperty().AddTo(this.Disposable);

            Background = model
                .ObserveProperty(x => x.Background)
                .Select(x => (Brush)(new SolidColorBrush(x)))
                .ToReactiveProperty().AddTo(this.Disposable);


            #region Command

            FileDropCommand = new ReactiveCommand().AddTo(this.Disposable);
            FileDropCommand.Subscribe(x =>
            {
                var i = x as string[];
                model.ReadFile(i[0], this.ContentId);
            }).AddTo(this.Disposable);

            ReLoadCommand = new ReactiveCommand().AddTo(this.Disposable);
            ReLoadCommand.Subscribe(x => model.ReLoad(this.ContentId)).AddTo(this.Disposable);

            ReLoadAndRunCommand = new ReactiveCommand().AddTo(this.Disposable);
            ReLoadAndRunCommand.Subscribe(x => model.ReLoad(this.ContentId, true)).AddTo(this.Disposable);

            ScriptRunCommand = new ReactiveCommand().AddTo(this.Disposable);
            ScriptRunCommand.Subscribe(x =>
            {
                model.ScriptRun(this.ContentId);
                model.Developing(this.ContentId);
            }).AddTo(this.Disposable);

            ShortcutCommand = new ReactiveCommand<string>().AddTo(this.Disposable);
            ShortcutCommand.Subscribe(x =>
            {
                model.Shortcut(this.ContentId, x);
            }).AddTo(this.Disposable);

            CaptureCommand = new ReactiveCommand<string>().AddTo(this.Disposable);
            CaptureCommand.Subscribe(x =>
            {
                switch(x)
                {
                    case "FullToFile":
                        model.DocumentDatas[this.ContentId].Images.Save(DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                        break;
                    //case "SelectedToFile":
                    //    model.DocumentDatas[this.ContentId]["Trim"].Images.Save(DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                    //    break;
                    case "FullToClipbord":
                        model.DocumentDatas[this.ContentId].Images.ToClipboard();
                        break;
                    //case "SelectedToClipbord":
                    //    model.DocumentDatas[this.ContentId].Images.ToClipboard();
                    //    break;
                    default:
                        break;
                }
            }).AddTo(this.Disposable);
            RawSaveCommand = new ReactiveCommand<string>().AddTo(this.Disposable);
            RawSaveCommand.Subscribe(x =>
            {
                switch (x)
                {
                    case "FullToFile":
                        model.DocumentDatas[this.ContentId].Images.Save(DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                        break;
                    case "SelectedToFile":
                        //model.DocumentDatas[this.ContentId]["Trim"].Images.Save(DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                        break;
                    //case "FullToClipbord":
                    //    model.DocumentDatas[this.ContentId].Images.ToClipboard();
                    //    break;
                    //case "SelectedToClipbord":
                    //    model.DocumentDatas[this.ContentId].Images.ToClipboard();
                    //    break;
                    default:
                        break;
                }
            }).AddTo(this.Disposable);
            CSVCommand = new ReactiveCommand<string>().AddTo(this.Disposable);
            CSVCommand.Subscribe(x =>
            {
                switch (x)
                {
                    case "FullToFile":

                        break;
                    case "SelectedToFile":
                        //model.DocumentDatas[this.ContentId]["Trim"].Images.Save(DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");
                        break;
                    case "FullToClipbord":
                        model.ClipText(this.ContentId, false);
                        break;
                    case "SelectedToClipbord":
                        model.ClipText(this.ContentId, true);
                        break;
                    default:
                        break;
                }
            }).AddTo(this.Disposable);
            
            #endregion

        }


        //..Take(1)
        public void DrawL(List<Shape> a, Point x)
        {
            var c = Colors.Red;
            var f = Colors.Red;
            f.A = 30;

            //値は取得できたら
            if (!model.DocumentDatas.ContainsKey(this.ContentId)) return;
            if (model.DocumentDatas[this.ContentId].raws == null) return;
            var buf = model.DocumentDatas[this.ContentId].raws;


            if (!buf.Maps.ContainsKey("Full")) return;
            if (x.X >= buf["Full"].Width) return;
            if (x.Y >= buf["Full"].Height) return;

            var lsb = buf["Full"][(int)(x.X), (int)(x.Y)].ToString() ?? "";

            a.Add(new Shape()
            {
                Key = "Text",
                Left = (int)(x.X + 1),
                Top = (int)(x.Y + 1),// - 16 / Scale.Value,
                Size = 16,
                Text = $"({(int)(x.X)},{(int)(x.Y)})\r\n{lsb}"
            });
            a.Add(new Shape()
            {
                Key = "Rect",
                Left = (int)x.X,
                Top = (int)x.Y,
                Width = 1,
                Height = 1,
                Brush = c,
                Fill = f
            });
        }
        public void DrawShift(List<Shape> a, Rect x)
        {
            if (x.Width < 1 || x.Height < 1) return;

            var c = Colors.Blue;
            var f = Colors.Blue;
            f.A = 50;
            a.Add(new Shape()
            {
                Key = "Text",
                Left = x.Right,
                Top = x.Bottom,
                Size = 16,
                Text = $"({x.TopLeft})\r\nw:{x.Width}\r\nh:{x.Height}",
                Brush = c
            });
            a.Add(new Shape()
            {
                Key = "Rect",
                Left = x.Left,
                Top = x.Top,
                Width = x.Width,
                Height = x.Height,
                Size = 16,
                Brush = c,
                Fill = f
            });
        }

        public override void Close() => this.Disposable.Dispose();

        public void Dispose()
        {
            this.Disposable.Dispose();
        }
    }

}


//if (ii == null)
//{
//    NotificationRequest.Raise(new Notification
//    {
//        Content = "Notification Message",
//        Title = "Notification"
//    });
//}
//else
//{
//    imgmodel.ReadFile(ii, i[0]);
//}