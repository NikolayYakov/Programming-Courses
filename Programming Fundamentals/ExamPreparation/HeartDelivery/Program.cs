using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                                  .Split("@", StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();
            string command = Console.ReadLine();
            int lastPosition = 0;
            while(command!= "Love!")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int length = int.Parse(token[1]);
                if (lastPosition + length < houses.Length)
                {
                    int index = lastPosition + length;
                    if (houses[index] == 0)
                    {
                        Console.WriteLine($"Place {index} already had Valentine's day.");
                    }
                    else
                    {
                        houses[index] -= 2;
                        if (houses[index] <= 0)
                        {
                            Console.WriteLine($"Place {index} has Valentine's day.");
                            houses[index] = 0;
                        }
                    }
                    lastPosition = index;
                }
                else
                {
                    lastPosition = 0;
                    if (houses[0] == 0)
                    {
                        Console.WriteLine($"Place 0 already had Valentine's day.");
                    }
                    else
                    {
                        houses[0] -= 2;
                        if (houses[0] <= 0)
                        {
                            Console.WriteLine($"Place 0 has Valentine's day.");
                            houses[0] = 0;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            int failedPlaces = 0;
            foreach (int place in houses)
            {
                if (place != 0)
                {
                    failedPlaces += 1;
                }
            }
            if (failedPlaces != 0)
            {
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
             

        }
    }
}
