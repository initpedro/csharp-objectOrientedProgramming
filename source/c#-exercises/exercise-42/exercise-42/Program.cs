using System.IO;
using System;

namespace exercise42 {
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\windows\temp\File1.txt";
            // Stream genérica
            FileStream fs = null;
            // Stream particular otimizada
            StreamReader sr = null;
            try {
                // Instanciado para abrir - Conversa com o Sistema Operacional
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            } catch (IOException ex) {
                Console.WriteLine($"An error accurred");
                Console.WriteLine(ex.Message);
            }
            
            // Fechar streams
            finally {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}