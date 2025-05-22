using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_50.Devices {
    class Printer :Device, IPrinter {
        public override void ProcessDoc(string document) {
            Console.WriteLine($"Printer processing: {document}");
        }

        public void Print(string document) {
            Console.WriteLine($"Printer printing: {document}");
        }
    }
}
