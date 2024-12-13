using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_test_struct {
    internal class Point {
        public double X;
        public double Y;

        public override string ToString() {
            return $"({X}, {Y})";
        }
    }
}
