using System;

namespace MiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MidChar(text);
        }
        static void MidChar(string text)
        {
            if (text.Length % 2 != 0)
            {
                int mid = text.Length/2;
                Console.WriteLine(text.Substring(mid, 1));
            }
            if (text.Length % 2 == 0)
            {
                int mid = text.Length / 2-1;
                Console.WriteLine(text.Substring(mid, 2));
            }
        }
    }
}
