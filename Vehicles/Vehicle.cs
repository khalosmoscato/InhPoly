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
        public Engine EngineType { get; set; }

        public Vehicle(string make, string model, Engine engineType)
        {
            this.Make = make;
            this.Model = model;
            this.EngineType = engineType;
        }
    }
}
