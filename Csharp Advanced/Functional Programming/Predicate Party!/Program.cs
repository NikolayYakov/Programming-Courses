using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Queue<string> commands = new Queue<string>();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            while (command[0] != "Party!")
            {
                commands.Enqueue(string.Join(" ", command));
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            while(commands.Count>0)
            {
                string[] tocken = commands.Dequeue().Split();
                if (tocken[0] == "Remove")
                {
                    if (tocken[1] == "StartsWith")
                    {
                        people = people.Where(p => !p.StartsWith(tocken[2])).ToList();
                    }
                    else if (tocken[1] == "EndsWith")
                    {
                        people = people.Where(p => !p.EndsWith(tocken[2])).ToList();
                    }
                    else if (tocken[1] == "Length")
                    {
                        people = people.Where(p => p.Length != int.Parse(tocken[2])).ToList();
                    }
                }
                else if (tocken[0] == "Double")
                {
                    var predicate = GetPredicate(tocken[1], tocken[2]);
                    var matches = people.FindAll(predicate);
                    if (matches.Count > 0)
                    {
                        var index = people.FindIndex(predicate);
                        people.InsertRange(index, matches);
                    }
                }
            }
            if (people.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
           
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Predicate<string> GetPredicate(string command, string arg)
        {
            switch (command)
            {
                case "StartsWith":
                    return (name) => name.StartsWith(arg);
                case "EndsWith":
                    return (name) => name.EndsWith(arg);
                case "Length":
                    return (name) => name.Length == int.Parse(arg);
                default:
                    throw new ArgumentException("Invalid command type: " + command);
            }

        }
    
    }
}
