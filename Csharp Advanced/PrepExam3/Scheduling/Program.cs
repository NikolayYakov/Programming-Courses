using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] threads = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> tasksStack = new Stack<int>(tasks);
            Queue<int> threadsQueues = new Queue<int>(threads);
            int taskToKill = int.Parse(Console.ReadLine());
            while (true)
            {
                int task = tasksStack.Peek();
                int thread = threadsQueues.Peek();
                if (task == taskToKill)
                {
                    Console.WriteLine($"Thread with value {thread} killed task {taskToKill}");
                    Console.WriteLine(string.Join(" ", threadsQueues));
                    return;

                }
                if (thread >= task)
                {
                    tasksStack.Pop();
                    threadsQueues.Dequeue();
                }
                else
                {
                    threadsQueues.Dequeue();
                }
               
            }

        }
    }
}
