using exercise_29.Entities;
using exercise_29.Entities.Enums;
using System;

namespace exercise29 {
    internal class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.N
                Status = exercise_29.Entities.Enums.OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
