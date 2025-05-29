using System;
using exercise_54.Entities;

namespace exercise54 {
    internal class Program {
        static void Main(string[] args) {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b)); // Referência de conteúdo
            Console.WriteLine(a == b); // Referência de memória
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}