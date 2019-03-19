using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using inheritance to declare different Member types within an array of Members

            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            /* CalculateAnnualFee method was initially only in the child classes
             * needed to be added in the Member parent class and declared virtual
             * the methods in the child class needed to have the override keyword added
             * this is where the compiler will try to execute this method.
             * #Polymorphism - simply means that at run time, the program is smart enough to use
             * the CalculateAnnualFee() method from the correct child class even when that object 
             * is declared to be of type Member type.
             * 
             * At run time the program determines that the first three members of clubmembers
             * are of NormalMember type and executes the CalculateAnnualFee() method from that class.
             * It also determines that the last two members are of VIPMember type and executes the
             * method from that class.
             * 
             * The runtime type of the first three elements of clubMembers is NormalMember while
             * the runtime type of the last two elements is VIPMember.  The declared type of all 5 elements is Member.
            */

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }

            Console.WriteLine("\nGetType() and typeof() example");
            if (clubMembers[0].GetType() == typeof(VIPMember))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            /*         NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
                       VIPMember mem2 = new VIPMember("Andy", 2, 2011);

                       mem1.CalculateAnnualFee();
                       mem2.CalculateAnnualFee();
                       Console.WriteLine(mem1.ToString());
                       Console.WriteLine(mem2.ToString());                       
           */
            Console.ReadLine();
        }
    }
}
