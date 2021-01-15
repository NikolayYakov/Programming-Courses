using System;
using System.Collections.Generic;

namespace TraficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> traffic = new Queue<string>();
            int count = 0;
            while(command!= "end")
            {
                if (command == "green")
                {
                    for(int i = 0; i < number; i++)
                    {
                        if (traffic.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{traffic.Dequeue()} passed!");
                        count++;
                        
                    }
                }
                else
                {
                    traffic.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
