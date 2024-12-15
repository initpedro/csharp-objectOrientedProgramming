using System;
using System.Collections.Generic;

namespace exercise18 {
    internal class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();
            list.Add("Pedro");
            list.Add("Júlia");
            list.Add("Helena");
            list.Add("Abelha");
            list.Add("Análise");
            list.Insert(2, "Elenice");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            // Contador
            Console.WriteLine($"List count: {list.Count}");

            // Função lambda do static bool "static bool Test(string s) {
            //return s[0] == 'A';
            //}"
            // Primeiro nome com letra A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");

            // Último nome com letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First position 'A': {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Pedro");
            Console.WriteLine("----------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------");
            list.RemoveAll(x => x[0] == 'E');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            list.RemoveAt(2);
            Console.WriteLine("----------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }


    }
}