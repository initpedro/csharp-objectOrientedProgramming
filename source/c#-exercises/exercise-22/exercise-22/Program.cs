using System;

namespace exercise22
{
    internal class Program {
        static void Main(string[] args) {
            string original = "abcde FGHIJ ABC abc DEFG  

            // Tudo maiúsculo
            string s1 = original.ToUpper();

            // Tudo minúsculo
            string s2 = original.ToLower(

            // Tirar todos espaçamentos
            string s3 = original.Trim();

            // Conta onde começa 
            int n1 = original.IndexOf("bc");

            // Conta onde termina
            int n2 = original.LastIndexOf("bc");

            // Recortar string
            string s4 = original.Substring(3);

            // Sobrecarga - 5 caracteres a partir de 3
            string s5 = original.Substring(3, 5);

            // Substituir string - A por X
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            // Testar se string é vazia
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: {original} -");
            Console.WriteLine($"ToUpper: {s1} -");
            Console.WriteLine($"ToLower: {s2} -");
            Console.WriteLine($"Trim: {s3} -");
            Console.WriteLine($"IndexOf ('bc'): {n1} -");
            Console.WriteLine($"LastIndexOf ('bc'): {n2} -");
            Console.WriteLine($"Substring ('3'): {s4} -");
            Console.WriteLine($"Substring ('3, 5'): {s5} -");
            Console.WriteLine($"Replace ('a', 'x'): {s6} -");
            Console.WriteLine($"Replace ('a', 'x'): {s7} -");

            // False - não é nula
            Console.WriteLine($"IsNullOrEmpty: {b1} -");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2} -");

        }
    }
}
