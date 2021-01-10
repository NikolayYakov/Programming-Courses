using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            Range(firstChar, secondChar);
        }
        static void Range(char firstChar,char secondChar)
        {
            if (firstChar < secondChar)
            {
                for (char i = firstChar; i < secondChar; i++)
                {
                    if (i != firstChar)
                    {
                        Console.Write(i + " ");
                    }

                }
            }
            else
            {
                for (char i = secondChar; i < firstChar; i++)
                {
                    if (i != secondChar)
                    {
                        Console.Write(i + " ");
                    }

                }
            }
        }
    }
}
