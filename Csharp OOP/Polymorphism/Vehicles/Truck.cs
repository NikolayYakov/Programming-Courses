using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
           : base(fuelQuantity, litersPerKm,tankCapacity)
        {
            LitersPerKm += 1.6;
        }
        public override void Drive(double distance)
        {
            double driven = LitersPerKm * distance;
            if (FuelQuantity >= driven)
            {
                FuelQuantity -= driven;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
            double realFuel = fuel;
            fuel = fuel * 0.95;
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");

            }
            
            double test = FuelQuantity + fuel;
            if (test <= TankCapacity && fuel > 0)
            {
                FuelQuantity += fuel;
            }
            else if (test > TankCapacity && fuel > 0)
            {
                Console.WriteLine($"Cannot fit {realFuel} fuel in the tank");
            }
            
            
        }
    }
}
