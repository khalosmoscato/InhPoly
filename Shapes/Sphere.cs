using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Sphere : Shape3D
    {
        public Sphere( Circle Circle) : base(Circle) { }
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
