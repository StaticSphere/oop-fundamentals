namespace OpenClosedAfter
{
    public class Triangle : IShape
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Triangle() { }
        public Triangle(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }

        public decimal CalculateArea() => Width * Height * 0.5M;
    }
}
