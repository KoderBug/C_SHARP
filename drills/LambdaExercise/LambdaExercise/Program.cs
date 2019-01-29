using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { firstName = "Joe", lastName = "Smith", id = 1 });
            employees.Add(new Employee() { firstName = "Sally", lastName = "Jones", id = 2});
            employees.Add(new Employee() { firstName = "Tim", lastName = "Brown", id = 3 });
            employees.Add(new Employee() { firstName = "Bob", lastName = "Lee", id = 4 });
            employees.Add(new Employee() { firstName = "Kelly", lastName = "Jackson", id = 5 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "King", id = 6 });
            employees.Add(new Employee() { firstName = "Deanna", lastName = "Johnson", id = 7 });
            employees.Add(new Employee() { firstName = "Craig", lastName = "Schultz", id = 8 });
            employees.Add(new Employee() { firstName = "Ralph", lastName = "Watson", id = 9 });
            employees.Add(new Employee() { firstName = "Robyn", lastName = "Lane", id = 10 });

            List<Employee> joeEmps = new List<Employee>();
            foreach (Employee employee in employees)
            {
                
                if (employee.firstName == "Joe")
                {
                    joeEmps.Add(new Employee() { firstName = employee.firstName,
                                              lastName = employee.lastName,
                                              id = employee.id });                  
                }
            }
            Console.WriteLine("Employees named Joe: ");
            foreach (Employee joeEmp in joeEmps)
            {
                Console.WriteLine(joeEmp.firstName + " " + 
                                  joeEmp.lastName + " " + 
                                  (Convert.ToString(joeEmp.id)));
            }           

            List<Employee> joeList = employees.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine("\nLambda Function - Employees named Joe: ");
            foreach (Employee employee in joeList)
            {
                Console.WriteLine(employee.firstName + " " +
                                  employee.lastName + " " +
                                  (Convert.ToString(employee.id)));
            }


            List<Employee> newList = employees.Where(x => x.id > 5).ToList();
            Console.WriteLine("\nEmployee Ids greater than 5: ");
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.firstName + " " +
                                  employee.lastName + " " +
                                  (Convert.ToString(employee.id)));
            }
            Console.ReadLine();

        }
    }
}
 