using System;

namespace Variations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "b", "c" };

        }
        static void Variation(string[] chosen,string[] arr,int index,string upperText,int r,int start,int end)
        {
             if(index == r)
            {
                for(int i = 0; i < r; i++)
                {
                    Console.WriteLine(arr[chosen[i]] + " ");
                }
            }

        }
    }
}
