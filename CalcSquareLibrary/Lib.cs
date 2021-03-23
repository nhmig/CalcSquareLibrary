using System;

namespace CalcSquareLibrary
{
    public interface ICalculateArea {
        double GetSquare();
    }

    public class Figure : ICalculateArea
    {
        private readonly ICalculateArea figure;

        public Figure(ICalculateArea figure)
        {
            this.figure = figure;
        }

        public double GetSquare()
        {
            return figure.GetSquare();
        }
    }


    public class Triangle : ICalculateArea
    {
        private readonly double a,b,c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetSquare()
        {
            double p = (a + b + c) / 2;
            double Square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Square;
        }

        // The Pythagorean theorem a^2+b^2=c^2
        public bool IsRightTriangle()
        {
            if ((a > b) && (a > c))
                return a * a == b * b + c * c;
            else if ((b > a) && (b > c))
                return b * b == a * a + c * c;
            else
                return c * c == a * a + b * b;
        }
    }

    public class Circle : ICalculateArea
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            this.radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * (radius * radius);
        }
    }


}
