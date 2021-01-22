using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for(int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split();
                string continent = command[0];
                string country = command[1];
                string city = command[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent,new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country,new List<string>());
                }
               
                continents[continent][country].Add(city);
                

            }
            foreach (var kindom in continents)
            {
                Console.WriteLine($"{kindom.Key}:");
                foreach (var item in kindom.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
