using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Bai_5_Delegate_Event
{
    internal class Button
    {
        // Delegate có tham số để truyền phím bấm
        public delegate void ThongBaoNhanNut(string key);

        // Event để thông báo khi có nút được nhấn
        public event ThongBaoNhanNut HienThi;

        // Phương thức bắt sự kiện bấm phím
        public void Click()
        {
            Console.Write("Nhấn một phím bất kỳ (Nhấn ESC để thoát): ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine(); // xuống dòng


            // Kích hoạt event, truyền phím bấm vào
            HienThi?.Invoke(keyInfo.Key.ToString());
        }
    }
}
