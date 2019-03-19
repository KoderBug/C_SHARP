using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Customer
    {
        public string name;
        private string phone;
        private string address;
        public decimal balance;

        public Customer()
        {
            Console.WriteLine("Customer created");
        }

        public Customer(string cName, string cPhone, string cAddress, decimal cBalance)
        {
            name = cName;
            phone = cPhone;
            address = cAddress;
            balance = cBalance;
        }
    }
}
