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
            ////NgoaiLe();
            //try
            //{
            //    NgoaiLe2();
            //}
            //catch (ArithmeticException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // Tạo đối tượng không truyền giá trị constructor default
            SinhVien sinhVien1 = new SinhVien();
           

            // Xuất constructor default
            Console.WriteLine(sinhVien1.TenSV);
            Console.WriteLine(sinhVien1.MaSV);

            // Tạo đối tượng truyền giá trị cho sv
            SinhVien sinhVien2 = new SinhVien("22719241", "KTHH", 30);
            Console.WriteLine("MSSV: " + sinhVien2.MaSV + " Tên sv: " + sinhVien2.TenSV);

            //4. Phương thức Tostring
            Console.WriteLine(sinhVien1.ToString());
            Console.WriteLine(sinhVien2.ToString());

            sinhVien1.XuatThongTin();
            sinhVien2.XuatThongTin();
            Console.WriteLine(sinhVien2.Tong(1.5, 2, 3));

            // Parametter list
            Console.WriteLine(sinhVien2.TBKTHocKy(1,2,3,4,5,6,7,8,10));

            //Auto-Implemented Properties
            HocSinh hocSinh1 = new HocSinh();
            HocSinh hocSinh2 = new HocSinh();
            hocSinh1.Name = "Hương";
            hocSinh1.Email = "123@gmail.com";
            hocSinh1.Password = "13/05/2004";

            hocSinh2.Name = "Sang";

            Console.WriteLine(hocSinh1);
            Console.WriteLine(hocSinh2);


            Console.ReadKey();
        }
       
        
    }
}
