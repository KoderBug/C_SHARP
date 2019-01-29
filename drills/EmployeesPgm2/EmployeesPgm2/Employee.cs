using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPgm2
{
    class Employee<T> : Person, IQuittable
    {
        public List<T> things;
        public int id = 0;
               
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("Take this job and shove it ;-)");
            Console.ReadLine();
        }

        //public static bool operator== (Employee employee1, Employee employee2)
        //{
        //    if (employee1.id == employee2.id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public static bool operator!= (Employee employee1, Employee employee2)
        //{
        //    if (employee1.id != employee2.id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
