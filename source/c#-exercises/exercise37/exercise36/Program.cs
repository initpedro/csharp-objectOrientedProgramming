using System;

namespace exercise36 {
    internal class Program {
        static void Main(string[] args) {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            } catch (DivideByZeroException ex) {
                Console.WriteLine($"Error! {ex.Message}");
            } catch (FormatException e) {
                Console.WriteLine($"Format error! {e.Message}");
            }
        }
    }
}