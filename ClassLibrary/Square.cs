namespace Challenge1 {
    public class Square : Quadrilateral {
        public Square(string colour, int side1Length) : base(colour, side1Length, side1Length, side1Length, side1Length) {
            
        }

        public int GetArea() {
            return Side1Length * Side1Length;
        }
    }
}