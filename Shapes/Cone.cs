using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Cone : Shape3D
    {
        public double Height { get; set; }
        public Cone(double height, Circle Circle) : base(Circle) { this.Height = height; }
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
