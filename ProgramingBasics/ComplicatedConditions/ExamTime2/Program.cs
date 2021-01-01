using System;

namespace ExamTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arivalHour = int.Parse(Console.ReadLine());
            int arivalMinutes = int.Parse(Console.ReadLine());
            string fullTimeExam = $"";
            string fullTimeArival = $"";
            double minutes = arivalMinutes - examMinutes;
            if (examMinutes < 59)
            {
                if (examMinutes >= 10)
                {
                    fullTimeExam = $"{examHour}:{examMinutes}";
                }
                else if (examMinutes < 10)
                {
                    fullTimeExam = $"{examHour}:0{examMinutes}";
                }
            }
            else
            {
                examHour += 1;
                examMinutes -= 60;
                if (examMinutes >= 10)
                {
                    fullTimeExam = $"{examHour}:{examMinutes}";
                }
                else if (examMinutes < 10)
                {
                    fullTimeExam = $"{examHour}:0{examMinutes}";
                }
            }
            if (arivalMinutes < 59)
            {
                if (arivalMinutes >= 10)
                {
                    fullTimeArival = $"{arivalHour}:{arivalMinutes}";
                }
                else if (arivalMinutes < 10)
                {
                    fullTimeArival = $"{arivalHour}:0{arivalMinutes}";
                }
            }
            else
            {
                arivalHour += 1;
                arivalMinutes -= 60;
                if (arivalMinutes >= 10)
                {
                    fullTimeArival = $"{arivalHour}:{arivalMinutes}";
                }
                else if (arivalMinutes < 10)
                {
                    fullTimeArival = $"{arivalHour}:0{arivalMinutes}";
                }
            }
            if (fullTimeArival == fullTimeExam)
            {
                Console.WriteLine("On time");
            }
            else if (examHour < arivalHour)
            {
                double hours = arivalHour - examHour;
                minutes = arivalMinutes - examMinutes;
                Math.Abs(minutes);

                if (minutes >= 10)
                {
                    Console.WriteLine($"Late");
                    Console.WriteLine($"{hours}:{minutes} hours after the start");
                }
                else
                {
                    Console.WriteLine($"Late");
                    Console.WriteLine($"{hours}:0{minutes} hours after the start");
                }
            }
            else if (examHour == arivalHour)
            {
                minutes = arivalMinutes - examMinutes;
                Math.Abs(minutes);
                if (examMinutes < arivalMinutes)
                {

                    Console.WriteLine($"Late");
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else if (minutes <= 30)
                {


                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {

                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutes} minutes before the start");
                }

            }
             else if (examHour > arivalHour)
            {
                double hour = examHour - arivalHour;
                minutes = examMinutes - arivalMinutes;
                Math.Abs(minutes);
                Console.WriteLine("Early");
                if (minutes >= 10)
                {
                    Console.WriteLine($"{hour}:{minutes} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{hour}:0{minutes} hours before the start");
                }
            }

        }
    }
}
