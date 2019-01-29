using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            //Console.WriteLine(ex.Message);
            Console.WriteLine("Number entered must be a whole number");
            return; //stops execution of everything
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
            //often log info in a database such as credit card information
        }
    }
}

