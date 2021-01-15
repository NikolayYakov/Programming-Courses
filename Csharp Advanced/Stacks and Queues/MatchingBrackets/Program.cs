using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = Console.ReadLine();
            Stack<int> parts = new Stack<int>();
            for(int i = 0; i < problem.Length; i++)
            {
                if (problem[i] == '(')
                {
                    
                    parts.Push(i);
                }
                if (problem[i] == ')')
                {
                     
                    int startIndex = parts.Pop();
                    string part = problem.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(part);
                }
            }
        }
    }
}
