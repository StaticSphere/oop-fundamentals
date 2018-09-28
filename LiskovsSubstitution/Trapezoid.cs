namespace LiskovsSubstitution
{
    public class Trapezoid : Rectangle
    {
        public decimal Width2 { get; set; }

        public Trapezoid() : base() { }
        public Trapezoid(decimal width, decimal width2, decimal height)
            :base(width, height)
        {
            Width2 = width2;
        }

        public override decimal CalculateArea() => (Width + Width2) / 2 * Height;
    }
}
