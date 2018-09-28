using System;

namespace OpenClosedAfter
{
    public class Circle : IShape
    {
        public decimal Radius { get; set; }

        public Circle() { }
        public Circle(decimal radius) => Radius = radius;

        public decimal CalculateArea() => (decimal)Math.PI * Radius * Radius;
    }
}
