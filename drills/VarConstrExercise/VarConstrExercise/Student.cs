using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarConstrExercise
{
    public class Student
    {
        public Student()
        {
        }
        public Student(string name) : this(name, "Liberal Arts")
        {
        }
        public Student(string name, string major)
        {
            Name = name;
            Major = major;
        }


        public string Name { get; set; }
        public string Major { get; set; }
    }
}
