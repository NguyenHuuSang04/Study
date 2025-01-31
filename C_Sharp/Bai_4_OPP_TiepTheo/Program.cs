using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4_OPP_TiepTheo
{
    internal class Program
    {

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Person person = new Person();
            //person.Name = "Hương";
            //person.Age = 21;
            //person.Introduce();

            //Console.WriteLine("Nhập một số");
            //int input = int.Parse(Console.ReadLine());
            //if (IsEven(input))
            //    Console.WriteLine($"{input} là số chẵn");
            //else 
            //    Console.WriteLine($"{input} là số lẻ");


            Student student = new Student();
            student.Name = "KTHH";
            student.Age = 21;
            student.GPA = 10;
            student.DisplayInfo();



            Console.ReadLine();
                 
        }
    }
}
