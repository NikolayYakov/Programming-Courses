using System;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string[] command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Done")
            {
                switch (command[0])
                {
                    case "Cut":
                        int index = int.Parse(command[1]);
                        int lenght = int.Parse(command[2]);
                        password = Cut(password, index, lenght);
                        break;
                    case "TakeOdd":
                        password = TakeOdd(password);
                        break;
                    case "Substitute":
                        string substring = command[1];
                        string substitute = command[2];
                        password = Replace(password, substring, substitute);
                        break;
                }
                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your password is: {password}");

        }
        static string Cut(string password,int index,int lenght)
        {
            password = password.Remove(index, lenght);
            Console.WriteLine(password);
            return password;
        }
        static string TakeOdd(string password)
        {
            string newPassword = string.Empty;
            for(int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPassword += password[i];

                }
              
            }
            password = newPassword;
            Console.WriteLine(password);
            return password;
        }
        static string Replace(string password,string substring,string substitute)
        {
            if (password.Contains(substring))
            {
               password = password.Replace(substring, substitute);
               Console.WriteLine(password);
                return password;
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
                return password;
            }
        }
    }
}
