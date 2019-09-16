using System;
using NUnit.Framework;

namespace Challenge1.Tests {
    [TestFixture]
    public class TriangleTests {
        RightAngleTriangle ra1 { get; set; }
        EquilateralTriangle eq1 { get; set; }
        
        RightAngleTriangle ra2 { get; set; }
        EquilateralTriangle eq2 { get; set; }


        [SetUp]
        public void Init() {
            ra1 = new RightAngleTriangle("White", 3, 4);
            eq1 = new EquilateralTriangle("black", 6);
            
            ra2 = new RightAngleTriangle("White", 7, 4);
            eq2 = new EquilateralTriangle("black", 8);
        }
        
 
        
        [Test]
        public void RightAngleTriangleTests() {
            float area = 6;
            float perimeter = 12;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(ra1.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(ra1.GetPerimeter(), 2));
            area = 14;
            perimeter = 19.06f;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(ra2.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(ra2.GetPerimeter(), 2));

        }
        
        [Test]
        public void EquilateralTriangleTests() {
            float area = 15.59f;
            float perimeter = 18;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(eq1.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(eq1.GetPerimeter(), 2));
            
            area = 27.71f;
            perimeter = 24;
            
            Assert.AreEqual(Math.Round(area,2), Math.Round(eq2.GetArea(),2));
            Assert.AreEqual(Math.Round(perimeter,2), Math.Round(eq2.GetPerimeter(), 2));
        }
    }
}