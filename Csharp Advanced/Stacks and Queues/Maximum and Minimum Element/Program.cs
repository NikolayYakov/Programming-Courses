using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandNumbers = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for(int i = 0; i < commandNumbers; i++)
            {
                int[] command = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();
                switch (command[0])
                {
                    case 1:
                        int number = command[1];
                        numbers.Push(number);
                        break;
                    case 2:
                        if (numbers.Count == 0)
                        {
                            break;
                        }
                        numbers.Pop();
                        break;
                    case 3:
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                            break;
                        }
                        break;
                      
                    case 4:
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                            break;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }
    }
}
