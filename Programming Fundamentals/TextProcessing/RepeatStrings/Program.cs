using System;
using System.Text;
namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder combinerd = new StringBuilder();
            foreach (var word in words)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    combinerd.Append(word);
                }
            }
            Console.WriteLine(combinerd);
        }
    }
}
