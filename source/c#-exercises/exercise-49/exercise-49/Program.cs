using System;
using exercise_49.Model.Entities;
using exercise_49.Model.Enums;

namespace exercise49 {
    internal class Program {
        static void Main(string[] args) {

            IShape s1 = new Circle() { Radius = 2.0, Color = System.Drawing.Color.White};
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = System.Drawing.Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}