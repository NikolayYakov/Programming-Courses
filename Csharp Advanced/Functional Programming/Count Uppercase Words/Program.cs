using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(n => char.IsUpper(n[0])).ToArray();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
