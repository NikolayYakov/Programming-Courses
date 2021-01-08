using System;

namespace vendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0.0;
            string product = string.Empty;
            var price = 0.0;

            while (command != "Start")
            {
                double money = double.Parse(command);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1.0 || money == 2.0)
                {
                    sum += money;

                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                command = Console.ReadLine();
            }

            while (product != "End")
            {
                product = Console.ReadLine();
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;

                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");


                        }
                        break;
                    case "Water":
                        price = 0.7;

                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");


                        }
                        break;
                    case "Crisps":
                        price = 1.5;

                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");


                        }
                        break;
                    case "Soda":
                        price = 0.8;

                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");


                        }
                        break;
                    case "Coke":
                        price = 1.0;

                        if (sum >= price)
                        {
                            sum -= price;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");


                        }
                        break;
                    case "End":
                        break;
                    default:
                        Console.WriteLine("Invalid product");

                        break;
                }

            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}

