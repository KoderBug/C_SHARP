using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameter");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID +
                "\nMember Since: " + memberSince + "\nTotal Annual Fee: "
                + annualFee;
        }

        /* The virutal keyword tells the parent class that the method may be
        *  overridden in derived classes.  When the compiler encounters this keyword, 
        *  it'll look for the same method in the derived class and execute that method instead
        */
        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }

    }    
}
