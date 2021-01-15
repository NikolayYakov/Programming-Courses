using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            string[] command = Console.ReadLine().ToLower().Split();
            Stack<int> numbersStack = new Stack<int>(numbers);
            
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);
                    numbersStack.Push(firstNumber);
                    numbersStack.Push(secondNumber);
                }
                else
                {
                    int count = int.Parse(command[1]);
                    if (count < numbersStack.Count) 
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbersStack.Pop();

                        }
                    }
                   
                }
                command = Console.ReadLine().ToLower().Split();
            }
            Console.WriteLine($"Sum: {numbersStack.Sum()}");
        }
    }
}
