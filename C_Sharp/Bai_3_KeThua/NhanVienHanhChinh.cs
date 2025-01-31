using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_KeThua
{
    public class NhanVienHanhChinh: NhanVien
    {
        public override double ThuongDuCong(int ngayCong)
        {
            return 0;
        }

        //public new double ThuongDuCong()
        //{
        //    return  base.ThuongDuCong() * 0; // base.TinhLuong() gọi lại giá trị tinhLuong ở nhanVien ( 1000 )
        //}

    }
}
