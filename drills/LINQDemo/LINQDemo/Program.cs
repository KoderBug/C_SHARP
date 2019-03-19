using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int i in evenNumQuery)
            {
                Console.WriteLine("{0} is an even number", i);
            }

            /*This LINQ query searches for all customers with a negative account balance.
             * orderby and ascending are used to organize the results.
             * the new keyword is needed whenever we want to select more than one field from the objects.
             */

            List < Customer > customers = new List<Customer>();

            customers.Add(new Customer("Alan", "80911291", "ABC Street", 25.60m));
            customers.Add(new Customer("Bill", "19872131", "DEF Street", -32.10m));
            customers.Add(new Customer("Carl", "29812371", "GHI Street", -12.2m));
            customers.Add(new Customer("David", "78612312", "JKL Street", 12.6m));

            var overdue =
                from cust in customers
                where cust.balance < 0
                orderby cust.balance ascending
                select new { cust.name, cust.balance };

            foreach (var cust in overdue)
                Console.WriteLine("\nName = {0}, Balance = {1}", cust.name, cust.balance);

            Console.Read();
        }
    }
}
