using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    class Manager : Staff
    {
        private const float managerHourlyRate = 50f;
        public int Allowance { get; private set; }

        public Manager(string name)
            : base (name, managerHourlyRate )
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;

            if (HoursWorked > 160)
                TotalPay = BasicPay + Allowance;
        }
        
        public override string ToString()
        {
            return "\nManager Name:  " + NameOfStaff + 
                   "\nmanager- Hourly Rate = " + managerHourlyRate +
                "\nHours Worked " + HoursWorked +
                "\nBasic Pay = " + BasicPay + 
                "\nAllowance = " + Allowance + 
                 "\n\nTotal Pay = " + TotalPay;
        }
    }
}
