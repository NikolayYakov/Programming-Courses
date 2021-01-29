using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers =numbers.Select(n=>n+1).ToArray();
                        break;
                    case "multiply":
                        numbers =numbers.Select(n => n * 7).ToArray();
                        break;
                    case "subtract":
                        numbers = numbers.Select(n => n - 1).ToArray();
                        break;
                    case "print":
                        Print(numbers);
                        break;

                }
                command = Console.ReadLine();
            }
           
        }
        static void Print(int[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
