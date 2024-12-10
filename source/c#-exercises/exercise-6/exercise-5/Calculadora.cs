using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5 {
    internal class Calculadora {

        public double Pi = 3.14;

        public double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

        public double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

    }
}
