using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedOrNOT
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stacked = new Stack<char>();
            bool isBalanced = true;
            for(int i =0;i<input.Length;i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stacked.Push(input[i]);
                }
                else
                {
                    if (!stacked.Any())
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");
                        break;
                    }
                    char current = stacked.Pop();
                    bool isRound = current == '(' && input[i] == ')';
                    bool isRound2 = current == '[' && input[i] == ']';
                    bool isRound3 = current == '{' && input[i] == '}';
                    if (isRound == false && isRound2 == false && isRound3 == false)
                    {
                        Console.WriteLine("No");
                        isBalanced = false;
                        break;
                    }

                }
            }
             
            if (isBalanced == true)
            {
                Console.WriteLine("YES");
            }
 
        }
    }
}
