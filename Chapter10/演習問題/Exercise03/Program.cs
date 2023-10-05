using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var texts = new[] {
               "Time is money.",
               "What time is it?",
               "It will take time.",
               "We reorganized the timetable.",
            };
            foreach (var line in texts) {
                var matches = Regex.Matches(line,@"(T|t)ime\b");
                foreach (Match item in matches) {
                    Console.WriteLine("{0}: {1}",line,item.Index);
                }
            }
        }
    }
}
