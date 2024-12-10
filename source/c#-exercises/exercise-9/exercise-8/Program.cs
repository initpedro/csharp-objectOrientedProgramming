using exercise_9;
using System;
using System.Globalization;

namespace exercise9 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine();
            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizados: {p}");

            Console.Write("\nDigite o número de produtos a ser removidos ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}
