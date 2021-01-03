using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            while (true)
            {
                string pass = Console.ReadLine();
                if(pass == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }

            }
        }
    }
}
