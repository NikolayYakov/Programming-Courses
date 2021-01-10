using System;
using System.Linq;
namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            while (number != "END")
            {
                string reversed = Arr(number);

                if (number == reversed)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                number = Console.ReadLine();
            }
        }
        static string Arr(string number)
        {
            char[] arr = number.ToCharArray();
            Array.Reverse(arr);



            return new String(arr);
        }
    }
}
