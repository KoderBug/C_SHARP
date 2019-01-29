using System;

    class Program
    {
        static void Main(string[] args)
        {
        int total = 5 + 10;
        int otherTotal = 12 + 22;
        int combined = total + otherTotal;
        Console.WriteLine("Five plus Ten = " + total.ToString());
        Console.WriteLine(total.ToString() + " + " + otherTotal.ToString() + " = " + combined);
        Console.ReadLine();

        int difference = 10 - 5;
        Console.WriteLine("Ten minus five = " + difference.ToString());
        Console.ReadLine();

        int product = 10 * 5;
        Console.WriteLine("Ten X Five = " + product);
        Console.ReadLine();

        double quotient = 100.0 / 17.0;
        Console.WriteLine("100 / 17 = " + quotient);
        Console.ReadLine();

        int remainder = 11 % 2;
        Console.WriteLine("The remainder of 11 / 2 is " + remainder);
        Console.ReadLine();

        bool trueOrFalse = 12 < 5;
        Console.WriteLine("Twelve is less than 5 is " + trueOrFalse.ToString());
        Console.ReadLine();

        Console.WriteLine("Enter the current room temperature: ");
        string roomTemperature = Console.ReadLine();
        Console.WriteLine("Enter the current outdoor temperature: ");
        string currentTemperature = Console.ReadLine();        
        bool isWarm = Convert.ToInt32(currentTemperature) < Convert.ToInt32(roomTemperature);
        Console.WriteLine((isWarm) ? "It is warmer inside than it is outside." :
            "It is warmer outside than it is inside.");
        Console.ReadLine();

    }
}
