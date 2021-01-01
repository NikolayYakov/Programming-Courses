using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double commission = 0.0;
            if (amount < 0)
            {
                Console.WriteLine("error");
            }
            else if (amount >= 0)
            {
                if(amount <= 500)
                {
                    switch (city)
                    {
                        case "Sofia":
                            commission = amount * 5 / 100;
                            break;
                        case "Varna":
                            commission = amount * 4.5 / 100;
                            break;
                        case "Plovdiv":
                            commission = amount * 5.5 / 100;
                            break;
                        default:
                            Console.WriteLine("error");
                                break;

                    }
                }
                else if (amount > 500)
                {
                    if (amount <= 1000)
                    {
                        switch (city) 
                        {
                            case "Sofia":
                            commission = amount * 7 / 100;
                                break;
                            case "Varna":
                                commission = amount * 7.5 / 100;
                                break;
                            case "Plovdiv":
                            commission = amount * 8 / 100;
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }

                    }
                     
                }
                 if (amount > 1000)
                {
                    if (amount <= 10000)
                    {
                        switch (city)
                        {
                            case "Sofia":
                                commission = amount * 8 / 100;
                                break;
                            case "Varna":
                                commission = amount * 10 / 100;
                                break;
                            case "Plovdiv":
                                commission = amount * 12 / 100;
                                break;
                            default:
                                Console.WriteLine("error");
                                break;
                        }
                    }
                }
                 if (amount > 10000)
                {
                    switch (city)
                    {
                        case "Sofia":
                            commission = amount * 12 / 100;
                            break;
                        case "Varna":
                            commission = amount * 13 / 100;
                            break;
                        case "Plovdiv":
                            commission = amount * 14.5 / 100;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                }
            }
            if (commission != 0)
            {
                Console.WriteLine($"{commission:f2}");
            }
        }
    }
}
