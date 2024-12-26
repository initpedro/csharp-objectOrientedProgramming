using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite a altura da árvore de Natal: ");
        int altura = int.Parse(Console.ReadLine());

        // Criando a parte superior da árvore
        for (int i = 0; i < altura; i++) {
            for (int j = 0; j < altura - i - 1; j++) {
                Console.Write(" ");
            }

            for (int k = 0; k < (2 * i + 1); k++) {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < 1; i++) {
            for (int j = 0; j < altura - 1; j++) {
                Console.Write(" ");
            }
            Console.WriteLine("I");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Árvore de Natal pronta!");
    }
}