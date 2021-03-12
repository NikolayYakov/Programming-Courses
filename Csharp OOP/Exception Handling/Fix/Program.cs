using System;

namespace Fix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[5];
            week[0] = "1";
            week[1] = "2";
            week[2] = "2";
            week[3] = "4";
            week[4] = "5";
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(week[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
