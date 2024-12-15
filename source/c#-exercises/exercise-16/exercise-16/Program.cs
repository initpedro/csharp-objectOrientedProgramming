using System;
using exercise_16;

namespace exercise16
{
    internal class Program {
        static void Main(string[] args) {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}