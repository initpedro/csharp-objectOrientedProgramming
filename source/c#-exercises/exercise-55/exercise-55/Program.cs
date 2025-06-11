using System;
using System.Collections.Generic;

namespace exercise55 {
    internal class Program {
        static void Main(string[] args) {
            HashSet<string> set = new HashSet<string>(); // Conjunto vazio
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set) {
                Console.WriteLine(p);
            }
        }
    }
}