using System;
using System.Dynamic;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheets = int.Parse(Console.ReadLine());
            double sheetsPerDay = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double hoursNeeded = sheets / sheetsPerDay;
            double hoursADayNeeded = hoursNeeded / days;
            Console.WriteLine(hoursADayNeeded);
        }
    }
}
