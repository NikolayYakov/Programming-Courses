using System;

namespace Name_LETTERS
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            for (int i= 0; i< name.Length; i += 1)
            {
                char letter = name[i];
                Console.WriteLine(letter);
            }
        }
    }
}
