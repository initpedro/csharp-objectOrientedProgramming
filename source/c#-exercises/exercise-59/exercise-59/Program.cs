using System;
using exercise_59.Extensions;

namespace exercise59 {
    internal class Program {
        static void Main(string[] args) {
            DateTime dt = new DateTime(2025, 6, 6, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}