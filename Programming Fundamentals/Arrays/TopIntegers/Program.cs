using System;
using System.Linq;
namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();


            string topInteger = string.Empty;
            for(int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int k =arr.Length-1;k>i;k--)
                {
                    if (arr[i] > arr[k])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    if (counter==arr.Length-i-1)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    
                  
                  
                }
                if (i == arr.Length-1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
             
        }
    }
}
