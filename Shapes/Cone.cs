using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Cone : Shape3D
    {
        public double Height { get; set; }
        public Cone(Circle Circle, double height) : base(Circle) { this.Height = height; }
        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height / 3;
        }
    }
}
