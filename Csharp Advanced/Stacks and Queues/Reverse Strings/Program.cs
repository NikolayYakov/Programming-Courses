using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedString = new Stack<char>();
            for(int i = 0; i < input.Length; i++)
            {
                reversedString.Push(input[i]);

            }
            Console.WriteLine(string.Join("", reversedString.ToArray()));
        }
    }
}
