using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> towns = new Dictionary<string, List<int>>();
            string[] town = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            while(town[0]!= "Sail")
            {
                string townName = town[0];
                int population = int.Parse(town[1]);
                int gold = int.Parse(town[2]);
                if (towns.ContainsKey(townName))
                {
                    towns[townName][0] += population;
                    towns[townName][1] += gold;
                }
                else
                {
                    towns.Add(townName, new List<int>());
                    towns[townName].Add(population);
                    towns[townName].Add(gold);
                }
                town = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
            }
            string[] command = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            while(command[0]!= "End")
            {
                string name = command[1];
                if(command[0]== "Plunder")
                {
                    int people = int.Parse(command[2]);
                    int gold = int.Parse(command[3]);
                    towns[name][0] -= people;
                    towns[name][1] -= gold;
                    Console.WriteLine($"{name} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (towns[name][0] <= 0 || towns[name][1] <= 0)
                    {
                        towns.Remove(name);
                        Console.WriteLine($"{name} has been wiped off the map!");
                    }
                    
                }
                if(command[0]== "Prosper")
                {
                    int gold = int.Parse(command[2]);
                    if (gold > 0)
                    {
                        towns[name][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {name} now has {towns[name][1]} gold.");

                    }
                    else
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                }
                command = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
            }
            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var item in towns.OrderByDescending(x=>x.Value[1]).ThenBy(X=>X.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
