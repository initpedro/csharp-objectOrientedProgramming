using System;
using exercise_13;

namespace exercise13
{
    internal class Program {
        static void Main(string[] args) {
            Estudante[] vect = new Estudante[10];
            Console.Write("Quantos quartos vão ser alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 1 ; i < 10 ; i++) {
                if (vect[i] != null ) {
                    Console.WriteLine($"{i}: {vect[i]}" );
                }
            }
        }
    }
}