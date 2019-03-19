using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> myStaff = new List<Staff>();
            FileReader fr = new FileReader();
            int month = 0, year = 0;

            while (year == 0)
            {
                Console.WriteLine("\nPlease enter the year: ");
                try
                {
                    string stringYear = Console.ReadLine();
                    year = Convert.ToInt32(stringYear);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Invalid year, please try again");
                }
            }

            while (month == 0)
            {
                Console.WriteLine("\nPlease enter the month: ");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if (month < 1 || month > 12)
                    {
                        Console.WriteLine("Month must be between 1 and 12.  Please enter a valid month.");
                        month = 0;
                    }                          
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Invalid month, please try again.");
                }
            }

            myStaff = fr.ReadFile();

            for (int i=0; i< myStaff.Count; i++)
            {
                try
                {
                    Console.WriteLine("Please enter hours worked for {0}: ", myStaff[i].NameOfStaff);
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                    myStaff[i].CalculatePay();
                    Console.WriteLine(myStaff[i].ToString());                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Invalid entry, please try again.");
                    i--;
                }               
            }

            PaySlip ps = new PaySlip(month, year);
            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);
            Console.Read();

        
        }
    }
}
