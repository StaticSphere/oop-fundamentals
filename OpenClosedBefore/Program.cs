using System;

namespace OpenClosedBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new object[]
            {
                new Square(14),
                new Circle(10),
                new Triangle(5, 6)
            };
            var calc = new AreaCalculator();

            Console.WriteLine(calc.TotalArea(shapes));
        }
    }
}
