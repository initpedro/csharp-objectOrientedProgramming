using exercise_3;
using System;
using System.Globalization;

namespace exercise3 {
    internal class Program {
        static void Main(string[] args) {
            dadosPessoa pessoa1, pessoa2;
            pessoa1 = new dadosPessoa();
            pessoa2 = new dadosPessoa();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("\nDados do segundo funcionário:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (double)(pessoa1.salario + pessoa2.salario) / 2;

            if (pessoa1.salario > pessoa2.salario) {
                Console.WriteLine($"\nO salário maior é de: {pessoa1.nome}");
            } else {
                Console.WriteLine($"\nO salário maior é de: {pessoa2.nome}");
            }

            Console.WriteLine($"Salário médio: {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}