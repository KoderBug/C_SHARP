using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPgm2
{
    class Program
    {
        static void Main(string[] args)      
        {
            Employee<int> empInt = new Employee<int>();
            empInt.things = new List<int>();
            empInt.things.Add(101);
            empInt.things.Add(102);
            empInt.things.Add(103);
            empInt.things.Add(104);
            empInt.things.Add(105);

            Employee<string> empString = new Employee<string>();
            empString.things = new List<string>();
            empString.things.Add("Accounting");
            empString.things.Add("Human Resources");
            empString.things.Add("Professional Services");
            empString.things.Add("Advanced Solutions");
            empString.things.Add("Engineering");


            Console.WriteLine("List of Employee Integers: ");
            foreach (int empI in empInt.things)
            {               
                Console.WriteLine(empI);              
            }

            Console.WriteLine("List of Employee Strings: ");
            foreach (string empStr in empString.things)
            {
                Console.WriteLine(empStr);
            }
            Console.ReadLine();


            //var empArray = new Employee[5];
            //for (int i = 0; i < empArray.Length; i++)
            //{
            //    empArray[i] = new Employee();
            //}

            //empArray[0].id = 101;
            //empArray[1].id = 102;
            //empArray[2].id = 103;
            //empArray[3].id = 101;
            //empArray[4].id = 104;

            //Employee e1 = new Employee() { firstName = "Sample", lastName = "Student" };

            //for (int i = 0; i < empArray.Length; i++)
            //{
            //    for (int j = i + 1; j < empArray.Length; j++)
            //        if (empArray[i] == empArray[j])
            //        {
            //            Console.WriteLine("Duplicate employee id " + empArray[i].id);
            //            Console.ReadLine();
            //        }
            //}

            //Employee quittable = new Employee();
            //quittable.Quit();
        }
    }
}
