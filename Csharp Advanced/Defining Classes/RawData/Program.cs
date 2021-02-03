using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for(int i = 0; i < n; i++)
            {
                string[] date = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = date[0];
                int speed = int.Parse(date[1]);
                int power = int.Parse(date[2]);
                int weight = int.Parse(date[3]);
                string type = date[4];
                Tire[] tires = new Tire[4] 
                {
                    new Tire(double.Parse(date[5]),int.Parse(date[6])),
                    new Tire(double.Parse(date[7]),int.Parse(date[8])),
                    new Tire(double.Parse(date[9]),int.Parse(date[10])),
                    new Tire(double.Parse(date[11]),int.Parse(date[12]))

                };
                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if(command == "fragile") 
            {
                cars = cars.Where(c => c.Cargo.Type == command).Where(c => c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                cars = cars.Where(c => c.Cargo.Type == command).Where(c => c.Engine.Power > 250).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
