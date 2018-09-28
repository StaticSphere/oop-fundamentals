namespace OpenClosedBefore
{
    public class Triangle
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Triangle() { }
        public Triangle(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }
    }
}
