namespace Challenge1 {
    public class Triangle : Shape {
        public float Side1Length;
        public float Side2Length;
        public float Side3Length;

        public Triangle(string colour, float side1Length, float side2Length, float side3Length) : base(colour) {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;

            if(side1Length <= 0 || side2Length <= 0 || side3Length <= 0) {
                throw new NonPositiveLengthException();
            }
        }

        public float GetPerimeter() {
            return Side1Length + Side2Length + Side3Length;
        }
    }
}