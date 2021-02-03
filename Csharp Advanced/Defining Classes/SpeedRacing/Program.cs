using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                bool isContained = false;
                string[] date = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = date[0];
                double fuel = double.Parse(date[1]);
                double consumtion = double.Parse(date[2]);
                if (cars.Count > 0)
                {
                    foreach (var item in cars)
                    {
                        if (item.Model == model)
                        {
                            isContained = true;
                        }
                    }
                }
                Car car = new Car(model, fuel, consumtion);
                if (isContained == false)
                {
                    cars.Add(car);
                }
                
            }
            string[] commmand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (commmand[0] != "End")
            {
                foreach (var car in cars)
                {
                    if (car.Model == commmand[1])
                    {
                        car.Drive(double.Parse(commmand[2]));
                    }
                }
                commmand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
