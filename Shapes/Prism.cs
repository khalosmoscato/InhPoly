using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    internal class Prism : Shape3D
    {
        public double Height { get; set; }
        public Prism(double height, Triangle Triangle) : base(Triangle) { this.Height = height; }
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
