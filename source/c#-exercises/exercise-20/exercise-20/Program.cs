using System;

namespace exercise20
{
    internal class Program {
        static void Main(string[] args) {
            double[,] mat = new double[2, 4];

            // Elementos na matriz
            Console.WriteLine(mat.Length);

            // Quanto é a primeira dimensão da matriz (linhas) e percorre as colunas
            Console.WriteLine(mat.Rank);

            // Quantidade de linhas
            Console.WriteLine(mat.GetLength(0));

            // Segunda dimensão, quantidade de colunas
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
