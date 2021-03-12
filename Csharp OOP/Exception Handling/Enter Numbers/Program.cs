using System;

namespace Enter_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
         
            while (true)
            {
                int count = 0;
                try
                {
                   count =   ReadNumebrs(start, end);
                    if (count == 10)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                     
                }
                
            }
           
            
        }
        static int ReadNumebrs(int start,int end)
        {
            int count = 0;
            double previusNumber = 1;
            for(int i = 0; i < 10; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number<=start||number>=end||number<=previusNumber)
                {
                    count = 0;
                    throw new FormatException("Invalid Number");
                     

                }
                else
                {
                    count++;
                    previusNumber = number;
                }

            }
            return count;
            
        }
    }
}
