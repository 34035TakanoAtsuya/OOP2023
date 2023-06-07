using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            Console.WriteLine(numbers.Average());
            var books = Books.GetBooks();

            //平均ページ数
            var page = books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages);
            Console.WriteLine("「物語」が入っている書籍の平均ページ数：" + page);

            //タイトル長い順
            var title = books.OrderByDescending(x => x.Title.Length);
            foreach (var item in title) {
                Console.WriteLine(item.Title);
            }
        }
    }
}
