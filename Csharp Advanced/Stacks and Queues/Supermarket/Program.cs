using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> people = new Queue<string>();
            while (command != "End")
            {
                if (command == "Paid")
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{people.Count()} people remaining.");
        }
    }
}
