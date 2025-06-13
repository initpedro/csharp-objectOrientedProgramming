﻿using exercise_48.Entities;
using System;
using System.Globalization;
using exercise_48.Services;

namespace exercise48 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine($"Enter rental data: ");
            Console.Write($"Car Model: ");
            string model = Console.ReadLine();

            Console.Write($"Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write($"Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write($"Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            
            RentalService rentalServcice = new RentalService(hour, day, new BrazilTaxService());
            rentalServcice.ProcessInvoice(carRental);
            Console.Write($"INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
