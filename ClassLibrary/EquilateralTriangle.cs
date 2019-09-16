using System;

namespace Challenge1 {
    public class EquilateralTriangle : Triangle {
        public EquilateralTriangle(string colour, float side1Length) : base(colour, side1Length, side1Length, side1Length) {
            
        }

        public float GetArea() {
            return (float)Math.Sqrt(3) / 4 * Side1Length * Side1Length;
        }
    }
}