using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Engine
    {
        public bool Running { get; set; }
        public int HorsePower { get; set; }
        public FuelType FuelType { get; set; }
        protected Engine(int horsepower, FuelType fuelType)
        {
            this.HorsePower = horsepower;
            this.FuelType = fuelType;
            this.Running = false;
        }

        public void Start()
        {
            Running = true;
        }
    }
}
