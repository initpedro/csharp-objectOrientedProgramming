using System;
using System.IO;

namespace exercise41 {
    internal class Program {
        static void Main(string[] args) {
            string sourcePath = @"C:\Windows\Temp\File1.txt";
            string targetPath = @"C:\Windows\Temp\File2.txt";

            try {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}