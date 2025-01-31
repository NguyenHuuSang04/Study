using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_KeThua
{
    public class NhanVienDiCa: NhanVien
    {
        // Khai báo thêm thuộc tính ca ngày, ca đem
        public string Ca {  get; set; }

        // Phương thức tính lương của nhân viên di ca
        public new double TinhLuong()
        {
            return base.TinhLuong() * 1.05; // base.TinhLuong() gọi lại giá trị tinhLuong ở nhanVien ( 1000 )
        }
            
    }
}
