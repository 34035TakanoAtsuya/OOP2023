using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            string[] moneyString = { "一万円札", "五千円札" , "二千円札" , "千円札" , "五百円玉", "百円玉" , "五十円玉", "十円玉" , "五円玉" , "一円玉" };
            int[] moneyInteger = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };

            Console.Write("金額:");
            int money = int.Parse(Console.ReadLine());
            Console.Write("支払:");
            int pay = int.Parse(Console.ReadLine());

            int change = pay - money;
            Console.WriteLine("お釣り:" + change);

            for (int i = 0; i < moneyString.Length; i++)
            {
                //Console.WriteLine(moneyString[i] + ":{0}枚", change / moneyInteger[i]);
                Console.Write(moneyString[i] + ":");
                astOut(change / moneyInteger[i]);
                change %= moneyInteger[i];
            }
        }

        private static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
