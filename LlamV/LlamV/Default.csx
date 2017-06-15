Console.WriteLine("Script Start");

//スタッガー処理
var src = raw["Stagger"].StaggerRSelf().Clone();

//傷カウント用フィルタリング画像作成
var p = ClusterPixel(src, true);

//G matchテスト
foreach (var i in p["Full"].GetIndex("R")) p[i] = false;
foreach (var i in p["Full"].GetIndex("B")) p[i] = false;

var instances = new List<Func<bool>>()
{
    () => Cluster(p, ref raw, true),
    () => Matching(p, true),
    () => MatchingG(p, true)
};

foreach (var instance in instances)
{
    instance();
    //if (instance()) return;
}


//raw = Matching(src, med, true);


    //raw = ClusterC(src, false);

    //raw = VFPN(src, true);
    //raw = HFPN(src);
    //raw = Defect(src, true);

Pixel<bool> ClusterPixel(Pixel<float> src, bool isDark)
{
    var med = src
            ["Normal"].FilterMedian(5, 5, 12, "Gr", "R", "B", "Gb")
            ["HOB-L+"].FilterMedian(5, 5, 12, "M")
            ["HOB-R+"].FilterMedian(5, 5, 12, "M")
            ["Full"];
    var defect = isDark
        ? src["Full"].Sub(med["Full"])
        : src["Full"].Div(med["Full"]);

    var bin = src.Clone<bool>();
    if (isDark)
    {
        defect["Full"].Binarization((x, y) => (x > 127 || x < -127), "M", bin["Full"]);
        src["Effective"].Binarization((x, y) => y || (x > 255 || x < -255), "M", bin["Effective"]);
        src["HOB-L"].Binarization((x, y) => y || (x > 255 || x < -255), "M", bin["HOB-L"]);
        src["HOB-R"].Binarization((x, y) => y || (x > 255 || x < -255), "M", bin["HOB-R"]);
    }
    else
    {
        defect["Effective"].Binarization((x, y) => x > 1.02 || x < 0.98, "M", bin["Effective"]);
        src["HOB-L"].Binarization((x, y) => y || x > 4095, "M", bin["HOB-L"]);
        src["HOB-R"].Binarization((x, y) => y || x > 4095, "M", bin["HOB-R"]);
    }

    return bin;
}

bool Cluster(Pixel<bool> src, ref Pixel<float> dst, bool flag = false)
{
    int count = 0;
    foreach (var c in new string[] { "M", "Gr", "R", "B", "Gb", "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2" })
    {

        var l = c == "M"
            ? src["Full"].Labling(x => x.Area >= 5, true)
            : src["Effective"].Cut(c).Labling(x => x.Area >= 5, true);

        Console.Write($"Cluster_{c} Count {l.Count}");
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
        }
        Console.WriteLine("");
    }

    if (flag) dst = src.ToPixel<Single>();

    return count > 0;
}


//med = med.FilterAverageH("HOB-R", "HOB-Rs", null, "M");


bool Matching(Pixel<bool> src, bool flag = false)
{
    var l = src["Effective"].Matching("M");

    // Console.WriteLine($"No Cluster");
    Console.WriteLine($"ClusterMatching Count {l.Count}");
    if (l.Count > 0)
    {
        foreach (var i in l.Take(3))
            Console.WriteLine($" {i}");
    }

    return false;
}
bool MatchingG(Pixel<bool> src, bool flag = false)
{
    var l = src["Effective"].MatchingG();

    Console.WriteLine($"ClusterMatching Count {l.Count}");
    if (l.Count > 0)
    {
        foreach (var i in l.Take(3))
            Console.WriteLine($" {i}");
    }

    return false;
}

/*
Pixel<float> VFPN(Pixel<float> src, bool flag = false)
{
    //縦ActiveでCutするなら7大丈夫
    //大傷に引っ張られる
    var medV = src["Normal"].FilterMedian(1, 7, 4, "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2");

    foreach (var c in new string[] { "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2" })
    {
        var buf = medV["Effective-V"].AverageV(c);
        Console.WriteLine($"VFPN {c} : {buf.Max()}");
    }

    return flag
        ? medV["Effective-V"].FilterAverageV(null, "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2")
        : src;
}

Pixel<float> HFPN(Pixel<float> src, bool flag = false)
{
    var medH = src["Normal"].FilterMedian(7, 1, 4, "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2");

    foreach (var c in new string[] { "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2" })
    {
        var buf = medH["Effective"].AverageH(c);
        Console.WriteLine($"HFPN {c} : {buf.Max()}");
    }

    return flag
       ? medH["Effective"].FilterAverageH(null, "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2")
       : src;
}


Pixel<float> Defect(Pixel<float> src, bool flag = false)
{
    var med = src["Effective"].FilterMedian(5, 5, 12, "Gr", "R", "B", "Gb");
    var defect = src["Full"].Sub(med["Full"]);

    int thr = 64;

    foreach (var c in new string[] { "Gr", "R", "B", "Gb" })
    {
        var buf = defect["Active"].Count(x => x > 64, c);
        Console.WriteLine($"WD {c} : {buf}");
    }

    if (flag)
    {
        var bin = src.Clone<bool>();
        defect["Active"].Binarization(x => x > 64 || x < -64, "M", bin["Active"]);
        return bin.ToPixel<Single>();
    }
    else
    {
        return src;
    }

}



    */

