using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
#region flower
            var flowerDict = new Dictionary<string, int>() {

                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };

            //morning glory(あさがお)【250円】を追加
            flowerDict["morning glory"] = 250;

            Console.WriteLine("ひまわりの価格は{0}円です。：", flowerDict["sunflower"]);
            Console.WriteLine("チューリップの価格は{0}円です。：", flowerDict["tulip"]);
            Console.WriteLine("あさがおの価格は{0}円です。：", flowerDict["morning glory"]);
            #endregion

#region 県庁所在地

            Console.WriteLine("県庁所在地の登録");
            var citys = new Dictionary<string, CityInfo>();

            Console.Write("県：");
            string pref = Console.ReadLine();

            while (pref != "999") {
                var cityinfo = new CityInfo();
                Console.Write("県庁所在地：");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口：");
                cityinfo.Population = int.Parse(Console.ReadLine()); 

                if (citys.ContainsKey(pref)) {
                    Console.WriteLine("既に県名が登録されています。");
                    Console.WriteLine("上書きしますか？ y/n：");
                    if (Console.ReadLine() == "y") {
                        //登録処理
                        citys[pref] = cityinfo;
                    }
                } else {
                    citys.Add(pref, cityinfo);
                }
                Console.Write("県：");
                pref = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            var select = Console.ReadLine();
            if (select == "1") {
                var obd = citys.OrderByDescending(x => x.Value.Population);
                foreach (var item in obd) {
                    Console.WriteLine("{0}[{1}(人口:{2})]",item.Key,item.Value.City,item.Value.Population);
                }
            } else {
                Console.Write("県名を入力：");
                var ken = Console.ReadLine();
                Console.WriteLine(citys[ken].City + "人口" + citys[ken].Population);
            }
        }
    }
    class CityInfo {
        public string City { get; set; }        //都市
        public int Population { get; set; }     //人口
    }
    #endregion
}
