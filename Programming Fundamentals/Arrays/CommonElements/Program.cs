using System;
using System.Linq;
namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(Convert.ToString)
                                .ToArray();
            string[] secondArr = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(Convert.ToString)
                                .ToArray();
            string finalSentence = string.Empty;
            for(int i = 0; i < secondArr.Length; i++)
            {
                for(int k = 0; k < firstArr.Length; k++)
                {
                    if (secondArr[i] == firstArr[k])
                    {
                        finalSentence += (firstArr[k]+ " ");
                        
                        break;
                    }
                }
            }
            Console.WriteLine(finalSentence);
        }
    }
}
