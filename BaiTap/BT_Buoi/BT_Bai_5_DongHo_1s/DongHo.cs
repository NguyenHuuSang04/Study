using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BT_Bai_5_DongHo_1s
{
    internal class DongHo
    {
        // Delegate thông báo thời gian
        public delegate void ThongBaoGio();

        //Event thông báo khi 2s đã trôi qua
        public event ThongBaoGio HienThi;

        // Phương thức chạy đồng hồ
        //public void Second()
        //{
        //    Console.WriteLine("Thời gian đang chạy");
        //    System.Threading.Thread.Sleep(2000); // giả lập thời gian đã qua
        //    HienThi?.Invoke();
        //}

        public void Start()
        {
            Console.WriteLine("Đồng hồ bắt đầu chạy...(Nhấn ESC để thoát)");
            while (true) 
                {
                    Thread.Sleep(2000); // Dừng 2s
                    HienThi?.Invoke(); // Kích hoạt sự kiện
                }
        }
    }
}
