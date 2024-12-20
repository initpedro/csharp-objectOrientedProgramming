using System;

namespace exercise25
{
    internal class Program {
        static void Main(string[] args) {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2) Day: {d.Day}");

            Console.WriteLine("----------------------");

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();
            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine($"{d2.ToLongDateString()}");
            Console.WriteLine($"{s2}");
            Console.WriteLine($"{s3}");
            Console.WriteLine($"{s4}");
            Console.WriteLine($"{s5}");
            Console.WriteLine($"{s6}");
            Console.WriteLine($"{s7}");
        }
    }
}