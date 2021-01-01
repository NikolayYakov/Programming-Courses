using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int daysInTheHotel = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceApartment = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = daysInTheHotel * 50.0;
                    priceApartment = daysInTheHotel * 65.00;
                    if (daysInTheHotel > 7)
                    {
                        if (daysInTheHotel <= 14)
                        {
                            priceStudio *= 0.95;
                        }
                    }
                    if (daysInTheHotel > 14) 
                    {
                        priceStudio *= 0.70;
                        priceApartment *= 0.90;
                    }
                    break;
                case "June":
                case "September":
                    priceApartment = 68.70 * daysInTheHotel;
                    priceStudio = 75.20 * daysInTheHotel;
                    if (daysInTheHotel > 14)
                    {
                        priceStudio *= 0.80;
                        priceApartment *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                    priceApartment = daysInTheHotel * 77.00;
                    priceStudio = daysInTheHotel * 76.00;
                    if (daysInTheHotel > 14)
                    {
                        priceApartment *= 0.90;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
