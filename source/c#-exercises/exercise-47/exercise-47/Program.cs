using System;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime;

namespace exercise47 {
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\windows\temp\file1.txt";
            // Mostra o caractere de separação
            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            // Porção do string, deixando de lado a pasta no caminho
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            // Separar a pasta
            Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
            // Nome do arquivo com extensão
            Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
            // Nome sem extensão
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
            // Extensão do arquivo
            Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
            // Todo caminho do arquivo
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            // Caminho pasta temporária do sistema
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");
        }
    }
}
