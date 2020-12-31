using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool passwordCheck = password == "s3cr3t!P@ssw0rd";
            if (passwordCheck == true)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
