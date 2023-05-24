using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力");
            do {
                var city = Console.ReadLine();
                if (string.IsNullOrEmpty(city)) {
                    break;
                }
                var citys = names.FindIndex(s => s == city);
                Console.WriteLine(citys);
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var city = names.Where(s => s.Contains('o')).ToArray();
            foreach (var s in city) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var city = names.Where(s => s[0] == ('B')).Select(s => s.Length);
            foreach (var s in city) {
                Console.WriteLine(s);
            }
        }
    }
}
