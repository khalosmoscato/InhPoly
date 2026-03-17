using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public Motorcycle(string make, string model, Engine engineType, bool hasSideCar) : base(make, model, new MotorcycleEngine()) 
        {
            this.HasSidecar = hasSideCar;
        }
    }
}
