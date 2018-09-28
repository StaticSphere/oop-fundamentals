namespace LiskovsSubstitution
{
    public class AreaCalculator
    {
        public decimal TotalArea(params Rectangle[] shapes)
        {
            var area = 0M;

            foreach(var shape in shapes)
                area += shape.CalculateArea();

            return area;
        }
    }
}
