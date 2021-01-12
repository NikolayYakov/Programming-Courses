using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            string[] command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0].ToLower() != "end")
            {
                int index = int.Parse(command[1]);
                int value = int.Parse(command[2]);
                switch (command[0].ToLower())
                {
                    case "shoot":
                        Shoot(targets, index, value);
                        break;
                    case "add":
                        Add(targets, index, value);
                        break;
                    case "strike":
                        Strike(targets, index, value);
                        break;
                }
                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join("|", targets));

        }
        static void Shoot(List<int> targets,int index,int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;
                if (targets[index]<=0)
                {
                    targets.RemoveAt(index);
                }
            }
        }

        static void Add(List<int> targets,int index,int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Strike(List<int> targets,int index,int radius)
        {
            if (index - radius >= 0 && index + radius < targets.Count)
            {
                targets.RemoveRange(index - radius,2*radius+1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
           
        }
    }
}
