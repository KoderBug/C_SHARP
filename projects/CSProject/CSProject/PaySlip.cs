using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSProject
{
    class PaySlip
    {
        private int month;
        private int year;

        enum MonthsOfYear
        { JAN=1, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, NOV, DEC }

        public PaySlip(int pMonth, int pYear)
        {
            month = pMonth;
            year = pYear;
        }

        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;

            foreach (Staff f in myStaff)
            {
                path = f.NameOfStaff + ".txt";
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)month, year);
                    sw.WriteLine("=====================================");
                    sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                    sw.WriteLine("Hours Worked: {0}", f.HoursWorked);
                    sw.WriteLine("\nBasic Pay: {0:C}", f.BasicPay);
                    if (f.GetType() == typeof(Manager))
                        sw.WriteLine("Allowance: {0:C}", ((Manager)f).Allowance);
                    else
                        sw.WriteLine("Overtime Pay: {0:C}", ((Admin)f).Overtime);
                    sw.WriteLine("\n=====================================");
                    sw.WriteLine("Total Pay: {0:C}", f.TotalPay);
                    sw.WriteLine("=====================================");
                    sw.Close();
                }
            }
        }

        // Use LINQ to generate a list of all employees who worked less than 10 hours that month.
        // Arrange the list in ascending order based on NameOfStaff
        public void GenerateSummary(List<Staff> myStaff)
        {
            var result = from f in myStaff
                         where f.HoursWorked < 10
                         orderby f.NameOfStaff ascending
                         select new { f.NameOfStaff, f.HoursWorked };

            if (result.Any())
            { 
                string path = "summary.txt";                       
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("\n\nStaff with less than 10 working hours\n");
                    foreach (var staff in result)
                    {
                        sw.WriteLine("Name of Staff: {0}, Hours Worked: {1}", staff.NameOfStaff, staff.HoursWorked);
                    }
                    sw.Close();
                }
            }
    }

        public override string ToString()
        {
            return "PaySlip generated for: " +
                    "Month:  " + month +
                    "Year:  " + year;
        }
    }
}
