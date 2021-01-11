using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int people = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>(people);
            for(int i = 0; i < people; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = command[1];
                
                switch (command[0])
                {
                    case "register":
                        string plate = command[2];
                        Registered(parking, name, plate);
                        break;
                    case "unregister":
                        Unregistered(parking, name);
                        break;
                }
            }
            foreach (var person in parking)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }
        static void Registered(Dictionary<string,string> parking,string name,string plate)
        {
            if (parking.ContainsKey(name))
            {
                Console.WriteLine($"ERROR: already registered with plate number {parking[name]}");
            }
            else
            {
                parking.Add(name, plate);
                Console.WriteLine($"{name} registered {plate} successfully");
            }
        }

        static void Unregistered(Dictionary<string,string> parking,string name)
        {
            if (parking.ContainsKey(name))
            {
                parking.Remove(name);
                Console.WriteLine($"{name} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {name} not found");
            }
        }
    }
}
