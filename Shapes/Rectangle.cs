using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width) { this.Length = length; this.Width = width; }
        public override double CalculateArea()
        {
       
            return Length * Width;
        }
    }
}
