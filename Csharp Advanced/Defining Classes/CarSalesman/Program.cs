using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());
            Dictionary<string,Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();
            for(int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(parameters[0],int.Parse(parameters[1]));
                if(parameters.Length == 4)
                {
                     engine = new Engine(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2]), parameters[3]);
                }
                else if (parameters.Length == 3)
                {
                    int n;
                    bool isNumbeic = int.TryParse(parameters[2], out n);
                    if(isNumbeic == true)
                    {
                        engine = new Engine(parameters[0], int.Parse(parameters[1]), n);
                    }
                    else
                    {
                        engine = new Engine(parameters[0], int.Parse(parameters[1]), parameters[2]);
                    }
                }
                engines.Add(parameters[0],engine);
            }
            int carsCount = int.Parse(Console.ReadLine());
            for(int i = 0; i < carsCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(parameters[0], engines[parameters[1]]);
                if (parameters.Length == 4)
                {
                    car = new Car(parameters[0], engines[parameters[1]],int.Parse(parameters[2]),parameters[3]);
                }
                else if (parameters.Length == 3)
                {
                    int n;
                    bool isNumbeic = int.TryParse(parameters[2], out n);
                    if (isNumbeic == true)
                    {
                        car = new Car(parameters[0], engines[parameters[1]],n);
                    }
                    else
                    {
                        car = new Car(parameters[0], engines[parameters[1]],parameters[2]);
                    }
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($" {car.Engine.Model}:");
                Console.WriteLine($"  Power: {car.Engine.Power}");
                if (car.Engine.Displacement != -1)
                {
                    Console.WriteLine($"  Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"  Displacement: n/a");

                }
                if (car.Engine.Efficiency != string.Empty)
                {
                    Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"  Efficiency: n/a");

                }
                if (car.Weight != -1)
                {
                    Console.WriteLine($" Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($" Weight: n/a");

                }
                if (car.Color != string.Empty)
                {
                    Console.WriteLine($" Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($" Color: n/a");

                }

            }
        }
    }
}
