using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();

        }

        private static void Exercise1_2() {
            var price = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var count = Library.Books.OrderBy(b => b.PublishedYear)
                                     .GroupBy(b => b.PublishedYear);
            foreach (var books in count) {
                Console.WriteLine("{0}年  {1}冊", books.Key, books.Count());

            }
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear)
                               .ThenByDescending(b => b.Price)
                               .Join(Library.Categories, book => book.CategoryId,
                                                             category => category.Id,
                                                             (book, category) => new {
                                                                 Title = book.Title,
                                                                 Category = category.Name,
                                                                 Publishedyear = book.PublishedYear,
                                                                 Price = book.Price
                                                             });
            foreach (var item in books) {
                Console.WriteLine($"{item.Publishedyear}年,{item.Price}円,{item.Title},({item.Category})");
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books
                                    .Where(b => b.PublishedYear == 2016)
                                    .Join(Library.Categories, book => book.CategoryId, category => category.Id,
                                    (book, category) => category.Name).Distinct();
            foreach (var item in names) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories.GroupJoin(Library.Books, c => c.Id,
                                                                    b => b.CategoryId,
                                                                    (c, book) => new { Category = c.Name, Books = book }).OrderBy(b => b.Category);
            foreach (var group in groups) {
                Console.WriteLine(group.Category);
                foreach (var book in group.Books) {
                    Console.WriteLine($"{book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var catid = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books.Where(b => b.CategoryId == catid)
                                      .GroupBy(b => b.PublishedYear)
                                      .OrderBy(b => b.Key);
            foreach (var group in groups) {
                Console.WriteLine("#{0}年",group.Key);
                foreach (var book in group) {
                    Console.WriteLine(" {0}",book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories.GroupJoin(Library.Books, c => c.Id,
                                                                  b => b.CategoryId,
                                                                  (c, b) => new { Category = c.Name, count = b.Count() })
                                                                  .Where(x => x.count >= 4);
            foreach (var category in groups) {
                    Console.WriteLine(category.Category);
            }
        }
    }
}