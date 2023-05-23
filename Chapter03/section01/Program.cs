using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            //3以上8未満
            //int count = numbers.Count(n => 0 < n && n % 5 == 0);

            //合計値
            var sum = numbers.Where(n => n % 2 == 0).Sum();
            Console.WriteLine(sum);
        }
    }
}