using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bonds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int lowerBond = bonds[0];
            int upperBond = bonds[1];
            string crit = Console.ReadLine();
            Predicate<int> fillter;
            switch (crit)
            {
                case "odd":
                    fillter = n => n % 2 != 0;
                    break;
                case "even":
                    fillter = n => n % 2 == 0;
                    break;
                default:
                    fillter = null;
                    break;
            }
            List<int> numbers = EvensOrOdds(lowerBond, upperBond, fillter);
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static List<int> EvensOrOdds(int lowerBound, int upperBound, Predicate<int> filter)
        {
            List<int> numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (filter(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers;


        }
    }
}
