using System;

namespace exercise26 {
    internal class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2000, 10, 15);
            DateTime d2 = new DateTime(2000, 10, 18);

            TimeSpan t = d2.Subtract(d);
            Console.WriteLine(t);
        }
    }
}