using System;
using System.Linq;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activateKey = Console.ReadLine();
            string[] command = Console.ReadLine()
                                     .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            while(command[0]!= "Generate")
            {
                switch (command[0])
                {
                    case "Contains":
                        string substring = command[1];
                        Contain(activateKey, substring);
                        break;
                    case "Flip":
                        string letterCase = command[1];
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        activateKey = LetterCase(activateKey, letterCase, startIndex, endIndex);
                        Console.WriteLine(activateKey);
                        break;
                    case "Slice":
                        int startIndexSlice = int.Parse(command[1]);
                        int endIndexSlice = int.Parse(command[2]);
                        activateKey = Slice(activateKey, startIndexSlice, endIndexSlice);
                        Console.WriteLine(activateKey);
                        break;
                }
                command = Console.ReadLine()
                                 .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your activation key is: {activateKey}");
        }
        static void Contain(string key,string substring)
        {
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
        static string LetterCase(string key,string letterCase,int startIndex,int endIndex)
        {
            int lenght = endIndex - startIndex;
            string substring = key.Substring(startIndex, lenght);
            string substringChange = string.Empty;
            if (letterCase == "Lower")
            {
                 substringChange = substring.ToLower();
            }
            else
            {
                substringChange = substring.ToUpper();
            }
            key = key.Replace(substring, substringChange);
            return key;
        }
        static string Slice(string key,int startIndex,int endIndex)
        {
            int lenght = endIndex - startIndex;
            key = key.Remove(startIndex, lenght);
            return key;
        }
    }
}
