using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountPerStore = sales.GetPerStoreSales();
            var amountPerCategory = sales.GetPerCategorySales();

            Console.WriteLine("**売上集計**");
            Console.WriteLine("店舗別売り上げ");
            Console.WriteLine("商品カテゴリー別売り上げ");
            Console.Write(">");
            int select = int.Parse(Console.ReadLine());

            if (select == 1) {
                foreach (var obj in amountPerStore) {
                    Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
                }
            } else {
                foreach (var obj in amountPerCategory) {
                    Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
                }
            }

        }
    }
}
