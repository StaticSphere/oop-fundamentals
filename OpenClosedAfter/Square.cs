namespace OpenClosedAfter
{
    public class Square : IShape
    {
        public decimal Height { get; set; }

        public Square() { }
        public Square(decimal height) => Height = height;

        public decimal CalculateArea() => Height * Height;
    }
}
