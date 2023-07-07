using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var datetime = DateTime.Now;

            var day = datetime.ToString("d");

            foreach (var dayofweek in Enum.GetValues(typeof( DayOfWeek)) ) {
                var format = NextDay(datetime, (DayOfWeek)dayofweek).ToString("yyyy年M月d日(ddd)");
                Console.WriteLine("{0}の次の週の{1}：{2}", day, dayofweek, format);
            }
        }
        public static DateTime NextDay(DateTime date, DayOfWeek dayofweek) {
            var days = (int)dayofweek - (int)(date.DayOfWeek);
            if (days >= -1)
                days += 7;
            return date.AddDays(days);
        }
    }
}
