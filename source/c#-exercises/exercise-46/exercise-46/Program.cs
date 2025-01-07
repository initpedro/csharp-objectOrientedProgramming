using System;
using System.IO;
using System.Collections.Generic;

namespace exercise46 {
    internal class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\Pedro\AppData\Local\Temp\Test";

            try {
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine($"FOLDERS: ");
                foreach (string s in folder) {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine($"FILES: ");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory($"{path}\\newfolder");
                } catch (Exception ex) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}