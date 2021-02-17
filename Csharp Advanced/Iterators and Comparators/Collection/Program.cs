using System;
using System.Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ListyIterator<string> iterator = null;
            while (input != "END")
            {

                var tokens = input.Split();

                switch (tokens[0])
                {
                    case "Create":
                        iterator = new ListyIterator<string>(tokens.Skip(1).ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "Print":
                        iterator.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "PrintAll":
                        foreach (var item in iterator)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;


                }
                input = Console.ReadLine();
            }
        }
    }
}
