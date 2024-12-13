using System;
using System.ComponentModel.Design;
using System.Drawing;

namespace exercisetest {
    class Program {
        static void Main(string[] args) {
            //double? x = null;
            //double? y = 10.0;

            //// O valor que tem, ou nulo
            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //// False = sem valor
            //Console.WriteLine(x.HasValue);
            //// True = com valor
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X is null");

            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("Y is null");

            double? x = null;
            double? y = 10.0;
            double a = x ?? 5.0;
            double b = y ?? 5.0;

            // Jogou 5 pq o x é nulo
            Console.WriteLine(a);
            // Jogou 10 pq o y não é nulo, e ele já valia 10
            Console.WriteLine(b);
        }
    }
}
