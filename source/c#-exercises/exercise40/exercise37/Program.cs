using System;
using exercise37.Entities;
using exercise37.Entities.Exceptions;

namespace exercise37 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.Write($"Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write($"Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write($"Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
                Console.WriteLine();
                Console.WriteLine($"Enter data to update reservation:");
                Console.Write($"Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write($"Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            } catch (DomainException e) {
                Console.WriteLine($"Errir in reservation: {e.Message}");
            }
        }
    }
}
