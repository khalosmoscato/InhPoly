using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Cylinder : Shape3D
    {
        public double Height { get; set; }

        public Cylinder(double height, Circle Circle) : base(Circle) { this.Height = height; }

        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
        }
    }
}
