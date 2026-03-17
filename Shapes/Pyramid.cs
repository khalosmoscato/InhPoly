using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Pyramid : Shape3D
    {
        public double Height { get; set; }
        public Pyramid(double height, Triangle Triangle) : base(Triangle) { this.Height = height; }
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
