using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4_OPP_TiepTheo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            this.Name = "";
            this.Age = 0;

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine("Xin chào, tôi tên là: " + Name + " ," + Age + " tuổi");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
