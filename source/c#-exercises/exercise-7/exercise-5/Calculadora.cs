﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_7 {
    internal class Calculadora {

        public static double Pi = 3.14;

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
    }
}
