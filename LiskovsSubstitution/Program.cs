using System;

namespace LiskovsSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Even though Trapezoid derives from Rectangle, we all know
            // from Geometry classes that a trapezoid IS NOT a rectangle.
            // They're both quadralaterals, but a trapezoid is definitely
            // not a rectangle. As a result, when I pass the trapezoid into
            // the AreaCalculator.TotalArea method, I get back different
            // results than what I'd expect from a rectangle.  Since I cannot
            // pass in a Trapezoid instance, and get back the same result
            // as the Rectangle class that it derives from, this violates
            // Liskov's Substitution Principle.

            var calc = new AreaCalculator();

            var rect = new Rectangle(10, 5);
            var rectArea = calc.TotalArea(rect);

            var trap = new Trapezoid(10, 5, 5);
            var trapArea = calc.TotalArea(trap);

            var same = rectArea == trapArea ? "Yep" : "Nope";

            Console.WriteLine($"Are rect and trap the same area? {same}");
        }
    }
}
