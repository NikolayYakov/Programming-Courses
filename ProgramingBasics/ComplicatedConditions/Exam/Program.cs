using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arivalHour = int.Parse(Console.ReadLine());
            int arivalMinutes = int.Parse(Console.ReadLine());
            int difference = 0;
            int minutes = 0;
            int hour = 0;
            examMinutes += examHour * 60;
            arivalMinutes += arivalHour * 60;
            if (arivalMinutes > examMinutes)
            {
                Console.WriteLine("late");
                difference = arivalMinutes - examMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arivalMinutes < examMinutes-30)
            {
                Console.WriteLine("early");
                difference = examMinutes - arivalMinutes;
                if (difference<60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.Write("on time");
                difference = examMinutes - arivalMinutes;
                if (difference > 0)
                {
                    Console.Write($" {difference} minutes before the start");
                }

            }
        }
    }
}
