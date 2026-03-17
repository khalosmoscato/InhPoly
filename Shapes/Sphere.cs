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
            Circle circle = (Circle)BaseShape; // casting the BaseShape to tell the compliter this is a Circle, therefore we get access to the property Radius
            return BaseShape.CalculateArea() * circle.Radius * (4d / 3d); // using d to casting 4 and 3 as type double for precision
        }
    }
}
