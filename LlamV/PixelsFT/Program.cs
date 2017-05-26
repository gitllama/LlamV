using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pixels;
using Pixels.Math;
using Pixels.Stream;
using Pixels.Extend;

namespace PixelsFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.Run();

            return;
        }
    }

    public static class Test
    {
        public static void Run()
        {
            var Seq = PixelSeqParam.Create("Config.yaml");
            var chips = Seq.CheckedChips(@"D:\200CFT\");

            ChipStatusMediator Chip;
            foreach (var _Chip in chips)
            {
                Chip = ChipStatusMediator.Create(_Chip);

                Chip["Dark", "Ave"]
                    .Filter(x => x["Normal"].StaggerRSelf())
                    ["Active"]
                    .Signal("Gr1", "R1", "Gb1", "B1", "Gr2", "R2", "Gb2", "B2");
                Chip["L10", "Ave"]
                    .Filter(x => x["Normal"].StaggerRSelf())
                    ["Active"]
                    .Signal("Gr1","R1","Gb1","B1", "Gr2", "R2", "Gb2", "B2");
                Chip["L50", "Ave"]
                    .Filter(x => x["Normal"].StaggerRSelf())
                    ["Active"]
                    .Signal("Gr1", "R1", "Gb1", "B1", "Gr2", "R2", "Gb2", "B2");
                Chip["L90", "Ave"]
                    .Filter(x => x["Normal"].StaggerRSelf())
                    ["Active"]
                    .Signal("Gr1", "R1", "Gb1", "B1", "Gr2", "R2", "Gb2", "B2");
                Chip["L300", "Ave"]
                    .Filter(x => x["Normal"].StaggerRSelf())
                    ["Active"]
                    .Signal("Gr1", "R1", "Gb1", "B1", "Gr2", "R2", "Gb2", "B2");
                //Chip["Dark", "Ave"]
                //.Filter(x => x["Normal"].StaggerRSelf()["Full"].FilterMedianBayer(1, 5, 2))
                //["Effective"]
                //VFPN
                //Chip["Dark", "Ave-hob"]
                //    .Filter(x => x["Normal"].StaggerR())
                //    ["Active"]
                //    .Signal();



                //Chip["Dark60", "Ave"]
                //    .Intermediate(x => x.FilterMedianBayer()["Normal"].StaggerR())
                //    .Filter(x => x["Normal"].StaggerR())
                //    ["Active"]
                //    .Labeling();


                //Chip["Dark", "Ave-hob"]
                //    .Filter(x => x["Normal"].StaggerR())
                //    ["Active"]
                //    .Signal();

                //Chip["L10SH", "Ave"]
                //    .Filter(x => x["Normal"].StaggerR())
                //    ["HOB-L"]
                //    .Signal();

                //平均・偏差

                //Chip["Dark", "Ave"]
                //    .Intermediate(x => x.FilterMedianBayer()["Normal"].StaggerR())
                //    .Filter(x => x["Normal"].StaggerR())
                //    ["Active"]
                //    .Signal()
                //    .Defect(255)
                //    .Defect(125)
                //    .Defect(64);

                //Chip["L50", "Ave"]
                //    .Filter(x =>
                //    {
                //        var i = x.FilterMedianBayer();
                //        return i["Normal"].StaggerR();
                //    })
                //    .Convert(x => x["Normal"].StaggerR())
                //    ["Active"].Signal2();


                //平均（中央値フィルタ後）
                //Chip["Dark", "Ave"]
                //    .Convert(x => x["Normal"].StaggerR())
                //    ["Active"].Signal();



                //chip単位の結果出力, 追記
                Chip.OutputFile("output.yaml");


            }
        }
    }
}
