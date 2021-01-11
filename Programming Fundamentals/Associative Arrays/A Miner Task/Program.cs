using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (command != "stop")
            {
                string resource = command;
                int value = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                {
                    resources[resource]+=value;
                }
                else
                {
                    resources.Add(resource, value);
                }
                command = Console.ReadLine();
            }
            foreach ( var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
