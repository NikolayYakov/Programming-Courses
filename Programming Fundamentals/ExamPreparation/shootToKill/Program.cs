using System;
using System.Linq;

namespace shootToKill
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            int shotTargets = 0;
            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                int index = int.Parse(command);
                if (index >= 0 && index < targets.Length && targets[index] != -1)
                {
                    shotTargets += 1;
                    
                    for(int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > targets[index] && targets[i] != -1&& i != index)
                        {
                            targets[i] -= targets[index];
                        }
                        else if (targets[i] <= targets[index] && targets[i] != -1 && i!=index)
                        {
                            targets[i] += targets[index];
                        }
                    }
                    targets[index] = -1;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}
