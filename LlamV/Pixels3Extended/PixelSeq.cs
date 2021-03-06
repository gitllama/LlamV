﻿using Pixels;
using Pixels.Math;
using Pixels.Stream;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet;

namespace Pixels.Extend
{
    //シーケンス動作に必要な諸設定
    public class PixelSeqParam
    {
        //設定
        public string Regex { get; set; } = @"Lot(?<lot>[0-9]{4})\\wafer(?<wf>[0-9]{2})\\N(?<chip>[0-9]{2})";
        public string searchPattern { get; set; } = "N*";
        public string ChipNote { get; set; } = @"N[0-9]{2}_[a-zA-Z0-9]+_(?<note>[a-zA-Z0-9]+)$";

        public Dictionary<string, string> Condition { get; set; }
        public Dictionary<string, PictureTypes> Picture { get; set; }
        public Dictionary<string, PixelMap> Maps { get; set; }
        public Dictionary<string, PixelColor> Colors { get; set; }

        //設定の読み込み
        public static PixelSeqParam Create(string yaml)
        {
            using (var sr = new StreamReader(yaml))
            {
                var deserializer = new YamlDotNet.Serialization.Deserializer();
                return deserializer.Deserialize<PixelSeqParam>(sr);
            }
        }

        public List<ChipStatus> CheckedChips(string path)
        {
            var result = new List<ChipStatus>();

            IEnumerable<string> dirs = System.IO.Directory.EnumerateDirectories(
                path,
                searchPattern,
                System.IO.SearchOption.AllDirectories);

            foreach (string dir in dirs)
            {
                var mc = System.Text.RegularExpressions.Regex.Matches(
                    dir,
                    Regex,
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                foreach (System.Text.RegularExpressions.Match m in mc)
                {
                    var buf = new ChipStatus()
                    {
                        LotNo = m.Groups["lot"].Value,
                        WfNo = m.Groups["wf"].Value,
                        ChipNo = m.Groups["chip"].Value,
                        FilePath = dir,

                        //!!! 設定値の注入が必要
                        Condition = Condition,
                        Picture = Picture,
                        Maps = Maps,
                        Colors = Colors
                    };
                    result.Add(buf);
                }
            }

            return result;
        }
    }

    public class PictureTypes
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }


    //チップのデータ
    public class ChipStatus
    {
        public string FilePath { get; set; }
        public string LotNo { get; set; }
        public string WfNo { get; set; }
        public string ChipNo { get; set; }
        public string Note { get; set; }
        public string DateTimeTaken { get; set; }
        public string DateTimeProcessed { get; set; }

        public Dictionary<string, string> Condition { get; set; }
        public Dictionary<string, PictureTypes> Picture { get; set; }
        public Dictionary<string, PixelMap> Maps { get; set; }
        public Dictionary<string, PixelColor> Colors { get; set; }

        public Dictionary<(string cond, string pic, string name), string> Result { get; set; }
    }

    public class ChipStatusMediator
    {
        public static ChipStatusMediator Create(ChipStatus src)
        {
            return (new Deserializer())
                .Deserialize<ChipStatusMediator>
                (
                    (new Serializer()).Serialize(src)
                );
        }

        public string FilePath { get; set; }
        public string LotNo { get; set; }
        public string WfNo { get; set; }
        public string ChipNo { get; set; }
        public string Note { get; set; }
        public string DateTimeTaken { get; set; }
        public string DateTimeProcessed { get; set; }

        public Dictionary<string, string> Condition { get; set; }
        public Dictionary<string, PictureTypes> Picture { get; set; }
        public Dictionary<string, PixelMap> Maps { get; set; }
        public Dictionary<string, PixelColor> Colors { get; set; }

        public Dictionary<(string cond, string pic, string name), string> Result { get; set; }

        //画像操作
        public (string cond,string pic) PixelStatus;
        public Pixel<float> pixel;
        public ChipStatusMediator this[string cond, string pic]
        {
            get
            {
                SetPixel(cond, pic);
                return this;
            }
        }
        public ChipStatusMediator this[string map]
        {
            get
            {
                /*
                if(pixel != null) pixel.SetMap(map);
                if (pixelfilter != null) pixelfilter.SetMap(map);
                */
                //!!!注意
                return this;
            }
        }
        private void SetPixel(string cond, string pic)
        {
            var path = $"{Path.Combine(FilePath, Condition[cond], Picture[pic].Name)}";
            (string cond, string pic) name = (Condition[cond], Picture[pic].Name);

            if (!System.IO.File.Exists(path))
            {
                pixel = null;
                return;
            }
            if (PixelStatus.CompareTo(name) == 0) return;

            pixel = null;
            pixel = PixelFactory.Create<float>(Maps).Read(path, 0, Picture[pic].Type);
            pixel.Colors = Colors;
            PixelStatus = name;
        }

        public Pixel<float> pixelfilter;

        public void AddResult(string key,string value)
        {
            if (Result == null) Result = new Dictionary<(string cond, string pic, string name), string>();

            Result.Add((PixelStatus.cond, PixelStatus.pic, key), value);
        }




    }

    /* 
     * log.txt -> 
     * 
     * 
     * 
     * 
     * 
     */
    public static class PixelSeqExtensions
    {
        public const string outputfilename = "log.txt";

        public static void WriteResult(this object value)
        {

            Console.WriteLine();
        }




        public static void Output(this ChipStatusMediator src, string key, string value)
        {
            Console.WriteLine($"{key} : {value}");

            using (var sw = new StreamWriter(outputfilename, true))
            {
                sw.WriteLine($"{src.LotNo}_{src.WfNo}_{src.ChipNo},{src.Condition}_{src.Picture} {key}, {value}");
            }
            src.AddResult(key, value);
        }

        public static ChipStatusMediator Filter(this ChipStatusMediator src, Func<Pixel<float>, Pixel<float>> action)
        {
            if (src.pixel == null) return src;
            src.pixel = action(src.pixel);

            return src;
        }
        public static ChipStatusMediator Intermediate(this ChipStatusMediator src, Func<Pixel<float>, Pixel<float>> action)
        {
            if (src.pixel == null) return src;
            src.pixelfilter = action(src.pixel);

            return src;
        }

        public static ChipStatusMediator VFPN(this ChipStatusMediator src, params string[] colors)
        {
            if (src.pixel == null) return src;
            var p = src.pixel;

            foreach (var i in colors)
            {
                //var value = p.AverageV(i);
                //src.Output($"{nameof(VFPN)}_Max_{i}", value.Max().ToString());
            }

            /*
            if (src.pixel == null)
            {
                foreach (var n in new int[] { 0, 1, 2, 3 })
                {
                    var key = $"{nameof(VFPN)}_Max{n}";
                    src.Output(key, "null");
                    key = $"{nameof(VFPN)}_Min{n}";
                    src.Output(key, "null");
                    key = $"{nameof(VFPN)}_Delta{n}";
                    src.Output(key, "null");
                }
                return src;
            }
            for(int y=0;y<2;y++)
                for(int x=0;x<2;x++)
                {
                    var i = src.pixel.AverageV(x,y,2,2);
                    var Max = i.Max();
                    var Min = i.Min();

                    var Delta = 0.0;
                    int count = 0;
                    for (int n = 0; n < i.Length - 5; n++)
                    {
                        var buf = new double[5];
                        buf[0] = i[n];
                        buf[1] = i[n+1];
                        buf[2] = i[n+2];
                        buf[3] = i[n+3];
                        buf[4] = i[n+4];

                        Array.Sort(buf);
                        if (Delta < System.Math.Abs(i[n + 2] - buf[2]))
                        {
                            Delta = System.Math.Abs(i[n + 2] - buf[2]);
                            count = n;
                        }
                    }

                    var key = $"{nameof(VFPN)}_Max{x+y*2}";
                    src.Output(key, Max.ToString());
                    key = $"{nameof(VFPN)}_Min{x + y * 2}";
                    src.Output(key, Min.ToString());
                    key = $"{nameof(VFPN)}_Delta{x + y * 2}";
                    src.Output(key, Delta.ToString()+$",{count}");
                }

            return src;
            */
            return null;
        }
        public static ChipStatusMediator HFPN(this ChipStatusMediator src)
        {
            if (src.pixel == null) return src;

            return src;
        }

        public static ChipStatusMediator Signal(this ChipStatusMediator src, params string[] color)
        {
            if (src.pixel == null) return src;
            var p = src.pixel;

            foreach(var i in color)
            {
                //var value = p.Signal(i);

                //src.Output($"{nameof(Signal)}_Averaging_{i}", value.Average.ToString());
                //src.Output($"{nameof(Signal)}_Deviation_{i}", value.Deviation.ToString());
            }

            /*
            var m = p.Signal();
            var c = p.SignalBayer();

            string key;
            double value;

            key = $"{nameof(Signal)}_Averaging";
            value = m.Average;
            src.Output(key, value.ToString());

            foreach (var n in c.Average.Select((v, i) => (v, i)))
            {
                key = $"{nameof(Signal)}_Averaging{n.Item2}";
                value = n.Item1;
                src.Output(key, value.ToString());
            }


            key = $"{nameof(Signal)}_Deviation";
            value = m.Deviation;
            src.Output(key, value.ToString());

            foreach (var n in c.Deviation.Select((v, i) => (v, i)))
            {
                key = $"{nameof(Signal)}_Deviation{n.Item2}";
                value = n.Item1;
                src.Output(key, value.ToString());
            }
            */
            return src;
        }

        public static ChipStatusMediator Defect(this ChipStatusMediator src, params int[] thr)
        {
            if (src.pixel == null) return src;
            if (src.pixelfilter == null) return src;
            if (thr == null) return src;

            var p1 = src.pixel;
            var p2 = src.pixelfilter;

            //int[,] count = new int[p1.BayerSizeX * p1.BayerSizeY, thr.Length];


            //for (int by = 0; by < p1.BayerSizeY; by++)
            //    for (int bx = 0; bx < p1.BayerSizeX; bx++)
            //    {
            //        p1.BayerX = bx;
            //        p1.BayerY = by;
            //        //ref int[] buf = ref count[bx + by * p1.BayerSizeX];
            //        for (int y = 0; y < p1.BayerHeight; y++)
            //            for (int x = 0; x < p1.BayerWidth; x++)
            //            {
            //                var hoge = p1.Bayer(x, y) - p2.Bayer(x, y);
            //                for(int i =0;i<thr.Length;i++)
            //                {
            //                    count[bx + by * p1.BayerSizeX,i] += hoge > thr[i] ? 1 : 0;
            //                }
            //            }
            //    }

            ////foreach ((int[] thrs, int index) n in count.Select((v, i) => (v, i)))
            //    //foreach ((int value, int index) k in n.thrs.Select((v, i) => (v, i)))
            //for(int y=0;y< count.GetLength(0);y++)
            //    for (int x = 0; x < count.GetLength(1); x++)
            //    {
            //        var key = $"{nameof(Defect)}_{thr[x]}_{y}";
            //        var value = count[y,x];
            //        src.Output(key, value.ToString());
            //    }
            return src;
        }

        //検査項目

        public static ChipStatusMediator CheckFile(this ChipStatusMediator src)
        {
            //var rsult = System.IO.File.Exists(src.FilePath);
            int fileCount = Directory.GetFiles(src.FilePath, "*.bin", SearchOption.AllDirectories).Length;
            //src.Result.Add($"{nameof(CheckFile)}", fileCount.ToString());
            return src;
        }


        public static ChipStatusMediator Labeling(this ChipStatusMediator src)
        {
            if (src.pixel == null) return src;
            //if (src.pixelfilter == null) return src;
            /*
            bool isDark = true;
            var med = src.pixel
                    ["Normal"].FilterMedian(5, 5, 12, "Gr", "R", "B", "Gb")
                    ["HOB-L+"].FilterMedian(5, 5, 12, "M")
                    ["HOB-R+"].FilterMedian(5, 5, 12, "M")
                    ["Full"];
            var defect = isDark
                ? src.pixel["Full"].Sub(med["Full"])
                : src.pixel["Full"].Div(med["Full"]);

            var bin = src.pixel.Clone<bool>();
            if (isDark)
            {
                defect["Full"].Binarization((x, y) => x > 127 || x < -127, "M", bin["Full"]);
                src.pixel["Effective"].Binarization((x, y) => y || x > 255 || x < -255, "M", bin["Effective"]);
                src.pixel["HOB-L"].Binarization((x, y) => y || x > 255 || x < -255, "M", bin["HOB-L"]);
                src.pixel["HOB-R"].Binarization((x, y) => y || x > 255 || x < -255, "M", bin["HOB-R"]);
            }
            else
            {
                defect["Effective"].Binarization((x, y) => x > 1.02 || x < 0.98, "M", bin["Effective"]);
                src.pixel["HOB-L"].Binarization((x, y) => y || x > 4095, "M", bin["HOB-L"]);
                src.pixel["HOB-R"].Binarization((x, y) => y || x > 4095, "M", bin["HOB-R"]);
            }

            int count = 0;
            foreach (var c in new string[] { "M", "Gr", "R", "B", "Gb", "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2" })
            {
                var l = c == "M"
                    ? bin["Full"].Labling(x => x.Area >= 5, true)
                    : bin["Effective"].Cut(c).Labling(x => x.Area >= 5, true);

                var result = $"Cluster_{c} Count {l.Count}";
                if (l.Count >= 1)
                {
                    if (count < l.Count) count = l.Count;

                    bool flag_death = false;
                    bool flag_HFPN = false;
                    bool flag_VFPN = false;
                    bool flag_Cluster = false;
                    foreach (var i in l.Take(64))
                    {
                        if (i.Width > 64 && i.Height > 64) flag_death = true;
                        else if (i.Width > 64) flag_HFPN = true;
                        else if (i.Height > 64) flag_VFPN = true;
                        else flag_Cluster = true;

                        //Console.WriteLine($" {i.Width} {i.Height} {i.Area} {r}");
                    }
                    var hoge = "";
                    hoge += flag_death ? " Death" : "";
                    hoge += flag_HFPN ? " HFPN" : "";
                    hoge += flag_VFPN ? " VFPN" : "";
                    hoge += flag_Cluster ? " Cluster" : "";
                    Console.Write($"{hoge}");
                    result += $"{hoge}";

                }
                Console.WriteLine("");
                src.Output($"{nameof(Labeling)}_{c}", $"{result}");
            }

            var l1 = bin["Effective"].Matching("M");
            src.Output($"Matching", $"{l1.Count}");

            var l2 = bin["Effective"].MatchingG();
            src.Output($"MatchingG", $"{l2.Count}");
            */
            return src;
        }



        public static ChipStatusMediator ClusterDefect(this ChipStatusMediator src)
        {
            if (src.pixel == null) return src;

            return src;
        }
        public static ChipStatusMediator NonUniformity(this ChipStatusMediator src)
        {
            if (src.pixel == null) return src;

            return src;
        }
        public static ChipStatusMediator Shading(this ChipStatusMediator src)
        {
            if (src.pixel == null) return src;

            return src;
        }

        public static void OutputFile(this ChipStatusMediator src, string name)
        {
            using (var sw = new StreamWriter(name, true))
            {
                var result = (new Serializer()).Serialize(new List<ChipStatusMediator>() { src });
                Console.WriteLine(result);
                sw.WriteLine(result);
            }
        }
    }
}

//public class PixelVector
//{
//    public int Left { get; set; } = 0;
//    public int Top { get; set; } = 0;
//    public int Width { get; set; } = 2256;
//    public int Height { get; set; } = 1178;

     //    public Dictionary<string, PixelMap> Maps;

     //    public Vector[] pixel;
     //    //public ref T this[int value] { get => ref pixel[value]; }
     //    //public ref T this[int x, int y] { get => ref pixel[(x + Left) + (y + Top) * Width]; }

     //    public PixelVector(int width, int height, T[] src)
     //    {
     //        Width = width;
     //        Height = height;
     //        pixel = src;
     //    }
     //    public PixelVector(int width, int height)
     //    {
     //        Width = width;
     //        Height = height;
     //        pixel = new T[Width * Height];

     //    }

     //    public Pixel<T> Map(string value)
     //    {
     //        Left = Maps[value].Left;
     //        Top = Maps[value].Top;
     //        Width = Maps[value].Width;
     //        Height = Maps[value].Height;

     //        return this;
     //    }
     //}

