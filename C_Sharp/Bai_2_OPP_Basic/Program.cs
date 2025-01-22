using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_OPP_Basic

{
    internal class Program
    {
        static void NgoaiLe()
        {
            try
            {
                Console.WriteLine("Mời nhận vào ngày tháng năm sinh");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine($"Ngày sinh của bạn là: {birthday.ToString("dd/MM/yyyy")}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Cảm ơn bạn đã sử dụng phần mềm");
            }
        }

        static void NgoaiLe2()
        {
            Console.WriteLine("Mời nhập vào tử số");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào mấu số");
            int mau = int.Parse(Console.ReadLine());
            if (mau == 0)
            {
                throw new ArithmeticException("Lỗi mẫu bằng 0 rồi HH ơi");
            }
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
                //NgoaiLe();
                try
                {
                    NgoaiLe2();
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e.Message);
                }
            Console.ReadKey();
        }
       
        
    }
}
