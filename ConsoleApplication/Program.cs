using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string location;

            Console.Write("What's your name? ");
            name = Console.ReadLine();

            Console.Write("Where are you from? ");
            location = Console.ReadLine();

            Console.WriteLine($"\nYour name is {name}.");
            Console.WriteLine($"You're from {location}.\n");

            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is {currentDate.ToLongDateString()}.");

            var nextChristmas = new DateTime(2021, 12, 25);
            Console.WriteLine($"Next Christmas is in {Math.Ceiling((nextChristmas - currentDate).TotalDays)} days.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("\nWhat is the width? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the height? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " + woodLength + " feet.");

            Console.WriteLine("The area of the glass is " + glassArea + " square metres.");

            Console.ReadKey();
        }
    }
}
