using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            List<string> command = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToList();
            while (command[0].ToLower() != "end")
            {
                if(command[0].ToLower() == "delete")
                {
                    int numberDelete = int.Parse(command[1]);
                    Delete(numbers, numberDelete);
                }
                else if (command[0].ToLower() == "insert")
                {
                    int numberInsert = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    Insert(numbers, numberInsert, index);
                }
                command = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void Delete(List<int> numbers,int numberDelete)
        {
            numbers.RemoveAll(n => n == numberDelete);
        }
        static void Insert(List<int> numbers,int numberInsert,int index)
        {
            numbers.Insert(index, numberInsert);
        }
    }
}
