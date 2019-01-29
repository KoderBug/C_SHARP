using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnumExercise
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a day of the week: ");
                string day = Console.ReadLine();
                string upperDay = day.ToUpper();

                bool valid = false;
                foreach (string wkDay in Enum.GetNames(typeof(DaysOfTheWeek)))
                {
                    if (upperDay == wkDay)
                    {
                        valid = true;
                    }

                    //Console.WriteLine("{0} = {0:D}", wkDay, Enum.Parse(typeof(DaysOfTheWeek), wkDay));
                    //Console.ReadLine();

                }
                //!valid ? throw Exception : Console.WriteLine(wkDay + " is a great day!");

                if (!valid)
                {                  
                    throw new InvalidDayException();
                } else {
                    Console.WriteLine(day + " is a great day!");
                }
            }
            catch (InvalidDayException)
            {
                Console.WriteLine("Invalid day of the week.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {               
                Console.ReadLine();              
            }            
        }

    }
}

