using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("#1 User Input String Array");
        string[] textArray = new string[5];

        for (int i = 0; i < textArray.Length; i++)
        {
            Console.WriteLine("\nPlease enter a string of text: ");
            textArray[i] = Console.ReadLine();
        }

        Console.WriteLine("\nYou entered the following strings: ");
        for (int i = 0; i < textArray.Length; i++)
        {
            Console.WriteLine(textArray[i]);
        }
        Console.ReadLine();


        //infinite loop if user input is not found in list
        Console.WriteLine("\n#2 Infinite Loop, code is commented out"); 

        //string[] things = {"hat", "bat", "cab", "fan", "rug"};        
        //Console.WriteLine("Please enter a 3 letter word: ");
        //string thing = Console.ReadLine();
        //bool done = false;
        //do
        //{
        //    for (int i=0; i < things.Length; i++)
        //    {
        //        if (thing == things[i])
        //        {
        //            Console.WriteLine("Your thing was found! " + thing);
        //            done = true;
        //        }
        //        Console.WriteLine(things[i]);
        //    }
        //}
        //while (!done);

        Console.WriteLine("\n#3 Infinite Loop Fix");
        string[] items = { "hat", "bat", "cab", "fan", "rug" };
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
        Console.WriteLine("\nPlease enter a 3 letter word: ");
        string item = Console.ReadLine();
        Console.WriteLine("\n");
        bool complete = false;
        do
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (item == items[i])
                {
                    Console.WriteLine(item + "  Your thing was found!");
                    complete = true;
                }
                else
                {
                    Console.WriteLine(items[i]);
                }

                if (i == items.Length - 1)
                {
                    complete = true;
                }
            }
        }
        while (!complete);


        Console.WriteLine("\n#4 Less Than Loop");
        int[] creditScores = { 743, 596, 680, 793, 802, 423, 697, 738, 649 };
        int j = 0;
        do
        {
            Console.WriteLine("Your credit score, " + creditScores[j] + " is too low, no apartments available.");
            j++;
        }
        while (creditScores[j] < 800);
        Console.WriteLine("Your credit score, " + creditScores[j] + ", is excellent! Congratulations we have an apartment.");
        Console.ReadLine();

        Console.WriteLine("\n#5 Less Than or Equal Loop");
        int[] actScores = { 28, 15, 35, 27, 36, 17, 38 };
        j = 0;
        do
        {
            Console.WriteLine("Your ACT score, " + actScores[j] + ", is too low, no college admission for you.");
            j++;
        }
        while (actScores[j] <= 36);
        Console.WriteLine("Your ACT score, " + actScores[j] + " is excellent! Congratulations you are the last student accepted to Harvard this year!");
        Console.ReadLine();


        Console.WriteLine("\n#6 Unique Array, item found in search");
        List<string> animals = new List<string>() { "cat", "dog", "rat", "pig", "bee", "ant"};

        for (int i = 0; i < animals.Count; i++)
        {
            Console.WriteLine(animals[i]);
        }

        Console.WriteLine("Please enter an animal with 3 letters: ");
        string animal = Console.ReadLine();
        Console.WriteLine("\n");
        foreach (string animale in animals)
        {
            if(animale == animal)
            {
                Console.WriteLine(animale + "  Your animal was found! ");
            } else
            { 
            Console.WriteLine(animale);
            }
        }
        Console.ReadLine();

        Console.WriteLine("\n#7 Item not found in search");
        Console.WriteLine("Please enter an animal with 3 letters: ");
        animal = Console.ReadLine();
        Console.WriteLine("\n");
        bool found = false;
        foreach (string animale in animals)
        {
            if (animale == animal)
            {
                Console.WriteLine(animale + "  Your animal was found! ");
                found = true;
            }
            Console.WriteLine(animale);
        }
        if (!found)
        { 
            Console.WriteLine("\nThe animal you entered was not in the list.");
        };


        Console.WriteLine("\n#8 Exit loop when item found");
        
        Console.WriteLine("Please enter an animal with 3 letters: ");
        animal = Console.ReadLine();
        Console.WriteLine("\n");

        foreach (string animale in animals)
            {
                if (animale == animal)
                {
                    Console.WriteLine("Your animal was found! " + animale);
                    //notFound = false;
                    break;
                }
                Console.WriteLine(animale);
            }

        Console.WriteLine("\n#9 Iterate through List and display indexes of matching items");
        List<string> rhymes = new List<string>() { "man", "can", "ban", "lan", "can", "tan" };
        for (int i = 0; i < rhymes.Count; i++)
        {
            Console.WriteLine(rhymes[i]);
        }

        Console.WriteLine("Please enter a 3 letter word that rhymes with van: ");
        string input = Console.ReadLine();
        Console.WriteLine("\n");
        int m = 0;
        foreach (string rhyme in rhymes)
        {
            if (input == rhyme)
            {
                Console.WriteLine("Found a match at index number " + m);
            }
            Console.WriteLine(rhyme);
            m++;
        }


        Console.WriteLine("\n#10 Display message if user input not found in List ");
        Console.WriteLine("Please enter a 3 letter word that rhymes with van: ");
        input = Console.ReadLine();
        Console.WriteLine("\n");
        m = 0;        
        found = false;
        foreach (string rhyme in rhymes)
        {           
            if (input == rhyme)
            {
                Console.WriteLine("Found a match at index number " + m);
                found = true;
            }
            Console.WriteLine(rhyme);
            m++;
        }
        if (!found)
        {
            Console.WriteLine("No match found for your rhyme.");
        };

        Console.ReadLine();

        Console.WriteLine("\n#11Display List of items and whether or not the item has appeared in the List\n ");
        List<string> furnitures = new List<string>() { "chair", "table", "bed", "table", "lamp", "chair", "television", "stool", "chair", "dresser" };
        int index = 0;
        found = false;
        string[] compareArray = new string[furnitures.Count];
        foreach (string furniture in furnitures)
        {                 
            compareArray[index] = furniture;
            Console.WriteLine(furniture);
            for (int i = 0; i <index; i++)
            {               
                if (compareArray[i] == furniture && (!found))
                {
                    Console.WriteLine("Item appeared in list: " + furniture);
                    found = true;
                }          
            }

            if (!found)
            {
                Console.WriteLine("Item has not appeared in list: " + furniture);              
            }
            index++;
            found = false;
        }
        Console.ReadLine();       

    }
}

