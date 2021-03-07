using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity)
           : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            LitersPerKm += 1.4;
        }
        public override void Drive(double distance)
        {
            double driven = LitersPerKm * distance;
            if (FuelQuantity >= driven)
            {
                FuelQuantity -= driven;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
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
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
        }
        public  void EmtyDriving(double distance)
        {
            LitersPerKm -= 1.4;
            double driven = LitersPerKm * distance;
            if (FuelQuantity >= driven)
            {
                FuelQuantity -= driven;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
            LitersPerKm += 1.4;
        }
    }
}
