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
            bool isChanged = false;
            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        int addNumber = int.Parse(command[1]);
                        Add(list, addNumber);
                        isChanged = true;
                        break;
                    case "remove":
                        int removeNumber = int.Parse(command[1]);
                        Remove(list, removeNumber);
                        isChanged = true;
                        break;
                    case "removeat":
                        int removeAtindex = int.Parse(command[1]);
                        RemoveAt(list, removeAtindex);
                        isChanged = true;
                        break;
                    case "insert":
                        int insertNumber = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        Insert(list, insertNumber, index);
                        isChanged = true;
                        break;
                    case "contains":
                        int containsNumber = int.Parse(command[1]);
                        Contain(list, containsNumber);
                        break;
                    case "printeven":
                        Even(list);
                        break;
                    case "printodd":
                        Odd(list);
                        break;
                    case "getsum":
                        Sum(list);
                        break;
                    case "filter":
                        int conditonNumeber = int.Parse(command[2]);
                        Filter(list, command[1], conditonNumeber);
                        break;
                }
                command = Console.ReadLine()
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                          .ToList();
            }
            if (isChanged == true)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
        static void Add(List<int> list, int number)
        {
            list.Add(number);
        }

        static void Remove(List<int> list, int number)
        {
            list.Remove(number);
        }

        static void RemoveAt(List<int> list, int index)
        {
            list.RemoveAt(index);
        }

        static void Insert(List<int> list, int number, int index)
        {
            list.Insert(index, number);
        }

        static void Contain(List<int> list,int number)
        {
            Console.WriteLine(list.Contains(number) ? "Yes" : "No such number"); 
        }

        static void Even(List<int> list)
        {
            List<int> even = list.Where(n => n%2==0)
                                 .ToList();
            Console.WriteLine(string.Join(" ", even));
        }
        
        static void Odd(List<int> list)
        {
            List<int> even = list.Where(n => n % 2 != 0)
                                 .ToList();
            Console.WriteLine(string.Join(" ", even));
        }

        static void Sum(List<int> list)
        {
            Console.WriteLine(list.Sum());
        }

        static void Filter(List<int> list,string conditon,int number)
        {
            List<int> conditionList = new List<int>();
            if (conditon == "<")
            {
                conditionList = list.Where(n => n < number)
                                .ToList();
                Console.WriteLine(String.Join(' ', conditionList));
            }
            else if (conditon == ">")
            {
                conditionList = list.Where(n => n > number)
                                .ToList();
                Console.WriteLine(String.Join(' ', conditionList));
            }
            else if (conditon == ">=")
            {
                conditionList = list.Where(n => n >= number)
                                .ToList();
                Console.WriteLine(String.Join(' ', conditionList));
            }
           else if (conditon == "<=")
            {
                conditionList = list.Where(n => n <= number)
                                .ToList();
                Console.WriteLine(String.Join(' ', conditionList));
            }

        }
    }
}
