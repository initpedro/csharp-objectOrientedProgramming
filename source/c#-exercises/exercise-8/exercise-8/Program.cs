﻿using exercise_8;
using System;
using System.Globalization;

namespace exercise8 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

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
