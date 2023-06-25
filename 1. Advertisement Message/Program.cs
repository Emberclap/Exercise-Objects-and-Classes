using System;

namespace _1._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> phrases = new List<string>{"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."}
            .ToList();

            List<string> events = new List<string>{ "Now I feel good.", "I have succeeded with this product.", "Makes miracles. " +
                "I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" }
            .ToList();


            List<string> authors = new List<string>{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" }
            .ToList();

            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" }
            .ToList();

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                
                Console.WriteLine($"{phrases[Random.Shared.Next(0, phrases.Count)]}" +
                    $" {events[Random.Shared.Next(0, events.Count)]} {authors[Random.Shared.Next(0,authors.Count)]} - {cities[Random.Shared.Next(0,cities.Count)]}.");
            }
        }
    }
}