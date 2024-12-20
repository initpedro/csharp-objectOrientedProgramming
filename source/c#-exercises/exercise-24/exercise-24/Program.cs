using System;
using System.Xml;

namespace exercise24
{
    internal class Program {
        static void Main(string[] args) {
            //TimeSpan t1 = new TimeSpan();
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);
            //TimeSpan t2 = new TimeSpan(900000000L);
            //Console.WriteLine(t2);
            //TimeSpan t3 = new TimeSpan(2, 11, 21);
            //Console.WriteLine(t3);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //Console.WriteLine(t4);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            //Console.WriteLine(t5);

            // From - conversar com qualquer unidade
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t1);

            TimeSpan t2 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t3);

            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t4);

            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t6);
        }
    }
}