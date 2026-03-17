using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string make, string model, Engine engineType) : base(make, model, new CarEngine()) { }
        
        public void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                FuelType.Unleaded => 1.5D,
                FuelType.Leaded => 1.2D,
                FuelType.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.HorsePower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2):F2}mph");
            }
        }
    }
}
