using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Please enter your hourly rate: ");
        string P1Rate = Console.ReadLine();
        Console.WriteLine("Please enter hours worked per week: ");
        string P1Hours = Console.ReadLine();

        Console.WriteLine("Person 2");
        Console.WriteLine("Please enter your hourly rate: ");
        string P2Rate = Console.ReadLine();
        Console.WriteLine("Please enter hours worked per week: ");
        string P2Hours = Console.ReadLine();

        decimal annualSalary1 = ((Convert.ToDecimal(P1Rate) * Convert.ToDecimal(P1Hours)) * 52);
        Console.WriteLine("Annual salary of Person 1: ");
        Console.WriteLine( Convert.ToString(annualSalary1));

        decimal annualSalary2 = ((Convert.ToDecimal(P2Rate) * Convert.ToDecimal(P2Hours)) * 52);
        Console.WriteLine("Annual salary of Person 2: ");
        Console.WriteLine(Convert.ToDecimal(annualSalary2));

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool higherSalary = annualSalary1 > annualSalary2;
        Console.WriteLine(Convert.ToString(higherSalary));
        Console.Read();
    }

    }

