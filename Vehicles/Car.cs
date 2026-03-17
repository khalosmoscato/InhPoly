using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string make, string model, Engine engineType) : base(make, model, new CarEngine()) { } 
    }
}
