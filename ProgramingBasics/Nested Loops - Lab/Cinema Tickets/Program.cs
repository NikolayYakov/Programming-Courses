using System;
using System.ComponentModel;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double spaces = 0.0;
            double allSpaces = 0.0;
            double studentTickets = 0.0;
            double standardTickets = 0.0;
            double kidTicets = 0.0;
            double allTickets = 0.0;
            double movieTickets = 0.0;
            bool flag = false;
            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }
                spaces = double.Parse(Console.ReadLine());
                allSpaces = spaces;
                while(spaces>0)
                {
                    string typeTicket = Console.ReadLine();
                    switch (typeTicket)
                    {
                        case "student":
                            studentTickets += 1;
                            movieTickets += 1;
                            allTickets += 1;
                            break;
                        case "standard":
                            standardTickets += 1;
                            movieTickets += 1;
                            allTickets += 1;
                            break;
                        case "kid":
                            kidTicets += 1;
                            movieTickets += 1;
                            allTickets += 1;
                            break;
                            
                        

                    }
                    if (typeTicket == "End")
                    {
                        break;
                    }
                    if (typeTicket == "Finish")
                    {
                        flag = true;
                        break;
                        
                    }
                    spaces--;
                }
                if (flag == true)
                {
                    break;
                }
                
                double spaceFill = movieTickets * 100 / allSpaces;
                Console.WriteLine($"{movie} - {spaceFill:f2}% full.");
                movieTickets = 0;
            }


            Console.WriteLine($"Total tickets: {allTickets}");
            double standardTicketPercent = standardTickets * 100.0 / allTickets;
            double studentTicketsPercent = studentTickets * 100.0 / allTickets;
            double kidTicketsPercent = kidTicets * 100.0 / allTickets;
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");

        }
    }
}
