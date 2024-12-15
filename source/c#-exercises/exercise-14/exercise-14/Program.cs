using System;
using System.Globalization;
using exercise_14;

namespace exercise14 {
    internal class Program {
        static void Main(string[] args) {
            int s1 = Calculator.Sum(1, 2, 3, 4, 5);
            int s2 = Calculator.Sum(2, 8);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}