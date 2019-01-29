using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 14, 28, 16, 21, 35, 49 };
            Console.WriteLine("List of numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Enter a divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int quotient = numbers[i] / divisor;
                Console.WriteLine(numbers[i] + " / " + divisor + " equals " + quotient);
                Console.ReadLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }            
    }
}

