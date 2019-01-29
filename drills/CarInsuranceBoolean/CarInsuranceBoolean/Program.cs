using System;

    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("What is your age? ");
        string age = Console.ReadLine();

        Console.WriteLine("Have you ever had a DUI? ");
        string DUI = Console.ReadLine();

        Console.WriteLine("How many speeding tickets do you have? ");
        string speedTix = Console.ReadLine();

        bool isQualified = ((Convert.ToInt32(age)) > 15) && (DUI.ToUpper() == "NO" || DUI.ToUpper() == "FALSE") && (Convert.ToInt32(speedTix) <= 3);
        Console.WriteLine("Qualified? ");
        Console.WriteLine(isQualified.ToString());
        Console.ReadLine();
    }
    }
