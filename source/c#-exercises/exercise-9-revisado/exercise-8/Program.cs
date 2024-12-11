using exercise_9;
using System;
using System.Globalization;

namespace exercise9 {
    internal class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Nome);
        }
    }
}
