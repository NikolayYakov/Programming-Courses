using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string[] info = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (info[0]!= "End")
            {
                string vehicle = info[1];
                string color = info[2];
                int hoursePower = int.Parse(info[3]);
                if (info[0] == "car")
                {
                    Car car = new Car(vehicle, color, hoursePower);
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(vehicle, color, hoursePower);
                    trucks.Add(truck);
                }
                info = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string model = Console.ReadLine();
            while(model!= "Close the Catalogue")
            {
                bool isCar = cars.Select(c => c.Model).Contains(model);
                if (isCar == true)
                {
                    int index =cars.FindIndex(x=>x.Model==model);
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {cars[index].Model}");
                    Console.WriteLine($"Color: {cars[index].Color}");
                    Console.WriteLine($"Horsepower: {cars[index].HorsePower}");
                }
                else
                {
                    int index = trucks.FindIndex(t => t.Model == model);
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {trucks[index].Model}");
                    Console.WriteLine($"Color: {trucks[index].Color}");
                    Console.WriteLine($"Horsepower: {trucks[index].HorsePower}");
                }
                model = Console.ReadLine();
            }
         
            
            if (cars.Count > 0)
            {
                double averageHorsePowerCar = cars.Average(c => c.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCar:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");

            }
            if (trucks.Count > 0)
            {
                double averageHorsePowerTruck = trucks.Average(t => t.HorsePower);
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerTruck:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
    class Car
    {
        public Car(string model,string color,int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
