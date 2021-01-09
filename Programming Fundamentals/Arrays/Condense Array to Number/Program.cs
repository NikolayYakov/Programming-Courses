using System;
using System.Linq;
namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
          

            while (arr.Length > 1)
            {
                 int[] condems = new int[arr.Length - 1];
                for (int i = 0; i < condems.Length; i++)
                {
                    condems[i] = arr[i] + arr[i + 1];


                }
                arr = condems;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
