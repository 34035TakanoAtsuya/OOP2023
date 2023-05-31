using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("変換数字");
            var line = Console.ReadLine();
            int num;
            if (int.TryParse(line,out num)) {
                Console.WriteLine("{0:#,#}",num);
            } else {
                Console.WriteLine("数値文字列ではありません。");
            }
        }
    }
}
