using System;
using NUnit.Framework;

namespace Challenge1.Tests {
    [TestFixture]
    public class Tests {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }
       
        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }
       
        [SetUp]
        public void Init() {
            sq1 = new Square("Blue", 4);
            rec1 = new Rectangle("Red", 4, 3);
            
            sq2 = new Square("Blue", 6);
            rec2 = new Rectangle("Red", 5, 4);
        }
        
        [Test]
        public void SquareTests() {
            int area = 16;
            int perimeter = 16;
            
            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());
            
            area = 36;
            perimeter = 24;
            
            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());

        }

        [Test]
        public void RectangleTests() {
            int area = 12;
            int perimeter = 14;
            
            Assert.AreEqual(area, rec1.GetArea());
            Assert.AreEqual(perimeter, rec1.GetPerimeter());

            area = 20;
            perimeter = 18;
            
            Assert.AreEqual(area, rec2.GetArea());
            Assert.AreEqual(perimeter, rec2.GetPerimeter());

        }
        
    }
}