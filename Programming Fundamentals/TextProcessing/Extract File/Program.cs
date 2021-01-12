using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine()
                                   .Split("\\", StringSplitOptions.RemoveEmptyEntries);
            string last = file[file.Length - 1];
            string[] name = last.Split(".", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"File name: {name[0]}");
            Console.WriteLine($"File extension: {name[1]}");
        }
    }
}
