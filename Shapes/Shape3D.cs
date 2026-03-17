using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape3D
    {
        public Shape BaseShape { get; set; }

        public Shape3D() { }
        public abstract double CalculateVolume();
    }
}
