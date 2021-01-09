using System;
using System.Linq;
namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            int[] secondArray = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            int sum = 0;
            bool flag = false;
            for(int i = 0; i < firstArray.Length; i++)
            {
                if (i > secondArray.Length)
                {
                    break;
                }
                if (firstArray[i] == secondArray[i])
                {
                    sum += firstArray[i];
                }
                else
                {
                    Console.Write($"Arrays are not identical. Found difference at {i} index");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
