using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    
    class Program {
        static void Main(string[] args) {

            string[] DayOfWeekJp = { "日曜日","月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" };

            #region P26のサンプルプログラム
            //インスタンスの作成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("税込価格" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込価格" + daifuku.GetPriceIncludingTax());
            #endregion

            #region 0508演習1
            //DateTime date = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;

            Console.WriteLine("今日の日付:" + date.ToString("yyyy年MM月dd日"));

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);

            Console.WriteLine("10日後:" 
                + daysAfter10.Year + "年" 
                + daysAfter10.Month + "月" 
                + daysAfter10.Day + "日");

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("10日前:" 
                + daysBefore10.Year + "年" 
                + daysBefore10.Month + "月" 
                + daysBefore10.Day + "日");
            #endregion

            #region 0508演習2
            Console.WriteLine("誕生日を入力");
            Console.Write("西暦：");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int mon = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int day = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(year, mon, day);

            TimeSpan time = today - birthday;
            Console.WriteLine("あなたが生まれてから今日まで" + time.Days + "日目です。");
            #endregion

            #region 0509演習3
            Console.WriteLine(DayOfWeekJp[(int)birthday.DayOfWeek]);
            #endregion
        }
    }
}
