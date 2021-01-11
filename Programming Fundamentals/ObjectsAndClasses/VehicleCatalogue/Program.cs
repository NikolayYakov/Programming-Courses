using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collectin = new Collection();
            string[] command = Console.ReadLine()
                                      .Split("/", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
             
                if (command[0] == "Car")
                {
                    string brand = command[1];
                    string model = command[2];
                    int horsePower = int.Parse(command[3]);
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;
                    collectin.Cars.Add(car);
                    
                    
                }
                else
                {
                    string brand = command[1];
                    string model = command[2];
                    int weight = int.Parse(command[3]);
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;
                    collectin.Trucks.Add(truck);

                }

                command = Console.ReadLine()
                                  .Split("/", StringSplitOptions.RemoveEmptyEntries);
            }
            if (collectin.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in collectin.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (collectin.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in collectin.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Collection
    {
        public List<Car> Cars { get;}

        public List<Truck> Trucks { get; }
        public Collection()  
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    } 

}
