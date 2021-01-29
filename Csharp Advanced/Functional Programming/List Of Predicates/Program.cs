using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] divide = Console.ReadLine()
                                  .Split(" ")
                                  .Select(int.Parse)
                                  .ToArray();
            List<int> numbers = Numbers(range, divide);
            Console.WriteLine(string.Join(" ", numbers));

        }
        static bool Check(int number,int[] dividers)
        {
            bool isTrue = true;
            for(int i = 0; i < dividers.Length; i++)
            {
                if (number % dividers[i] != 0)
                {
                    isTrue = false;
                    return isTrue;
                }
            }
            return isTrue;
        }
        static List<int> Numbers(int range,int[] divide)
        {
            List<int> numbers = new List<int>();
            for(int i = 1; i <= range; i++)
            {
               bool isTrue =  Check(i, divide);
               if(isTrue == true)
               {
                    numbers.Add(i);
               }
            }
            return numbers;
        }
    }
}
