using System;
using System.Linq;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "END")
            {
                switch (commands[0])
                {
                    case "Push":
                       int[] elements = commands.Skip(1)
                      .Select(i => i.Split(',').First())
                      .Select(int.Parse)
                      .ToArray();
                        stack.Push(elements);
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                }
                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
