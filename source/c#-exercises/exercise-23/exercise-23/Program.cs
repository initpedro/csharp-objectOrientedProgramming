using System;
using System.Globalization;

namespace exercise23 {
    internal class Program {
        static void Main(string[] args) {

            // Devolve o instante atual
            // DateTime d1 = DateTime.Now;
            // Console.WriteLine(d1);
            // Console.WriteLine(d1.Ticks);

            //DateTime d1 = new DateTime(2018, 11, 25);
            //Console.WriteLine(d1);

            //DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03);
            //Console.WriteLine(d2);

            //DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);
            //Console.WriteLine(d3);

            //DateTime d4 = DateTime.Now;
            //Console.WriteLine(d4);

            //DateTime d5 = DateTime.Today;
            //Console.WriteLine(d5);

            //// Hora universal
            //DateTime d6 = DateTime.UtcNow;
            //Console.WriteLine(d6);

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-16 13:05:58");
            //DateTime d3 = DateTime.Parse("15/08/2000");
            //DateTime d4 = DateTime.Parse("15/08/2000 15:5:58");
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d2);
        }
    }
}
