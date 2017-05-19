
//前処理, Color処理はRG
raw = PrePro(raw);
raw = ColorTest(raw);
//スペックの表示
//var r = Spec(raw);
//raw = raw.FilterHOB();

/*********** Method **********/
public Pixel<float> ColorTest(Pixel<float> src)
{
    raw = raw["Active"];
    //前処理, Color処理はRG
    for (int c = 0; c < 4; c++)
        for (int y = 0; y < raw.HeightColor(c); y++)
        {
            for (int x = 0; x < raw.WidthColor(c); x++)
            {
                raw[c, x, y] = c * 35;
            }
        }
}
public Pixel<float> PrePro(Pixel<float> src)
{
    //Color = RG
    return raw["Normal"].StaggerRSelf();
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
}


//var buf = raw.ToPixelInt32();
//var i = buf[0];
//var line = String.Join("\r\n", raw["Active"].AverageV());