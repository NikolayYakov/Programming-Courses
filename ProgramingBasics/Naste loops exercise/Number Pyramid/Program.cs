using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            bool flag = false;
            int curentNumber = 0;
            for(int r = 1; r <= number; r++)
            {
                for(int col = 1; col <= r; col++)
                {
                    counter++;
                    if (counter > number)
                    {
                        flag = true;
                        break;
                    }
                    curentNumber++;
                    Console.Write($"{curentNumber} ");
                }
                if (flag == true)
                {
                    break;
                }
                Console.WriteLine("");
            }
        } 
    }
}
