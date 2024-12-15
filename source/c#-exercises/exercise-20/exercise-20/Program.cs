using System;

namespace exercise20
{
    internal class Program {
        static void Main(string[] args) {
            double[,] mat = new double[2, 4];

            // Elementos na matriz
            Console.WriteLine(mat.Leng

            // Quanto é a primeira dimensão da matriz (linhas) e rcorre as col
            Console.WriteLine(mat.Rank);

            // Quantidade de linh
            Console.WriteLine(mat.GetLength(0));

            // Segunda dimensão, quantidade de col
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
