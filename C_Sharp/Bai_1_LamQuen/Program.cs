














































































































































using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1_LamQuen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("KTHH");
            int age = 20;
            if (age > 0)
            {
                Console.WriteLine("Bạn là người lớn");
            }
            else
            {
                Console.WriteLine("Bạn chưa là người lớn");
            }

            int day = 3;
            switch(day)
            {
                case 0:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Orther day");
                    break;
            }

            //Vòng lặp for
            for (int i = 0;i < 10; i++)
            {
                //Console.WriteLine("Number:{0}", i); // String interpolation
                Console.WriteLine($"Number: {i}"); // Placeholder ( String format )
            }


            Console.ReadKey();
        }
    }
}

