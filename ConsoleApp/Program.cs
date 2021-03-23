using System;
using System.Collections.Generic;
using System.Linq;
using CalcSquareLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<ICalculateArea> figures = new List<ICalculateArea>();
            figures.Add(new Triangle(15, 20, 25));
            figures.Add(new Circle(5));
            figures.Add(new Triangle(5, 7, 9));

            foreach (var item in figures)
            {
                Console.WriteLine($"Type{item.GetType()} S={item.GetSquare()} ;");
            }
        }
    }
}