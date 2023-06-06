using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var lines = line.Replace("Novelist", "作家").Replace("BestWork", "代表作").Replace("Born","誕生年").Split(';');

            foreach (var s in lines) {
                Console.WriteLine(s);
            }
        }
    }
}
