using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_OPP_Basic
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Xin chào, mình là {Name}, {Age} tuổi.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Sang", 20);
            person.Introduce();

            Console.ReadKey();
        }
    }

}
