namespace Challenge1 {
    public class Square : Quadrilateral {
        public Square(int side1Length, string colour) : base(side1Length, side1Length, side1Length, side1Length, colour) {
            
        }

        public int GetArea() {
            return Side1Length * Side1Length;
        }
    }
}