using System;
using System.Text;


class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("String Concatenation\n");
        String poohPoem1 = "\"If you live to be\n a hundred,\n I want to live\n ";
        String poohPoem2 = "to be\n a hundred \n minus one day\n so I never\n";
        String poohPoem3 = " have to live\n without you.\" \n\tsaid Winnie the Pooh to Piglet";

        Console.WriteLine(poohPoem1 + poohPoem2 + poohPoem3);

        Console.WriteLine("\n\nString converted to uppercase");
        String poohPower = "\n\"You're braver than you believe and stronger and smarter than you think.\"";
        Console.WriteLine(poohPower);
        Console.WriteLine(poohPower.ToUpper());

        Console.WriteLine("\n\nStringBuilder Paragraph");
        StringBuilder piglet = new StringBuilder();
        piglet.Append("\n Piglet noticed that even though he had a very small heart,");
        piglet.Append(" it could hold a \n rather large amount of gratitude.");
        piglet.Append("  \"People say nothing is impossible, \n but I do nothing every day.\" said Pooh.");
        piglet.Append("  \"A day without a friend is like ");
        piglet.Append("\n a pot without a single drop of honey left inside.\" said Piglet.");

        Console.WriteLine(piglet);

        Console.ReadLine();
    }
    }

