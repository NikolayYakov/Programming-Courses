using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrWords = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random random = new Random();
            for(int i = 0; i < arrWords.Length; i++)
            {
                int index = random.Next(0, arrWords.Length);
                string word = arrWords[i];
                arrWords[i] =arrWords[index];
                arrWords[index] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine, arrWords));
        }
    }
}
