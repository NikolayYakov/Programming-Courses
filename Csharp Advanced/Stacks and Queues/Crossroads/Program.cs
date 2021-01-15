using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int originalGreenDuration = greenDuration;
            int freeWindow = int.Parse(Console.ReadLine());
            int originalFreeWindow = freeWindow;
            int count = 0;
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            string lastCar = string.Empty;
            bool crash = false;
            while (command != "END")
            {
                if (command == "green")
                {
                    Queue<string> carsInCrossRoad = new Queue<string>();
                    string car = string.Empty;
                    while (cars.Count>0)
                    {
                        car = cars.Dequeue();
                        lastCar = car;
                        int lenght = greenDuration-car.Length;
                        if (lenght < 0)
                        {
                            car = car.Substring(greenDuration);
                            carsInCrossRoad.Enqueue(car);
                            break;
                             
                        }
                        else
                        {
                            greenDuration -= car.Length;
                            count++;
                            if (greenDuration == 0)
                            {
                                break;
                            }
                        }
                        
                    }
                    while (carsInCrossRoad.Count > 0)
                    {
                        car = carsInCrossRoad.Dequeue();
                        int lenght = freeWindow - car.Length;
                        if (lenght < 0)
                        {
                            string crahed = car[car.Length  + lenght].ToString();
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{lastCar} was hit at {crahed}.");
                            crash = true;
                            return;
                        }
                        else
                        {
                            freeWindow -= car.Length;
                            count++;
                            if (freeWindow == 0)
                            {
                                break;
                            }
                        }
                    }
                   
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
                greenDuration = originalGreenDuration;
                freeWindow = originalFreeWindow;
                
            }
            if (crash == false)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }
        }
    }
}
