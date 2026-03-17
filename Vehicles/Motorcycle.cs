using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }
        public Motorcycle(string make, string model, int speed, bool hasSidecar) : base(make, model, speed) 
        {
            this.HasSidecar = hasSidecar;
        }
    }
}
