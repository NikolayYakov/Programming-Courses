using System;
using System.Collections.Generic;
using System.Linq;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> problem = new Stack<string>(input.Reverse());
             
            while (problem.Count>1)
            {
                int result = int.Parse(problem.Pop());
                string sign = problem.Pop();
                if (sign == "-")
                {
                    result -= int.Parse(problem.Pop());
                }
                else
                {
                    result += int.Parse(problem.Pop());
                }
                problem.Push(result.ToString());
            }
            int finaleResult = int.Parse(problem.Pop());
            Console.WriteLine(finaleResult);
           
        }
    }
}
