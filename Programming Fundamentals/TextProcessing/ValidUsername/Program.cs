using System;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var username in usernames)
            {
                bool isValid = false;
                char[] symbols = username.ToCharArray();
                foreach (var symbol in symbols)
                {
                    if (username.Length >= 3 && username.Length <= 16)
                    {
                        if (char.IsDigit(symbol))
                        {
                            isValid = true;
                        }
                        else if (char.IsLetter(symbol))
                        {
                            isValid = true;
                        }
                        else if (symbol == '-')
                        {
                            isValid = true;
                        }
                        else if (symbol == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    
                }
                if (isValid == true)
                {
                    Console.WriteLine(username);
                }

            }
        }
    }
}
