using exercise_49.Model.Enums;

namespace exercise_49.Model.Entities {
    abstract class AbstractShape :IShape {

        public Color MyProperty { get; set; }

        public abstract double Area();
    }
}
