using System;

namespace exercise27 {
    internal class Program {
        static void Main(string[] args) {
            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;
            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t.Add(t2);
            Console.WriteLine(sum);
            TimeSpan dif = t.Subtract(t2);
            Console.WriteLine(dif);
            TimeSpan mult = t2.Multiply(2.0);
            Console.WriteLine(mult);
            TimeSpan div = t2.Divide(2);
            Console.WriteLine(div);
        }
    }
}