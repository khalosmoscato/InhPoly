using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Radius;
        }
    }
}
