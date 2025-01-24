using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_OPP_Basic
{
    internal class SinhVien
    {
        #region biến lớp
        // Khai báo biến lớp
        private string maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        #region Constructor
        // Constructor
        public SinhVien()
        {
            this.maSV = "001";
            this.tenSV = "HH";
            this.diemThiDH = 0;

        }

        public SinhVien(string maSV, string tenSV, float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH=diemThiDH;
        }
        #endregion
        #region Properties
        // Khai báo Properties để có thể tủy suất sửa đổi dữ liệu ( getter, setter )
        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public float DiemThiDH
        {
            get { return diemThiDH; }
            set { diemThiDH = value; }
                
        }

        #endregion
        #region các phương thức
        // Phương thức Tostring
        public override string ToString()
        {
            return this.MaSV + "\t" + this.TenSV;
        }

        // support method
        // Kiểm tra điều kiện nhập sinh viên mới
        private bool CheckDiemThiDH()
        {
            return this.diemThiDH - 21 >= 0;
        }

        // service method ( xuất thông tin )
        public void XuatThongTin()
        {
            if (CheckDiemThiDH() == false)
            {
                Console.WriteLine("Điểm thi ĐH < 21, kiểm tra lại hồ sơ sinh viên");
            } else { Console.WriteLine("Thỏa điều kiện"); }
        }

        // tổng điểm 
        public int Tong(int x, int y)
        {
            return x + y;
        }
        public int Tong(int x, int y, int z)
        {
            return x + y + z;
        }
        public double Tong(double x, double y, double z)
        {
            return x + y + z;
        }

        // Parametter List method
        // Tính tổng điểm TB kết thúc học kỳ
        public float TBKTHocKy (params float[] mang)
        {
            float s = 0;
            foreach (float f in mang)
            {
                s += f;
            }
            return s / mang.Count();
        }
        #endregion
    }
}
