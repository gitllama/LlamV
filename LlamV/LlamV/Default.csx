Console.WriteLine("Script Start");

var isDark = true;

/*前処理*/
raw = raw["Stagger"].StaggerRSelf();

string[] color1 = new string[] { "Gr1", "R1", "B1", "Gb1", "Gr2", "R2", "B2", "Gb2" };
string[] color2 = new string[] { "Gr", "R", "B", "Gb" };

var A = raw["Full"].Clone();
var B = raw["Effective", color2].FilterMedian()
            ["HOB-L"].FilterMedian()
            ["HOB-R"].FilterMedian();
var C = isDark 
        ? A["Full"].Acc<float, float>(B["Full"], (x, y) => x - y, raw.Clone(false))
        : A["Full"].Acc<float, float>(B["Full"], (x, y) => x / y, raw.Clone(false));
var D = C.Clone<bool>();

/*スペックの計算*/

//Signal
Console.WriteLine(A["Effective", "Gr"].Average());
Console.WriteLine(A["Effective", "R"].Average());
Console.WriteLine(A["Effective", "B"].Average());
Console.WriteLine(A["Effective", "Gb"].Average());

//Labling
if (isDark)
{
    D["Full"].AccSelf(C["Full"], (x, y) => (y > 127 || y < -127));
    D["Effective"].AccSelf(A["Full"], (x, y) => x || (y > 255 || y < -255));
    D["HOB-L"].AccSelf(A["HOB-L"], (x, y) => x || (y > 255 || y < -255));
    D["HOB-R"].AccSelf(A["HOB-R"], (x, y) => x || (y > 255 || y < -255));

    //raw = (Pixel<float>)D["Full"];
}
else
{
    D["Effective"].AccSelf(C["Effective"], (x, y) => (y > 1.02 || y < 0.98));
    D["HOB-L"].AccSelf(A["HOB-L"], (x, y) => x || (y > 4095));
    D["HOB-R"].AccSelf(A["HOB-R"], (x, y) => x || (y > 4095));
}
Console.WriteLine(D["Full"].Labling(x => x.Area >= 5).Count());
foreach (var i in D["Full"].Labling(x => x.Area >= 5))
    Console.WriteLine($"({i.Left} {i.Top}) {i.Area}");
Console.WriteLine(D["Full","M1"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Full","M2"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Full","M3"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Full","M4"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "Gr"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "R"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "B"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "Gb"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "Gr1"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "Gr2"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "R1"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "R2"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "B1"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "B2"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "Gb1"].Cut().Labling(x => x.Area >= 5).Count());
Console.WriteLine(D["Effective", "Gb2"].Cut().Labling(x => x.Area >= 5).Count());

//Matching
Console.WriteLine(D["Effective", "Gr","R","B","Gb"].Matching());
foreach (var i in D["Effective", "Gr", "R", "B", "Gb"].MatchingList())
    Console.WriteLine($"({i % D.FullWidth},{i / D.FullWidth})");

//WD 出力10%程度のバラつきあり

//出力10%程度のバラつきあり、だいたい25%Countズレる -> 閾値厳しくする場合highシャッタとの差分の方がいい
/*
Console.WriteLine(C["Effective"].Count(x => x > 58));

Console.WriteLine(C["Effective", "Gr","R"].Count(x => x > 64));
Console.WriteLine(C["Effective", "B","Gb"].Count(x => x > 64));
Console.WriteLine(C["Effective"].Count(x => x > 127));
Console.WriteLine(C["Effective"].Count(x => x > 255));

Console.WriteLine(C["HOB-L"].Count(x => x > 64));
Console.WriteLine(C["HOB-R"].Count(x => x > 64));
*/






//raw = raw["Full", "Gr1"].Acc(x => (float)0);
//raw = raw["Full", "Gr"].Cut();
/*

var A = new List<(int x, int y)>()
{
    (-1,-1),
    (1,-1),
    (0,0),
    (-1,1),
    (1,1),
};
var raw2 = raw["Effective", "Gr", "Gb", "R", "B"].AccBox<float, float>(A, x => { Array.Sort(x); return x[2]; }, raw.Clone());
raw2 = raw2["HOB-L", "M"].AccBox<float, float>(A, x => { Array.Sort(x); return x[2]; }, raw2.Clone());
raw2 = raw2["HOB-R", "M"].AccBox<float, float>(A, x => { Array.Sort(x); return x[2]; }, raw2.Clone());
raw = raw["Full"].Acc<float, float>(raw2, (x, y) => x - y, raw.Clone(false));

    */
/*
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
*/


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

