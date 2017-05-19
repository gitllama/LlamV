using AvalonDockUtil;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

using System.Windows.Media;
using System.Collections.ObjectModel;
using Prism.Commands;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows;
using YamlDotNet.Serialization;

using Pixels;
using Pixels.Math;
using Pixels.Extend;
using Pixels.Stream;

namespace LlamV.Models
{
    public abstract class WorkspaceBaseModel : BindableBase
    {
        ObservableCollection<DocumentContent> _Documents;
        public ObservableCollection<DocumentContent> Documents
        {
            get
            {
                if (_Documents == null) _Documents = new ObservableCollection<DocumentContent>();
                return _Documents;
            }
        }

        ObservableCollection<ToolContent> _Tools;
        public ObservableCollection<ToolContent> Tools
        {
            get
            {
                if (_Tools == null) _Tools = new ObservableCollection<ToolContent>();
                return _Tools;
            }
        }

        private DocumentContent _ActiveDocument;
        public DocumentContent ActiveDocument { get => _ActiveDocument; set => SetProperty(ref _ActiveDocument, value); }

        public virtual DocumentContent NewDocument() => new DocumentContent();

        public WorkspaceBaseModel()
        {
        }

        public virtual string Add<T>(T content) where T : DocumentContent
        {
            Documents.Add(content);
            RaisePropertyChanged(nameof(Documents));

            return content.ContentId;
        }
        public virtual void Remove(string id)
        {
            var i = Documents.Where(x => x.ContentId == id).First();
            if (i != null)
            {
                i.Close();
                Documents.Remove(i);
            }
        }
    }

    public class Model : WorkspaceBaseModel// where T : struct, IComparable
    {

        public class DocumentData
        {
            public string FileNames;
            public Pixel<float> Raw;
            public WriteableBitmap Images;
        }
        public Dictionary<string, DocumentData> ContentData = new Dictionary<string, DocumentData>();

        public bool _isLinkage = true;
        public bool isLinkage { get => _isLinkage; set => SetProperty(ref _isLinkage, value); }



        //読み込みブロック

        [Category("Read"), Description("Auto Read from PixelFormat.yaml")]
        public bool Auto { get; set; } = true;

        [Category("Read")]
        public ManualReader ManualReader { get; set; } = new ManualReader(true);

        //bool _AutoRun = false;
        //[Category(nameof(Developing)), Description("Script AutoRun")]
        //public bool AutoRun { get => _AutoRun; set => SetProperty(ref _AutoRun, value, () => DevelopingAll()); }

        //Scriptingブロック
        string _Script = File.ReadAllText("Default.csx");
        [Category("Scripting"), ReadOnly(true)]
        public string Script { get => _Script; set => SetProperty(ref _Script, value); }

        private Rect _Rect;
        [Category("Scripting"), ReadOnly(true), Description("you can get it in Script")]
        public Rect Rect { get => _Rect; set => SetProperty(ref _Rect, value); }

        //現像ブロック

        int _Offset = 0;
        [Category(nameof(Developing)), Description("image = (raw - Offset) * (255 / Depth)")]
        public int Offset { get => _Offset; set => SetProperty(ref _Offset, value, () => DevelopingAll()); }
        int _Depth = 255;
        [Category(nameof(Developing)), Description("image = (raw - Offset) * (255 / Depth)")]
        public int Depth { get => _Depth; set => SetProperty(ref _Depth, value, () => DevelopingAll()); }

        public enum ColorType
        {
            Raw,
            GR,
            RG,
            GB,
            BG,
        }
        ColorType _Color = ColorType.Raw;
        [Category(nameof(Developing)), Description("")]
        public ColorType Color { get => _Color; set => SetProperty(ref _Color, value, () => DevelopingAll()); }

        [Category(nameof(Developing)), Description("")]
        public ColorSetting ColorSetting { get; set; } = new ColorSetting(true);


        //表示ブロック

        private BitmapScalingMode _ScalingMode;
        [Category("Canvas"), Description("")]
        public BitmapScalingMode ScalingMode { get => _ScalingMode; set => SetProperty(ref _ScalingMode, value); }

        Point _ScrollBar;
        [Category("Canvas"), Description("")]
        public Point ScrollBar { get => _ScrollBar; set => SetProperty(ref _ScrollBar, value); }

        private double _Scale = 1;
        [Category("Canvas"), Description("")]
        public double Scale { get => _Scale; set => SetProperty(ref _Scale, value); }

        private Color _Background = Colors.WhiteSmoke;
        [Category("Canvas"), Description("")]
        public Color Background { get => _Background; set => SetProperty(ref _Background, value); }

        //pixeloffsetmode
        //結果

        public Action<string> Output { get; set; }


        //メソッド

        public Model()
        {
        }

        public override string Add<T>(T content)
        {
            var i = base.Add(content);
            var src = PixelFactory.Create<float>(1, 1);
            ContentData.Add(i, new DocumentData()
            {
                FileNames = "null",
                Raw = src,
                Images = src.ToMono()
            });
            return i;
        }

        public override void Remove(string contentId)
        {
            //DocumentDatas.FileNames.Remove(id);
            //raws.Remove(id);
            //Images.Remove(id);

            ContentData.Remove(contentId);

            base.Remove(contentId);
        }

        public void ReadFile(string filename,string contentId = null)
        {
            //int , floatの場合分け

            Output($"ReadFile : {filename} to {contentId}");
            ContentData[contentId].FileNames= filename;

            if(!System.IO.File.Exists(filename))
            {
                //ファイルが存在しないとき
                ContentData[contentId].Raw = PixelFactory.Create<float>(2, 2);
            }
            else if (Auto)
            {
                var dic = (new Deserializer()).Deserialize<List<Pixels.PixelFormat>>(File.ReadAllText("PixelFormat.yaml"));
                ContentData[contentId].Raw = PixelFactory.Create<float>(dic, filename);
            }
            else
            {
                ContentData[contentId].Raw = ((dynamic)PixelFactory.Create<float>(ManualReader.Width, ManualReader.Height))
                    .Read(filename, ManualReader.Offset, ManualReader.Type);
            }
            Developing(contentId);
            //RaisePropertyChanged(nameof(DocumentDatas));
        }

        public void ScriptRun(string contentId) => ScriptRunAsync(contentId, Script);

        public async void ScriptRunAsync(string id,string command)
        {
            try
            {
                Output("-----Script Run-----");
                ContentData[id].Raw.AddMap("Trim", (int)Rect.Left, (int)Rect.Top, (int)Rect.Width, (int)Rect.Height);
                var globals = new Globals() { raw = ContentData[id].Raw };

                PixelScripting a = new PixelScripting();
                var state = await a.RunAsync(command, globals);
                foreach (var variable in state.Variables)
                    Output($"  Result : {variable.Name} = {variable.Value} of type {variable.Type}");

                //再代入した場合参照先が変わるので書き戻しが必要
                ContentData[id].Raw = globals.raw;
                //書き戻したら再描画必要
                Developing(id);
            }
            catch (Exception e)
            {
                Output($"{e.ToString()}");
            }
        }

        public void ReLoad(string contentId, bool autorun = false)
        {
            if (!ContentData.ContainsKey(contentId)) return;
            if (!File.Exists(ContentData[contentId].FileNames)) return;

            ReadFile(ContentData[contentId].FileNames, contentId);
            if(autorun) ScriptRun(contentId);
        }

        public void Shortcut(string contentId, string x)
        {
            if (x == "XButton1") ReLoad(contentId);
            if (x == "XButton2") ScriptRun(contentId);

            if (x == "MiddleButton")
            {
                rectselect += 1;
                rectselect = rectselect % ContentData[contentId].Raw.Maps.Count;
                var i = ContentData[contentId].Raw.Maps.Skip(rectselect).First().Value;
                Rect = new Rect(i.Left, i.Top, i.Width, i.Height);
            }
        }
        int rectselect = 0;

        public void DevelopingAll()
        {
            foreach(var i in ContentData.Keys)
            {
                Developing(i);
            }
            //isLinkなら全部
            //var buf = raws[key].Clone();

            //buf.SubSelf(Offset).DivSelf(Depth);

            //Images[key] = buf.ToMono();
            //RaisePropertyChanged(nameof(Images));
        }

        public void Developing(string id)
        {
            Output($"Developing {id}");

            var buf = ContentData[id].Raw.Clone();

            buf["Full"].SubSelf(Offset).MulSelf((float)(255.0/Depth));
            //buf.SubSelf(Offset).MulSelf(255.0).DivSelf(Depth);
            ContentData[id].Images =
                Color == ColorType.Raw ? buf.ToMono() :
                Color == ColorType.GR ? buf.ToColorGR(ColorSetting.GetMatrix()) :
                Color == ColorType.RG ? buf.ToColorRG(ColorSetting.GetMatrix()) :
                Color == ColorType.GB ? buf.ToColorGB(ColorSetting.GetMatrix()) :
                Color == ColorType.BG ? buf.ToColorBG(ColorSetting.GetMatrix()) : 
                buf.ToMono();
            
            RaisePropertyChanged(nameof(ContentData));
        }

        public void ClipText(string contentId, bool selected)
        {
            Output("-----ClipText-----");
            if(selected)
            {
                ContentData[contentId].Raw.AddMap("Trim", (int)Rect.Left, (int)Rect.Top, (int)Rect.Width, (int)Rect.Height);
                Clipboard.SetDataObject(
                    ContentData[contentId].Raw["Trim"].ToText(),
                    false);
            }
            else
            {
                Clipboard.SetDataObject(
                    ContentData[contentId].Raw["Full"].ToText(),
                    false);
            }
        }
        public void RawSave(string contentId, bool raw, bool selected)
        {
            Output("-----RawSave-----");
            if(raw)
            {
                var i = DateTime.Now.ToString("yyyyMMddHHmmss") + ".bin";
                Output(" -> i");
                if (selected)
                {
                    ContentData[contentId].Raw.AddMap("Trim", (int)Rect.Left, (int)Rect.Top, (int)Rect.Width, (int)Rect.Height);
                    ContentData[contentId].Raw["Trim"].Write(i, true);
                }
                else
                {
                    ContentData[contentId].Raw["Full"].Write(i);
                }
            }
            else
            {
                var i = DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                Output(" -> i");
                if (selected)
                {
                    ContentData[contentId].Raw.AddMap("Trim", (int)Rect.Left, (int)Rect.Top, (int)Rect.Width, (int)Rect.Height);
                    ContentData[contentId].Raw["Trim"].Cut().AddSelf(Offset).MulSelf(255).DivSelf(Depth).TrimSelf(255,0).ToPixelByte().WriteBitmap(i);
                }
                else
                {
                    ContentData[contentId].Raw["Full"].Cut().AddSelf(Offset).MulSelf(255).DivSelf(Depth).TrimSelf(255, 0).ToPixelByte().WriteBitmap(i);
                }
            }
        }
    }

    public class Globals
    {
        public Pixel<float> raw;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct ManualReader
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Offset { get; set; }
        public string Type { get; set; }
        public string Delimiter { get; set; }

        public ManualReader(bool a)
        {
            this.Width = 2256;
            this.Height = 1178;
            this.Offset = 0;
            this.Type = "Int32";
            this.Delimiter = @"\n";
        }

        public override string ToString()
        {
            return $"{Type} : {Width},{Height}";
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct ColorSetting
    {
        public double RGain { get; set; }
        public double BGain { get; set; }
        public double GGain { get; set; }
        public double Gamma { get; set; }
        public double[] Matrix { get; set; }

        public float[] GetMatrix()
        {
            float[] dst = new float[9];

            int c = 0;
            for (int i = 0; i < 3; i++){ dst[c] = (float)(Matrix[c] * BGain); c++; }
            for (int i = 0; i < 3; i++){ dst[c] = (float)(Matrix[c] * GGain); c++; }
            for (int i = 0; i < 3; i++){ dst[c] = (float)(Matrix[c] * RGain); c++; }
            return dst;
        }

        public ColorSetting(bool a)
        {
            this.RGain = 1.8;
            this.BGain = 2;
            this.GGain = 1;

            Gamma = 1;
            Matrix = new double[9] { 1,0,0,0,1,0,0,0,1 };
        }

        public override string ToString()
        {
            return $"{RGain},{GGain},{BGain}";
        }
    }
}

