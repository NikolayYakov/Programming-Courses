using System;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 0;
            int j = 0;
            int[] arr = new int[] { 8, 6, 1, 9, 0, 3, 1 };
            for(int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
