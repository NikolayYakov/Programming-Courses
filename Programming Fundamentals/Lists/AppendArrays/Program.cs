using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                                  .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                  .Where(s => !string.IsNullOrWhiteSpace(s))
                                  .ToList();
            string result = string.Empty;
            for(int i = arrays.Count-1; i>=0; i--)
            {
                List<string> everyArr = arrays[i]
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                  .ToList();

                result += string.Join(" ", everyArr)+" ";
            }

            Console.WriteLine(result);
             
        }
    }
}
