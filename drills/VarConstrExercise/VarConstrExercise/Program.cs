using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarConstrExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            const string schoolName = "Air Academy University";
            var professor = " ";  

            Student s1 = new Student("Tom Smith",  "Engineering");     
            Student s2 = new Student("Fred Brown", "Nursing");
            Student s3 = new Student("Kim Jones");

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            Console.WriteLine("Students currently enrolled at {0}", schoolName + "\n");

            foreach (Student student in students)
            {

                switch (student.Major)
                {
                    case "Engineering":
                        professor = "Professor Scarlet";
                        break;
                    case "Liberal Arts":
                        professor = "Professor Green";
                        break;
                    default:
                        professor = "Professor Plum";
                        break;
                }

                Console.WriteLine(  student.Name + " " + student.Major + " " + professor);

            }

            Console.ReadLine();

        }
    }
}
