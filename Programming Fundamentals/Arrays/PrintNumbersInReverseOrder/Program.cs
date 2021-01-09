using System;
using System.Linq;
namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumbers = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[amountOfNumbers];
            for (int i = 0; i < amountOfNumbers; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }
             
            Console.WriteLine(string.Join(' ',arrNumbers.Reverse()));
        }
    }
}
