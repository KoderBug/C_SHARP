using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("What course are you on?");
        string courseNumber = Console.ReadLine();
        Console.WriteLine("What page number?");
        string pgNumber = Console.ReadLine();
        int pageNumber = Convert.ToInt32(pgNumber);
        Console.WriteLine("Do you need help with anything?  Please answer 'true' or 'false'");
        string Help = Console.ReadLine();
        bool needHelp = Convert.ToBoolean(Help);
        Console.WriteLine("Were there any positive experiences you'd like to share?  Please be specific.");
        string positiveExp = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hours = Console.ReadLine();
        int studyHours = Convert.ToInt32(hours);
        Console.WriteLine("Thank you for your answers.  An Instructor will repsond to this shortly.  Have a great day!");
        Console.Read();
        }
    }

