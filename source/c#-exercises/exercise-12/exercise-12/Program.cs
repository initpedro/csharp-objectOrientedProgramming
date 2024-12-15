using System;
using System.Globalization;
using System.Net.Http.Headers;
using exercise_12;

namespace exercise12
{
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                // Somar o Price
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}