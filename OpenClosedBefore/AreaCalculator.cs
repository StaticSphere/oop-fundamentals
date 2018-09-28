using System;

namespace OpenClosedBefore
{
    public class AreaCalculator
    {
        public decimal TotalArea(object[] shapes)
        {
            var area = 0M;

            // What happens if we add additional shapes?  Or we need to change
            // how a shapes area is calculated (contrived, yes, but just
            // pretend...).  We will need to make continuous changes to this code
            // when we add or remove shapes, or if we have to alter how any shapes
            // calculation needs to be changed.
            //
            // This is NOT open for extension, because I need to alter the existing code,
            // rather than extending it, if I need to add a shape.  It is also NOT closed
            // for modification, because I also have to modify this code if the area
            // calculation needs to be changed.
            foreach(var shape in shapes)
            {
                if (shape is Square s)
                {
                    area += s.Height * s.Height;
                }
                else if (shape is Circle c)
                {
                    area += (decimal)Math.PI * c.Radius * c.Radius;
                }
                else if (shape is Triangle t)
                {
                    area += t.Width * t.Height * 0.5M;
                }
            }

            return area;
        }
    }
}
