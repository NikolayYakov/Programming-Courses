using System;

namespace TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfLetters; i++)
            {
                for (int k = 0; k < numberOfLetters; k++)
                {
                    for (int p= 0; p < numberOfLetters; p++)
                    {
                        char firstLetter = (char)('a' + i);
                        char secondLetter = (char)('a' + k);
                        char finalLetter = (char)('a' + p);
                        Console.WriteLine($"{firstLetter}{secondLetter}{finalLetter}");
                    }
                }
            }
        }
    }
}
