using System;

namespace LettersResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                char currentLetter = name[i];
                
                if (currentLetter == 'a')
                {
                    result += 1;
                }
                else if (currentLetter == 'e')
                {
                    result += 2;
                }
                else if (currentLetter == 'i')
                {
                    result += 3;
                }
                else if (currentLetter == 'o')
                {
                    result += 4;
                }
                else if (currentLetter == 'u')
                {
                    result += 5;
                }
            }
            Console.WriteLine(result);
        }
    }
}
