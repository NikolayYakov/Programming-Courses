using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            List<string> commands = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();
            while (commands[0].ToLower() != "end")
            {
                switch (commands[0].ToLower())
                {
                    case "add":
                        int number = int.Parse(commands[1]);
                        numbers.Add(number);
                        break;
                    case "insert":
                        int numberInsert = int.Parse(commands[1]);
                        int indexInsert = int.Parse(commands[2]);
                        if (indexInsert < numbers.Count && indexInsert>-1)
                        {
                            numbers.Insert(indexInsert, numberInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "remove":
                        int removeAtIndex = int.Parse(commands[1]);
                        if (removeAtIndex < numbers.Count && removeAtIndex>-1)
                        {
                            numbers.RemoveAt(removeAtIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "shift":
                        if (commands[1] == "left")
                        {
                            int countLeft = int.Parse(commands[2]);


                            ShiftLeft(numbers, countLeft);
                        }
                        else
                        {
                            int countRight = int.Parse(commands[2]);


                            ShiftRight(numbers, countRight);

                        }
                        break;
                }
                commands = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();
            }
            Console.WriteLine(string.Join(' ', numbers));

        }
        static void ShiftLeft(List<int> numbers,int count)
        {
            for(int i = 0; i <count; i++)
            {
                int firstNumber = numbers[0];
                numbers.Add(firstNumber);
                numbers.RemoveAt(0);
            }
            
        }
        static void ShiftRight(List<int> numbers,int count)
        {
            for(int i = 0; i < count; i++)
            {
                int lastNumebr = numbers[numbers.Count - 1];
                numbers.Insert(0, lastNumebr);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}
