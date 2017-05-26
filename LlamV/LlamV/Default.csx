

string result = "-----result-----\r\n";

raw = raw["Normal"].StaggerRSelf();

raw["Active"].Signal("Gr").ToText(ref result, (x) => $"Ave{x.Item1}\r\nDev{x.Item2}\r\n");

raw["HOB-L"].Signal("Gr").ToText(ref result, (x) => "Ave:{x.Average}\r\nDev:{x.Devition}\r\n");




//raw["Active"].Signal("R").ToText(result);
//raw["Active"].Signal("B").ToText(result);
//raw["Active"].Signal("Gb").ToText(result);

//foreach (var i in raw.GetIndex("Gr"))
//{
//    raw[i] = 255;
//}

//raw = raw["Full"].Cut("R");

//スペックの表示
//var r = Spec(raw);
//raw = raw.FilterHOB();

/*********** Method **********/
/*
public Pixel<float> ColorTest(Pixel<float> src)
{
    src = src["Active"];

    foreach (var c in new string[] { "R", "B" })
        for (int y = 0; y < src.HeightColor(c); y++)
            for (int x = 0; x < src.WidthColor(c); x++)
            {
                src[c, x, y] = 255000;
            }
    return src;
}
public Pixel<float> PrePro(Pixel<float> src)
{
    //Color = RG
    return src["Normal"].StaggerRSelf().DivSelf(255);
}
public void CF(Pixel<float> src)
{
    src = src["Active"]
        .Cut()
        .CutBayer(0, 0);
    src.CumulativeFrequency(
        Enumerable
            .Range(0, 256)
            .Select(x => (double)(x - 10) * 32)
            .ToArray()
          ).ToClip();
}
public string Spec(Pixel<float> src)
{
    string result = "";
    //基本スペック
    result += $"{raw["Active"].Signal()}\r\n";
    result += $"{raw["Active"].Signal()}\r\n";

    var signal2 = raw["Active"].SignalBayer();

    result += $"Average\r\n";
    result += $"Gr : {signal2.Average[0]}\r\n";
    result += $"R  : {signal2.Average[1]}\r\n";
    result += $"B  : {signal2.Average[2]}\r\n";
    result += $"Gb : {signal2.Average[3]}\r\n";

    result += $"Dev\r\n";
    result += $"Gr : {signal2.Deviation[0]}\r\n";
    result += $"R  : {signal2.Deviation[1]}\r\n";
    result += $"B  : {signal2.Deviation[2]}\r\n";
    result += $"Gb : {signal2.Deviation[3]}\r\n";

    result += $"Line\r\n";
    result += $"H : {raw["Active"].AverageH().LineStatus()}\r\n";
    result += $"V : {raw["Active"].AverageV().LineStatus()}\r\n";

    return result;
}
public double Average(Pixel<float> src)
{
    return src.Cut().Average();
}
public void Fil(Pixel<float> src)
{
    //選択範囲の確認
    var x = src["Trim"].Left;
    var y = src["Trim"].Top;
    var w = src["Trim"].Width;
    var h = src["Trim"].Height;

    //選択範囲のフィルター
    src = src["Trim"].FilterAverageV();
}


public string b2spec(Pixel<float> src)
{
    string result = "";

    result += $"{raw["Active"].Signal()}\r\n";
    result += $"{raw["Active"].Signal()}\r\n";

    return result;
}

    */
//var buf = raw.ToPixelInt32();
//var i = buf[0];
//var line = String.Join("\r\n", raw["Active"].AverageV());