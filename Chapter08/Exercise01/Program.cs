using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);

        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            Console.WriteLine("{0} {1}", dateTime.ToString("d"), dateTime.ToString("t"));
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            Console.WriteLine("{0} {1}", dateTime.ToString("D"), dateTime.ToString("HH時mm分ss秒"));
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            var cul = new CultureInfo("ja-JP");
            cul.DateTimeFormat.Calendar = new JapaneseCalendar();
            Console.WriteLine(dateTime.ToString("ggyy年 M月d日(dddd)", cul ));
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            var cul = new CultureInfo("ja-JP");
            cul.DateTimeFormat.Calendar = new JapaneseCalendar();
            var date = dateTime.ToString("ggyy年 M月d日(dddd)", cul);
            //ゼロサプレスを実施(不要なゼロを取り除く)
            var str = Regex.Replace(date, @"0(\d)", "$1");
            Console.WriteLine(str);
        }
    }
}
