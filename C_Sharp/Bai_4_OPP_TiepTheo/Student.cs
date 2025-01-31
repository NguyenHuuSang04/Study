using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4_OPP_TiepTheo
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        public Student() {
            this.Name = "";
            this.Age = 0;
            this.GPA = 0;
        }

        public Student(string name, int age, double gpa)
        {
            this.Name = name;
            this.Age = age;
            this.GPA = gpa;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Học sinh: {Name}, tuổi: {Age}, GPA: {GPA}");
        }
    }
}
