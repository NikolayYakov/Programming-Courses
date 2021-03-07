using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKm, double tankCapacity)
            :base(fuelQuantity,litersPerKm,tankCapacity)
        {
            LitersPerKm += 0.9;
        }
        public override void Drive(double distance)
        {
            double driven = LitersPerKm * distance;
            if (FuelQuantity >= driven)
            {
                FuelQuantity -= driven;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }
        
        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                
            }
            double test = FuelQuantity + fuel;
            if (test <= TankCapacity&&fuel>0)
            {
                FuelQuantity += fuel;
            }
            else if (test > TankCapacity && fuel > 0)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            
        }
    }
}
