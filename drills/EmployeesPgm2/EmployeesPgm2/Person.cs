using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPgm2
{
    public abstract class Person
    { 
        public string firstName;
        public string lastName;

        public Person()
        {
            firstName = "";
            lastName = "";
        }

        public abstract void SayName();
    }
}
