using CalcSquareLibrary;
using NUnit.Framework;
using System;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        public void TriangleNegativeTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -10, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
        }

        [Test]
        public void CircleNegativeTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        [Test]
        public void TriangleCalcTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.GetSquare();

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        [Test]
        public void TriangleRightTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var IsRightTriangle = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(true, IsRightTriangle);
        }

        [Test]
        public void TriangleNegativeRightTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }

        [Test]
        public void CircleCalcTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.GetSquare();

            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }
    }
}