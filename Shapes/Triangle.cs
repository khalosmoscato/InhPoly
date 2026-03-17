using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double  baseLength, double height) { this.BaseLength =  baseLength; this.Height = height; }

        public override double CalculateArea()
        {
            return (BaseLength * Height) / 2;
        }
    }
}
