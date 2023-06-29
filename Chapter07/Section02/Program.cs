using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            var prefDict = new Dictionary<string, List<CityInfo>>();
            string pref, city;
            int population;

            Console.WriteLine("都市の登録");
            while (true) {
                Console.Write("県名：");
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.Write("市町村：");
                city = Console.ReadLine();

                Console.Write("人口：");
                population = int.Parse(Console.ReadLine());

                //市町村情報インスタンスの生成
                var cityInfo = new CityInfo {
                    City = city,
                    Population = population,
                };

                if (!prefDict.ContainsKey(pref)) {
                    prefDict[pref] = new List<CityInfo>(); //既に県名が未登録ならリスト作成
                }
                prefDict[pref].Add(cityInfo);
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if (selected == "1") {
                //一覧表示
                foreach (var prefData in prefDict) {
                    foreach (var cityData in prefData.Value) {
                        Console.WriteLine("{0}【{1}(人口：{2}人)】", prefData.Key, cityData.City, cityData.Population);
                    }
                }
            } else {
                //県名指定表示
                Console.Write("県名を入力：");
                var inputPref = Console.ReadLine();
                foreach (var cityData in prefDict[inputPref]) {
                    Console.WriteLine("{0}【{1}(人口：{2}人)】", inputPref, cityData.City, cityData.Population);
                }
            }
        }
    }
}

class CityInfo {
    public string City { get; set; }        //都市
    public int Population { get; set; }     //人口
}