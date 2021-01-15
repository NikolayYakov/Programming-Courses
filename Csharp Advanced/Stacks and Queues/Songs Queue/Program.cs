using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> musicPlayer = new Queue<string>(songs);
            string command = Console.ReadLine();
            while (musicPlayer.Count > 0)
            {
                if (command == "Play")
                {
                    musicPlayer.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", musicPlayer.ToArray()));
                }
                else
                {
                    string song = command.Substring(4);
                    if (!musicPlayer.Contains(song))
                    {
                        musicPlayer.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
