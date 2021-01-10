using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToList();
            int capacity = int.Parse(Console.ReadLine());
            List<string> command = Console.ReadLine()
                                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();
            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() == "add")
                {
                    int people = int.Parse(command[1]);
                    wagons.Add(people);
                }
                else
                {
                    int peopleForWagons = int.Parse(command[0]);
                    AddPeople(wagons, peopleForWagons, capacity);
                }
                command = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
            }
            Console.WriteLine(string.Join(" ", wagons));
                                   
        }
        static void  AddPeople(List<int> wagons,int people,int capacity)
        {
            for(int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + people <= capacity)
                {
                    wagons[i] += people;
                    break;
                }
            }
        }
    }
}
