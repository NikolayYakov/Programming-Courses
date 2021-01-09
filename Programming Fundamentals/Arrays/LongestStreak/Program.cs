using System;

namespace LongestStreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int bestIndex = 0;
            int bestCount = 0;
            for (int i=0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                int currentCounter = 1;
                
                for (int k = i + 1; k < arr.Length; k++)
                {
                    
                    if (currentElement == arr[k])
                    {
                        currentCounter++;
                        
                    }
                    else
                    {
                        break;
                    }
                    i = k; 
                }
                if (currentCounter > bestCount)
                {
                    bestIndex = i;
                    bestCount=currentCounter;
                }
                 
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
