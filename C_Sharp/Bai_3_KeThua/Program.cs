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
            
            
            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.MaNV = "22669281";
            hc1.TenNV = "Sang";

            NhanVienDiCa dc1 = new NhanVienDiCa();
            dc1.MaNV = "1111";
            dc1.TenNV = "Sang";
            dc1.Ca = "Ca ngày";

            Console.WriteLine("Tên nhân viên: " + nhanVien1.MaNV + ", Tên nhân viên: " + nhanVien1.TenNV);
            Console.WriteLine("Tên nhân viên: " + hc1.MaNV + ", Tên nhân viên: " + hc1.TenNV);
            Console.WriteLine("Tên nhân viên: " + dc1.MaNV + ", Tên nhân viên: " + dc1.TenNV + ", Ca: " + dc1.Ca);
            Console.ReadLine();
        }
    }
}
