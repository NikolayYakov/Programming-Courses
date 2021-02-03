using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public Car(string model,double fuelAmount,double consumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = consumption;
            TravelledDistance = 0;
        }
        public void Drive(double distance)
        {
            double range = distance * FuelConsumptionPerKilometer;
            if (range > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= range;
                TravelledDistance += distance;
            }
        }
    }
}
