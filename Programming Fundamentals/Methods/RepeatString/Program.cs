using System;
using System.Text;
namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            string final =FinalText(text, repeat);
            Console.WriteLine(final);
        }
        static string FinalText(string text,int repeat)
        {
            StringBuilder finalText = new StringBuilder();
            for(int i = 1; i <= repeat; i++)
            {
                finalText.Append(text);
            }
            return finalText.ToString();
        }
    }
}
