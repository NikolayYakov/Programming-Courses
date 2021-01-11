using System;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of its category.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can’t live without this product.";
            string[] events = new string[6];
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles. I am happy of the results!";
            events[3] = "I cannot believe but now I feel awesome.";
            events[4] = "Try it yourself,I am very satisfied.";
            events[5] = "I feel great!";
            string[] names = new string[8];
            names[0] = "Diana";
            names[1] = "Petya";
            names[2] = "Stella";
            names[3] = "Elena";
            names[4] = "Katya";
            names[5] = "Iva";
            names[6] = "Annie";
            names[7] = "Eva";
            string[] cities = new string[5];
            cities[0] = "Burgas";
            cities[1] = "Sofia";
            cities[2] = "Plovdiv";
            cities[3] = "Varna";
            cities[4] = "Ruse";

            
            for(int i = 0; i < index; i++)
            {
                Random rnd = new Random();
                string phraseRnd = phrases[rnd.Next(0, phrases.Length)];
                string eventRnd = events[rnd.Next(0, events.Length)];
                string nameRnd = names[rnd.Next(0, names.Length)];
                string cityRnd = cities[rnd.Next(0, cities.Length)];
                Console.WriteLine($"{phraseRnd} {eventRnd} {nameRnd} - {cityRnd}");

            }


        }
    }
}
