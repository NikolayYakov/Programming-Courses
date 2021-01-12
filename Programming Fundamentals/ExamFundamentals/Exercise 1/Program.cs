using System;
using System.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while(command[0]!= "Finish")
            {
                switch (command[0])
                {
                    case "Replace":
                        string ch = command[1];
                        string newCh = command[2];
                        text = Replace(text, ch, newCh);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        text = Cut(text, startIndex, endIndex);
                        break;
                    case "Make":
                        string lay = command[1];
                        text = Make(text, lay);
                        break;
                    case "Check":
                        string oldString = command[1];
                        Check(text, oldString);
                        break;
                    case "Sum":
                        startIndex = int.Parse(command[1]);
                        endIndex = int.Parse(command[2]);
                        Sum(text, startIndex, endIndex);
                        break;
                }
                command = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
        static string Replace(string text,string oldChar,string newChar)
        {
            text = text.Replace(oldChar, newChar);
            Console.WriteLine(text);
            return text;
        }
        static string Cut(string text,int startIdex,int endIndex)
        {
            if (startIdex < 0 || startIdex >= text.Length || endIndex < 0 || endIndex >= text.Length)
            {
                Console.WriteLine("Invalid indices!");
                return text;
            }
            else
            {
                int lenght = endIndex - startIdex + 1;
                text = text.Remove(startIdex, lenght);
                Console.WriteLine(text);
                return text;
            }
        }
        static string Make(string text,string command)
        {
            if (command == "Upper")
            {
                text = text.ToUpper();
                Console.WriteLine(text);
                return text;
            }
            else if (command == "Lower")
            {
                text = text.ToLower();
                Console.WriteLine(text);
                return text;
            }
            else
            {
                return text;
            }
        }
        static void Check(string text,string oldString)
        {
            if (text.Contains(oldString) == true)
            {
                Console.WriteLine($"Message contains {oldString}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {oldString}");
            }
        }
        static void Sum(string text,int startIndex,int endIndex)
        {
            if (startIndex < 0 || startIndex >= text.Length || endIndex < 0 || endIndex >= text.Length)
            {
                Console.WriteLine("Invalid indices!");
                
            }
            else
            {
                int lenght = endIndex - startIndex + 1;
                string substring = text.Substring(startIndex, lenght);
                char[] cha = substring.ToCharArray();
                int sum = 0;
                for(int i = 0; i < cha.Length; i++)
                {
                    sum += cha[i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
