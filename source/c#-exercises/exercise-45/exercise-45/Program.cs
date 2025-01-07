using System;

namespace exercise45 {
    internal class Program {
        static void Main(string[] args) {
            string sourcePath = @"c:\windows\temp\File1.txt";
            string targetPath = @"c:\windows\temp\File2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }

                }

            } catch (Exception ex) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}