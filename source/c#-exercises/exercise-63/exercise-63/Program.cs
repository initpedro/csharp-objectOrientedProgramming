using System;
using exercise_63.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace exercise63 {
    internal class Program {

        static void print<T>(string message, IEnumerable<T> collection) {
            Console.WriteLine(message);
            foreach (T obj in collection) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {
            Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> produtos = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 100.0, Category = c1},
                new Product() { Id = 3, Name = "TV", Price = 900.0, Category = c3}
            };

            var r1 = produtos.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            print("TIER 1 and PRICE < 900:", r1);

            var r2 = produtos.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            print("NAMES OF PRODUCTS FROM TOOLS", r2);

            var r3 = produtos.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = produtos.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = produtos.FirstOrDefault();
            Console.WriteLine(r6);

            var r7 = produtos.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine(r7);

            var r8 = produtos.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine(r8);

            var r9 = produtos.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine(r9);

            var r10 = produtos.Max(p => p.Price);
            Console.WriteLine(r10);

            var r11 = produtos.Min(p => p.Price);
            Console.WriteLine(r11);

            var r12 = produtos.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine(r12);

            var r13 = produtos.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine(r13);

            var r14 = produtos.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(r14);

            var r15 = produtos.Where(p => p.Category.Id == 1).Select(p = > p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine(r15);

            var r16 = produtos.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16) {
                Console.WriteLine($"Category: {group.Key.Name}");
                foreach (Product p in group) {
                    Console.WriteLine(p);
                }
            }
        }
    }
}