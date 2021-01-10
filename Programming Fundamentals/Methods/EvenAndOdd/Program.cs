
using System;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
            string text = number.ToString();
            int[] arr = new int[text.Length];
             
           
             
                if (number < 0)
                {
                    arr = new int[text.Length - 1];
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    int result = number % 10;
                    result = Math.Abs(result);
                    arr[arr.Length - 1 - i] = result;
                    number /= 10;
                }
                int evenSum = EvenSum(arr);
                int oddSum = OddSum(arr);
                int multiplayed = evenSum * oddSum;
                Console.WriteLine(multiplayed);
             
        }
        static int EvenSum(int[] arr)
        {
            int evenSum = 0;
            for(int i = 0; i < arr.Length; i ++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] = Math.Abs(arr[i]);
                    evenSum += arr[i];
                }
            }
            return evenSum;
        }
        static int OddSum(int[] arr)
        {
            int oddSum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) 
                {
                    arr[i] = Math.Abs(arr[i]);

                    oddSum += arr[i];
                }
                
            }
            return oddSum;
        }
        
    }
}
