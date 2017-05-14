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
using Microsoft.CodeAnalysis.Scripting;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Scripting;
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
            public Pixel<float> raws;
            public WriteableBitmap Images;
        }
        public Dictionary<string, DocumentData> DocumentDatas = new Dictionary<string, DocumentData>();

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
            DocumentDatas.Add(i, new DocumentData()
            {
                FileNames = "null",
                raws = src,
                Images = src.ToMono()
            });
            return i;
        }

        public override void Remove(string contentId)
        {
            //DocumentDatas.FileNames.Remove(id);
            //raws.Remove(id);
            //Images.Remove(id);

            DocumentDatas.Remove(contentId);

            base.Remove(contentId);
        }

        public void ReadFile(string filename,string contentId = null)
        {
            //int , floatの場合分け

            Output($"ReadFile : {filename} to {contentId}");
            DocumentDatas[contentId].FileNames= filename;

            if(!System.IO.File.Exists(filename))
            {
                //ファイルが存在しないとき
                DocumentDatas[contentId].raws = PixelFactory.Create<float>(2, 2);
            }
            else if (Auto)
            {
                var dic = (new Deserializer()).Deserialize<List<Pixels.PixelFormat>>(File.ReadAllText("PixelFormat.yaml"));
                DocumentDatas[contentId].raws = PixelFactory.Create<float>(dic, filename);
            }
            else
            {
                DocumentDatas[contentId].raws = ((dynamic)PixelFactory.Create<float>(ManualReader.Width, ManualReader.Height))
                    .Read(filename, ManualReader.Offset, ManualReader.Type);
            }
            Developing(contentId);
            //RaisePropertyChanged(nameof(DocumentDatas));
        }

        public void ScriptRun(string contentId) => RunAsync(contentId, Script);

        public async void RunAsync(string id,string command)
        {
            try
            {
                Output("-----Script Run-----");
                DocumentDatas[id].raws.AddMap("Trim", (int)Rect.Left, (int)Rect.Top, (int)Rect.Width, (int)Rect.Height);
                var globals = new Globals() { raw = DocumentDatas[id].raws };

                var ssr = ScriptSourceResolver.Default.WithBaseDirectory(Environment.CurrentDirectory);
                var smr = ScriptMetadataResolver.Default.WithBaseDirectory(Environment.CurrentDirectory);
                var state = await CSharpScript.RunAsync(
                    command,
                    ScriptOptions.Default
                    .WithSourceResolver(ssr)
                    .WithMetadataResolver(smr)
                    .WithReferences(Assembly.GetEntryAssembly())
                    .WithImports(new string[]
                    {
                        "System",
                        "System.Collections.Generic",
                        "System.Linq",
                        "System.Math",
                        "System.IO",
                        "Pixels",
                        "Pixels.Math",
                        "Pixels.Stream",
                        "Pixels.Extend",
                    }),
                   globals: globals);

                
                foreach (var variable in state.Variables)
                    Output($"  Result : {variable.Name} = {variable.Value} of type {variable.Type}");

                //再代入した場合参照先が変わるので書き戻しが必要
                DocumentDatas[id].raws = globals.raw;
            }
            catch (Exception e)
            {
                Output($"{e.ToString()}");
            }
        }

        public void ReLoad(string contentId, bool autorun = false)
        {
            if (!DocumentDatas.ContainsKey(contentId)) return;
            if (!File.Exists(DocumentDatas[contentId].FileNames)) return;

            ReadFile(DocumentDatas[contentId].FileNames, contentId);
            if(autorun) ScriptRun(contentId);
            Developing(contentId);
        }

        public void Shortcut(string contentId, string x)
        {
            if (x == "XButton1") ReLoad(contentId);
            if (x == "XButton2") ScriptRun(contentId);
        }

        public void DevelopingAll()
        {
            foreach(var i in DocumentDatas.Keys)
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

            var buf = DocumentDatas[id].raws.Clone();

            buf["Full"].SubSelf(Offset).MulSelf((float)(255.0/Depth));
            //buf.SubSelf(Offset).MulSelf(255.0).DivSelf(Depth);
            DocumentDatas[id].Images =
                Color == ColorType.Raw ? buf.ToMono() :
                Color == ColorType.GR ? buf.ToColorGR(ColorSetting.GetMatrix()) :
                Color == ColorType.RG ? buf.ToColorRG(ColorSetting.GetMatrix()) :
                Color == ColorType.GB ? buf.ToColorGB(ColorSetting.GetMatrix()) :
                Color == ColorType.BG ? buf.ToColorBG(ColorSetting.GetMatrix()) : 
                buf.ToMono();
            
            RaisePropertyChanged(nameof(DocumentDatas));
        }

        public void ClipText(string contentId,bool selected)
        {
            Output("-----ClipText-----");
            if(selected)
            {
                DocumentDatas[contentId].raws.AddMap("Trim", (int)Rect.Left, (int)Rect.Top, (int)Rect.Width, (int)Rect.Height);
                Clipboard.SetDataObject(
                    DocumentDatas[contentId].raws["Trim"].ToText(),
                    false);
            }
            else
            {
                Clipboard.SetDataObject(
                    DocumentDatas[contentId].raws["Full"].ToText(),
                    false);
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

