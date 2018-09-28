using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovsSubstitution
{
    public class Rectangle : IShape
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Rectangle() { }
        public Rectangle(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }

        public virtual decimal CalculateArea() => Width * Height;
    }
}
