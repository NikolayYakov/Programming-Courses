using System;

namespace GreeterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    int result = GetMax(firstNumber, secondNumber);
                    Console.WriteLine(result);
                    break;
                case "char":
                    char firstSymbol = char.Parse(Console.ReadLine());
                    char secondSymbol = char.Parse(Console.ReadLine());
                    char finalSymbol = GetMax(firstSymbol, secondSymbol);
                    Console.WriteLine(finalSymbol);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string finalString = GetMax(firstString, secondString);
                    Console.WriteLine(finalString);
                    break;
            }
 
        }
         static int GetMax(int firstNumber,int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static char GetMax(char firstSymbol, char secondSymbol)
        {
            if (firstSymbol > secondSymbol)
            {
                return firstSymbol;
            }
            else
            {
                return secondSymbol;
            }
        }
        static string GetMax(string firstString,string secondString)
        {
            int comparesen = firstString.CompareTo(secondString);
            if (comparesen > 1)
            {
                return firstString;

            }
            else
            {
                return secondString;
            }
        }




    }
}
