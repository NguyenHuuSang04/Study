using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_KeThua
{
    public class NhanVien
    {
        // Khởi tạo
        public string MaNV { get; set; }
        public string TenNV { get; set; }


        // PHương thức tính lương nv
        public double TinhLuong()
        {
            return 1000;
        }

        // Hàm ảo virtual
        public virtual double ThuongDuCong(int ngayCong)
        {
            if (ngayCong >= 26)
                return 100;
            else
                return 0;
        }

        //public double ThuongDuCong(int ngayCong)
        //{
        //    if (ngayCong >= 26)
        //        return 100;
        //    else
        //        return 0;
        //}


    }
}
