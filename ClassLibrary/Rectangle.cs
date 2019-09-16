namespace Challenge1 {
    public class Rectangle : Quadrilateral {
        public Rectangle(int side1Length, int side2Length, string colour) : base(side1Length, side2Length, side1Length, side2Length, colour) {
            
        }

        public int GetArea() {
            return Side1Length * Side2Length;
        }
    }
}