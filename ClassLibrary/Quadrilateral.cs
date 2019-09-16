namespace Challenge1 {
    public class Quadrilateral : Shape {
        public int Side1Length;
        public int Side2Length;
        public int Side3Length;
        public int Side4Length;

        public Quadrilateral(string colour, int side1Length, int side2Length, int side3Length, int side4Length) : base(colour) {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
            Side4Length = side4Length;

            if(side1Length <= 0 || side2Length <= 0 || side3Length <= 0 || side4Length <= 0) {
                throw new NonPositiveLengthException();
            }
        }

        public int GetPerimeter() {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }
    }
}