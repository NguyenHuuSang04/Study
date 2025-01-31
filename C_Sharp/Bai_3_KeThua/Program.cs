using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nhanVien1 = new NhanVien();
            nhanVien1.MaNV = "22719241";
            nhanVien1.TenNV = "Hương";
            Console.WriteLine("Tên nhân viên: " + nhanVien1.MaNV + ", Tên nhân viên: " + nhanVien1.TenNV);
            Console.WriteLine("Lương nhân viên 1: " + nhanVien1.TinhLuong());
            

            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.MaNV = "22669281";
            hc1.TenNV = "Sang";
            Console.WriteLine("Tên nhân viên: " + hc1.MaNV + ", Tên nhân viên: " + hc1.TenNV);
            Console.WriteLine("Lương nhân viên hành chính 1: " + hc1.TinhLuong());

            NhanVienDiCa dc1 = new NhanVienDiCa();
            dc1.MaNV = "1111";
            dc1.TenNV = "Sang";
            dc1.Ca = "Ca ngày";
            Console.WriteLine("Tên nhân viên: " + dc1.MaNV + ", Tên nhân viên: " + dc1.TenNV + ", Ca: " + dc1.Ca);
            Console.WriteLine("Lương nhân viên di ca: " + dc1.TinhLuong());



            // Test hàm ảo virture
            Console.WriteLine("*********");
            Console.WriteLine(nhanVien1.ThuongDuCong(26));
            Console.WriteLine(hc1.ThuongDuCong(26));
            Console.WriteLine(dc1.ThuongDuCong(26));

            Console.ReadLine();
        }
    }
}
