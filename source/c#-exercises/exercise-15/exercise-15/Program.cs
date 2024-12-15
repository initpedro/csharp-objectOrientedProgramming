using System;
using exercise_15;

namespace exercise15
{
    internal class Program {
        static void Main(string[] args) {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}