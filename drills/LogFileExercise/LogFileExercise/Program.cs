using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        string number = Console.ReadLine();

        File.WriteAllText(@"C:\Users\mshaf\logs\\log.txt", number);

        string text = System.IO.File.ReadAllText(@"C:\Users\mshaf\logs\\log.txt");
        System.Console.WriteLine("Contents of log file: {0}", text);
        Console.ReadLine();
    }
}

