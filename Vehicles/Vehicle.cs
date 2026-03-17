using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public Vehicle(string make, string model, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Speed = speed;
        }
    }
}
