using System;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(n=>n%2==0).OrderBy(n=>n).ToArray();
            Console.WriteLine(string.Join(", ", number));
        }
    }
}
