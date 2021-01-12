using System;
using System.Linq;
namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] arr = text.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                int value = (int)arr[i];
                value += 3;
                arr[i] = (char)value;
            }
            Console.WriteLine(string.Join("", arr));
        }
    }
}
