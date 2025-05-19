using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_49.Model.Entities;

namespace exercise_49.Model.Entities {
    class Circle : AbstractShape {
        internal Color Color;

        public double Radius { get; set; }

        public override double Area() {
            return Math.PI * Radius * Radius;
        }

        public override string ToString() {
            return $"Circle: Color = {Color}, Radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}, Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
