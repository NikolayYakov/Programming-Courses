using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            var counter = 0;
            for (int i =username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }
            while (true)
            {
                var fillPassword = Console.ReadLine();
                if (fillPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
            }
        }
    }
}
