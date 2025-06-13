﻿using System;
using System.Runtime.CompilerServices;

namespace exercise21
{
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                // Executar cada coluna em uma determinada linha
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine($"Main diagonal:");
            for (int i = 0; i < n; ++i) {
                Console.Write($"{mat[i, i]} ");
            }

            int count = 0;
            // Percorrer toda matriz
            for (int i = 0;i < n; ++i) {
                for (int j = 0; j < n; ++j) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Negative numbers: {count}");
        }
    }
}