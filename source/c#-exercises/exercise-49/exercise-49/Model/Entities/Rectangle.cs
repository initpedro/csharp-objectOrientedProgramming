using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using exercise_49.Model.Enums;

namespace exercise_49.Model.Entities {
    class Rectangle : AbstractShape {
        public double Width { get; set; }
        public double Height { get; set; }
        public System.Drawing.Color Color { get; internal set; }

        public override double Area() {
            return Width * Height;
        }

        public override string ToString() {
            return $"Rectangle: Color = {Color}, Width = {Width.ToString("F2", CultureInfo.InvariantCulture)}, Height = {Height.ToString("F2", CultureInfo.InvariantCulture)}, Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
