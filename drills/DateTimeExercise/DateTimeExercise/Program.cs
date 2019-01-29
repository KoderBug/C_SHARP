using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        DateTime today = DateTime.Now;

        Console.WriteLine("The current date and time is: {0} ", today);

        Console.WriteLine("Please enter a number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("In {0} hours it will be {1}", x, today.AddHours(x));
        Console.ReadLine();

    }
}

