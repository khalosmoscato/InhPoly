using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Prism : Shape3D
    {
        public double Height { get; set; }
        public Prism(Triangle Triangle, double height) : base(Triangle) { this.Height = height; }
        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }
}
