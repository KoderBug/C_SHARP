using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.amount = 2.35m;
            Console.WriteLine(number.amount);
            Console.ReadLine();
        }
    }
}
