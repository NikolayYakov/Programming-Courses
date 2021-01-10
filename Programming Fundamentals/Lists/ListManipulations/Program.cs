using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();
            List<string> command = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        int addNumber = int.Parse(command[1]);
                        Add(list, addNumber);
                        break;
                    case "remove":
                        int removeNumber = int.Parse(command[1]);
                        Remove(list, removeNumber);
                        break;
                    case "removeat":
                        int removeAtindex = int.Parse(command[1]);
                        RemoveAt(list, removeAtindex);
                        break;
                    case "insert":
                        int insertNumber = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        Insert(list, insertNumber, index);
                        break;
                }
                command = Console.ReadLine()
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                          .ToList();
            }
            Console.WriteLine(string.Join(" ", list));
                                  
        }
        static void Add(List<int> list,int number)
        {
            list.Add(number);
        }

        static void Remove(List<int> list ,int number)
        {
            list.Remove(number);
        }

        static void RemoveAt(List<int> list,int index)
        {
            list.RemoveAt(index);
        }

        static void Insert(List<int> list,int number, int index)
        {
            list.Insert(index, number);
        }
    }
}
