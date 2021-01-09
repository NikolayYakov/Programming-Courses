using System;
using System.Linq;
namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                       .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int rotates = int.Parse(Console.ReadLine());
            for(int i = 0; i <rotates ; i++)
            {
                string elementToRotate = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    string currentElement = arr[j];
                    arr[j - 1] = currentElement;
                }
                arr[arr.Length - 1] = elementToRotate;
            }
            Console.WriteLine(string.Join(' ', arr)) ;
        }
        
    }
}
