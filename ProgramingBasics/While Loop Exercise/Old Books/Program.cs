using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoBook = Console.ReadLine();
            int count = 0;
            while (true)
            {
                string book = Console.ReadLine();
                count += 1;
                if (book == "No More Books")
                {
                    count -= 1;
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                }
                else if(book == favoBook)
                {
                    count -= 1;
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
            }
        }
    }
}
