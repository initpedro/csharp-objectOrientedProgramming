using System.IO;
using System;

namespace exercise42 {
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\windows\temp\File1.txt";
            // Stream particular otimizada
            StreamReader sr = null;
            try {
            // Instância o StreamReader em cima de forma automática
            sr = File.OpenText(path);
                while (!sr.EndOfStream)       
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException ex) {
                Console.WriteLine($"An error accurred");
                Console.WriteLine(ex.Message);
            }
            
            // Fechar streams
            finally {
                if (sr != null) sr.Close();
            }
        }
    }
}