using System;
using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle()
        {
            Circle circle;

            circle = new Circle(5);

            Assert.AreEqual(78.5, Math.Round(circle.CalculateArea(), 1));
        }

        [TestMethod]
        public void TestRectangle()
        {
            Rectangle rectangle;

            rectangle = new Rectangle(5,6);

            Assert.AreEqual(30, rectangle.CalculateArea());

        }

        [TestMethod]
        public void TestSquare()
        {
            Square square;

            square = new Square(5);

            Assert.AreEqual(25, square.CalculateArea());
        }

        [TestMethod]
        public void TestTriangle()
        {
            Triangle triangle;

            triangle = new Triangle(5, 6);

            Assert.AreEqual(15, triangle.CalculateArea());

        }
    }
}
