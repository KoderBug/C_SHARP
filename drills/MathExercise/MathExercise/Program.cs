using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string inputNumber = Console.ReadLine();
        Console.WriteLine(inputNumber + " * 50 = " + (Convert.ToInt32(inputNumber) * 50));
        //Console.Read();

        Console.WriteLine("Please enter a number: ");
        inputNumber = Console.ReadLine();
        Console.WriteLine(inputNumber + " + 25 = " + (Convert.ToInt32(inputNumber) + 25));

        Console.WriteLine("Please enter a number: ");
        inputNumber = Console.ReadLine();
        Console.WriteLine(inputNumber + " / 12.5 = " + (Convert.ToInt32(inputNumber) / 12.5));

        Console.WriteLine("Please enter a number: ");
        inputNumber = Console.ReadLine();
        bool comparisonInput = Convert.ToInt32(inputNumber) > 50;
        if (comparisonInput)
        {
            Console.WriteLine("Your number is greater than 50");
        } else
        { 
            Console.WriteLine("Your number is less than 50");
        }

        Console.WriteLine(Convert.ToString(comparisonInput));

        Console.WriteLine("Please enter a number: ");
        inputNumber = Console.ReadLine();
        Console.Write(inputNumber + " % 7 = " + (Convert.ToInt32(inputNumber) % 7));
        Console.Read();
    }
}


