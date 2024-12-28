using System.Security.Cryptography;

namespace exercise_33.Entities {
    internal class OutsourcedEmployee :Employee {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() {

        }
        public override double Payment() {
            // Reaproveitar a lógica do pagamento comum
            return base.Payment() + 1.1 * AdditionalCharge;
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }
    }
}
