using System;
using System.Collections.Generic;

namespace exercise56 {
    internal class Program {
        static void Main(string[] args) {
            SortedSet<int> a = new SortedSet<int>() {
                0, 2, 4, 5, 6, 8, 10
            };
            SortedSet<int> b = new SortedSet<int>() {
                5, 6, 7, 8, 9, 10
            };

            // União
            // Instânciando todos elementos de A in C
            SortedSet<int> c = new SortedSet<int>(a);

            // União algébrica de conjuntos - Sem repetição e ordenados
            c.UnionWith(b);
            PrintCollection(c);

            // Interseção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // Diferença - Diferença de a-b = e
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}