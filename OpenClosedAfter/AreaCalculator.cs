namespace OpenClosedAfter
{
    public class AreaCalculator
    {
        public decimal TotalArea(IShape[] shapes)
        {
            var area = 0M;

            // This code satisfies the Open/Closed principle. If I need to
            // add a new shape, I simply create a new class that derives from
            // IShape.  My code codes into THAT class, and this one is left
            // unmodified.  It also does not need to change if I need to alter
            // how a shape is calculated. I would make that change in the shape
            // class itself, rather than in the AreaCalculator, which really only
            // cares about summing are values.
            foreach(var shape in shapes)
                area += shape.CalculateArea();

            return area;
        }
    }
}
