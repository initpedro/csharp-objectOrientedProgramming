using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using exercise37.Entities.Exceptions;

namespace exercise37.Entities {
    internal class Reservation {
        public int RoomNumer { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {

        }

        public Reservation(int roomNumer, DateTime checkIn, DateTime checkOut) {

            if (checkOut <= checkIn) {
                throw new DomainException($"Error in reservation data!");
            }

            RoomNumer = roomNumer;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) {

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now) {
                throw new DomainException($"Error in reservation data!");
            } if (checkOut <= checkIn) {
                throw new DomainException($"Error in reservation data!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }

        public override string ToString() {
            return $"Room {RoomNumer}, check-ing: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights.";
        }
    }
}
