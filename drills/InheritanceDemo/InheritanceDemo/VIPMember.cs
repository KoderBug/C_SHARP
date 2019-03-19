using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) :
            base (name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        // The override keyword declares that this method overrides the method in the parent class

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }
}
