using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
#if NonArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
#elif StringArray
            Stopwatch sw = new Stopwatch(); //タイマーインスタンス生成
            sw.Start(); //タイマースタート
            string[] line = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896"
            };
#endif

#if NonArray
            var lines = line.Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born","誕生年").Replace("=",":").Split(';');

            foreach (var s in lines) {
                Console.WriteLine(s);
            }
#elif StringArray
            for (int i = 0; i < line.Length; i++) {

                var lines = line[i].Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born", "誕生年").Replace("=",":").Split(';');
                foreach (var s in lines) {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("実行時間 = {0}",sw.Elapsed.ToString(@"ss\.fffff"));  //時間表示
#endif
        }

        //static string ToJapanese(string key){
        //  switch(key){
        //    case "Novelist":
        //        return "作家";
        //        case "BestWork":
        //        return "代表作";
        //        case "Born":
        //        return "誕生年";
        //        default:
        //        return "引数エラー";
        //  }
        //    throw new ArgumentException("正しい引数ではありません");        

    }
}
