using System;
using System.Linq;

namespace Listyiterator
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


                }
                input = Console.ReadLine();
            }
        }
    }
}
