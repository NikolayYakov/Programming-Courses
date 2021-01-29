using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SumAndCount(int.Parse, a => a.Length, a => a.Sum());
        }
        static void SumAndCount(Func<string,int> parser,Func<int[],int> count,Func<int[],int> sum)
        {
            int[] array = Console.ReadLine()
                                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(parser)
                                 .ToArray();
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }
    }
}
