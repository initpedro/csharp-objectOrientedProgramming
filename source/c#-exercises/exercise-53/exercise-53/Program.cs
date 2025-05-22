using exercise_53;
using System;


namespace exercise53 {
    internal class Program {
        static void Main(string[] args) {

            PrintService printService = new PrintService();

            Console.WriteLine($"How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine($"Firt: {printService.First}");
        }
    }
}