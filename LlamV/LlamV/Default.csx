
//前処理, Color処理はRG
raw = PrePro(raw);

//スペックの表示
var r = Spec(raw);

//選択範囲の確認
var x = raw["Trim"].Left;
var y = raw["Trim"].Top;
var w = raw["Trim"].Width;
var h = raw["Trim"].Height;

//選択範囲のフィルター
raw = raw["Trim"].FilterAverageV();



//var buf = raw.ToPixelInt32();
//var i = buf[0];
//var line = String.Join("\r\n", raw["Active"].AverageV());

//関数

public Pixel<float> PrePro(Pixel<float> src) => raw["Normal"].StaggerLSelf();
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
