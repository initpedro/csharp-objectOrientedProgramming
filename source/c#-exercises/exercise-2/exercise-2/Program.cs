using System;
using System.Runtime.CompilerServices;

namespace exercise2 {
    internal class Program {
        static void Main(string[] args) {
            DadosPessoa pessoa1, pessoa2;
            pessoa1 = new DadosPessoa();
            pessoa2 = new DadosPessoa();

            Console.WriteLine("Digite os dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.nomePessoa = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa1.idadePessoa = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite os dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.nomePessoa = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa2.idadePessoa = int.Parse(Console.ReadLine());

            if (pessoa1.idadePessoa > pessoa2.idadePessoa) {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.nomePessoa}");
            } else {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.nomePessoa}");
            }

        }
    }
}