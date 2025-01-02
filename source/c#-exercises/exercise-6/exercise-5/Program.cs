﻿using exercise_5;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace exercise6 {
    internal class Program {

        static void Main(string[] args) {

            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {calc.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

       
    }
}
