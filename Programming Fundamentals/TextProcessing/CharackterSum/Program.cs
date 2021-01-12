using System;
using System.Linq;

namespace CharackterSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int value = Multiplied(words[0], words[1]);
            Console.WriteLine(value);
        }
        static int Multiplied(string firstString,string secondString)
        {
            char[] firstStringChars = firstString.ToCharArray();
            char[] secondStringChars = secondString.ToCharArray();
            int value = 0; ;
            for(int i = 0; i < Math.Max(firstStringChars.Length, secondStringChars.Length); i++)
            {
                int first = 0;
                int second = 0;
                if (i < Math.Min(firstStringChars.Length, secondStringChars.Length))
                {
                    first = firstStringChars[i];
                    second = secondStringChars[i];
                    first *= second;
                    value += first;
                }
                if (i >= firstStringChars.Length)
                {
                    second = secondStringChars[i];
                    value += second;
                }
                if (i >= secondStringChars.Length)
                {
                    first = firstStringChars[i];
                    value += first;
                }
                
            }
            return value;

        }
    }
}
