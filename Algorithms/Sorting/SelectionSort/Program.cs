using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 6, 1, 9, 0, 3, 1 };
            for(int i = 0; i < arr.Length; i++)
            {
                int minIndx = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndx])
                    {
                        minIndx = j;
                    }
                }
                int value = arr[i];
                arr[i] = arr[minIndx];
                arr[minIndx] = value;
                
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
