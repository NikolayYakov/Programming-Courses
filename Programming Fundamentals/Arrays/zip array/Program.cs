using System;
using System.Linq;
namespace zip_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbolsInArr = int.Parse(Console.ReadLine());
            int[] firstArr = new int[symbolsInArr];
            int[] secondArr = new int[symbolsInArr];
            string firstSentence = string.Empty;
            string secondSentence = string.Empty;
            for(int i = 0; i < symbolsInArr; i++)
            {
                string[] curentArr = Console.ReadLine()
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(Convert.ToString)
                                  .ToArray();
                string currentIndexZero = curentArr[0];
                string currentIndexOne = curentArr[1];
                if ((i-1) % 2 != 0)
                {
                    firstSentence += (currentIndexZero+" ");
                    secondSentence += (currentIndexOne + " ");
                }
                else
                {
                    firstSentence += (currentIndexOne + " ");
                    secondSentence += (currentIndexZero + " ");
                }
                
            }
            Console.WriteLine(firstSentence);
            Console.WriteLine(secondSentence);


        }
    }
}
