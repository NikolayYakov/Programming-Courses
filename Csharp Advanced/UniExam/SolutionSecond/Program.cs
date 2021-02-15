using System;

namespace SolutionSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string text = string.Empty;
            while (line != string.Empty)
            {
                text += line + " ";
                line = Console.ReadLine();
            }
            text = text.Trim();
            int count = CountWords(text);
            Console.WriteLine($"Това е броя на думите {count}");
            int numberCount = CountDigits(text);
            Console.WriteLine($"Това е броя на цифрите {numberCount}");
            LettersHistogram(text);

        }
        static int CountWords(string text)
        {
            int count = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    while (char.IsLetter(text[i]))
                    {
                        i++;
                        if (i >= text.Length)
                        {
                            break;
                        }
                    }
                    count++;
                }
               
            }
            return count;
        }
        static int CountDigits(string text)
        {
            int Numbercount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    while (char.IsDigit(text[i]))
                    {
                        i++;
                        if (i >= text.Length)
                        {
                            break;
                        }
                    }
                    i--;
                    Numbercount++;
                }
                
            }
            return Numbercount;
        }
        static void LettersHistogram(string text)
        {
            int[] count = new int[26];
            for(int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    char symbol = char.ToLower(text[i]);
                    count[symbol - 'a']++;
                }
               
            }
            for(int i = 0;i < count.Length; i++)
            {
                Console.WriteLine($"Броя на буквата {(char)('a' + i)} се среща {count[i]}");
            }
        }
    }
}
