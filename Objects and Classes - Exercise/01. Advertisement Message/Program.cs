using System;

namespace Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[6]{"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."};
            string[] events = new string[6] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[8] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[5] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rPharases = new Random();
            Random rEvents = new Random();
            Random rAuthors = new Random();
            Random rCities = new Random();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrases[rPharases.Next(0,phrases.Length)]} {events[rEvents.Next(0, events.Length)]} {authors[rAuthors.Next(0, authors.Length)]} – {cities[rCities.Next(0, cities.Length)]}.");
            }
        }
    }
}