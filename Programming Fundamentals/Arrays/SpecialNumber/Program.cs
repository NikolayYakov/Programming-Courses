using System;
using System.Linq;
namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            int sum = int.Parse(Console.ReadLine());


            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {

                    bool check = arr[i] + arr[k] == sum;
                    if (check == true)
                    {
                        Console.WriteLine($"{arr[i]} {arr[k]}");
                    }
                }
            }
        }
    }
}
