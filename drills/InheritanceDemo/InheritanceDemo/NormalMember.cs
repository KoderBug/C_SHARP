using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The child constructor below with four parameters has a parameter called remarks which is used inside the child constructor.
 * The next 3 parameters are passed in as arguments to the parent constructor based on their names.
 * For instance, the second parameter in the child constructor (string name) is passed in as the first argument
 * in the parent constructor(name).
 * 
 * When the base constructor is called in Main()
 * The base constructor with 3 paramters is called and executed first.  The values "James", 1 and 2010 are passed to the base constructor.  Behind the scene,
 * these values are assigned to the fields name, memberID and memberSince in the base class respectively.
 * After executing the base constructor, the child constructor will be executed.  The string "Special Rate"
 * is assigned to remearks and displayed on the screen.
 */

namespace InheritanceDemo
{
    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }

        public NormalMember(string remarks, string name, int memberID, int memberSince) 
            : base (name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 paramters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        // The override keyword declares that this method overrides the method in the parent class

        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }
}
