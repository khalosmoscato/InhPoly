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
        public void StartEngine()
        {
            EngineType.Start();
        }

        public void Drive()
        {
            // check if running 
            if (EngineType.Running)
            {
                Accelerate();
            }
            else
            {
                Console.WriteLine($"{Make} {Model} is not running.");
            }
        }

        protected abstract void Accelerate();
    }
}
