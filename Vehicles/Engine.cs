using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal abstract class Engine
    {
        public bool Running { get; set; }
        public int Horsepower { get; set; }
        public FuelType FuelType { get; set; }
        public Engine(int horsepower, FuelType fuelType)
        {
            this.Horsepower = horsepower;
            this.FuelType = fuelType;
        }
    }
}
