using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {       
        string[] sportArray = {"soccer", "baseball", "football", "swimming", "lacrosse", "gymnastics"};
        Console.WriteLine("\nPlease select an array index between 0 and 5 to display a sport:");
        string index = Console.ReadLine();

        if (Convert.ToInt32(index) > sportArray.Length - 1)
        {
            Console.WriteLine("You selected an invalid index");            
        } else {           
            Console.WriteLine("You selected " + sportArray[Convert.ToInt32(index)]);
        }

        int[] intArray = { 75, 125, 195, 225, 255, 290, 305, 330 };
        Console.WriteLine("\nPlease select an array index between 0 and 7 to display an integer:");
        index = Console.ReadLine(); if (Convert.ToInt32(index) > intArray.Length - 1)
        {
            Console.WriteLine("You selected an invalid index");
        }
        else
        {
            Console.WriteLine("You selected " + intArray[Convert.ToInt32(index)]);
        }

        List<string> candyList = new List<string>();
        candyList.Add("Skittles");
        candyList.Add("Milky Way");
        candyList.Add("Snickers");
        candyList.Add("KitKat");
        candyList.Add("Reese's");
        candyList.Add("Almond Joy");
        candyList.Add("Hershey's");

        Console.WriteLine("\nPlease select an array index between 0 and 6 to display a candy:");
        index = Console.ReadLine();
        Console.WriteLine("You selected " + candyList[Convert.ToInt32(index)]);

        Console.ReadLine();
    }
}
