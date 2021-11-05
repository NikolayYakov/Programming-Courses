using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "abcasd";
            //PermuteWithoutRep(text,"");
            string[] arr = new string[] { "a", "b", "c" };
            Perm(arr, 0);

        }
        static void PermuteWithoutRep(string text, string result)
        {
            if (text.Length ==0)
            {
                Console.WriteLine (result);
            }
            else
            {
                for(int i = 0; i < text.Length; i++)
                { 
                    char element = text[i];
                    string left = text.Substring(0, i);
                    string right = text.Substring(i + 1);
                    string rest = left + right;
                    PermuteWithoutRep(rest, result + element); 
                }
            }
            
            
      
            

        }
        static void Perm(string[] arr, int k)
        {
            if (k >= arr.Length)
                Console.WriteLine(string.Join(" ",arr));
            else
            {
                Perm(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
            static void Swap(ref string  a,  ref string b)
            {
                string temp = a;
                a = b;
                b = temp;
            }
        }




    }
}
