using System;
using System.Linq;
namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] reveredString = Console.ReadLine()
                                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(Convert.ToString)
                                     .ToArray();
            Console.WriteLine(string.Join(' ', reveredString.Reverse()));
                                     
        }
    }
}
