using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_Event_Delegate
{
    // Bước 1: Định nghĩa delegate
    public delegate void CongViecMoiHandler(string congViec);
    internal class ToDoList
    {
        private List<string> danhSachCongViec = new List<string>();

        //Bước 2: Khai báo sự kiện khi thêm công việc mới
        public event CongViecMoiHandler CongViecMoi;

        public void ThemCongViec(string congViec)
        {
            if (!string.IsNullOrWhiteSpace(congViec))
            {
                danhSachCongViec.Add(congViec);

                // Kích hoạt sự kiện khi có công việc mới
                CongViecMoi?.Invoke(congViec);
            }
            else
            {
                Console.WriteLine("Công việc không hợp lệ, vui lòng nhập lại!");
            }
        }
        // Nếu công việc hợp lệ --> thêm vào danh sách
        // Kích hoạt sự kiện CongViecMoi để thông báo & ghi log



        public void HienThiDanhSach()
        {
            Console.WriteLine("\nDanh sách công việc: ");
            foreach (var item in danhSachCongViec)
            {
                Console.WriteLine($"-{item}");
            }
        }
    }
}
