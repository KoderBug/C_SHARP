using System;

    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Please enter your favorite color of the rainbow: ");
        string color = Console.ReadLine();
        bool bestRainbowColor = color == "violet";

        do
        {
            switch (color)
            {
                case "red":
                    Console.WriteLine("Pretty color but not the best ;-)");
                    Console.WriteLine("Pick another color:");
                    color = Console.ReadLine();
                    break;
                case "orange":
                    Console.WriteLine("Great color if you're a piece of fruit ;-O");
                    Console.WriteLine("Pick another color:");
                    color = Console.ReadLine();
                    break;
                case "yellow":
                    Console.WriteLine("Beautiful color, Sunshine, still not the best :-S");
                    Console.WriteLine("Pick another color:");
                    color = Console.ReadLine();
                    break;
                case "green":
                    Console.WriteLine("Great color for grass, alas not the best one in the rainbow :-0");
                    Console.WriteLine("Pick another color:");
                    color = Console.ReadLine();
                    break;
                case "blue":
                    Console.WriteLine("No need to feel blue :-(");
                    Console.WriteLine("Pick another color:");
                    color = Console.ReadLine();
                    break;
                case "indigo":
                    Console.WriteLine("Just another shade of blue, snap out of it :-|");
                    Console.WriteLine("Pick another color.");
                    color = Console.ReadLine();
                    break;
                case "violet":
                    Console.WriteLine("Voila, that is the best color :-)");
                    bestRainbowColor = true;
                    break;
                default:
                    Console.WriteLine("Have you ever seen " + color + " in a rainbow?!?!?");
                    Console.WriteLine("Pick another color:");
                    color = Console.ReadLine();
                    break;
            }
        } while (!bestRainbowColor);
        Console.ReadLine();

        int number = 5;

        do
        {
            Console.WriteLine("Standby for Countdown... " + number);
            number = number + 5;
        } while (number <= 50);


        while (number != 0)
        {
            Console.WriteLine("Counting down..." + number);
            number = number - 1;
        }
        Console.WriteLine("Blast Off!!");
        Console.ReadLine();
        }
    }

