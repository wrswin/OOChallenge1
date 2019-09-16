namespace Challenge1 {
    public class Rectangle : Quadrilateral {
        public Rectangle(string colour, int side1Length, int side2Length) : base(colour, side1Length, side2Length, side1Length, side2Length) {
            
        }

        public int GetArea() {
            return Side1Length * Side2Length;
        }
    }
}