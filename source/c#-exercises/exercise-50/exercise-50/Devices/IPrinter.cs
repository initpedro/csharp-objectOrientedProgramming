using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_50.Devices {
    internal interface IPrinter {
        void Print(string document);
        void ProcessDoc(string document);
    }
}
