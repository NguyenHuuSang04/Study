using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_Delegate_Envent
{
    internal class Program
    {
        // Khai báo delegate
        delegate void ShowMessage(string message);

        //Phương thức tương thích với delegate
        static void DisplayMessage(string message)
        {
            Console.WriteLine("Thông báo: " + message);
        }

        static void LogMessage(string message)
        {
            Console.WriteLine("Ghi log: "+ message);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Phần 1: delegate
            ////Tạo một biến delegate và gán phương thức DisplayMessgae vào
            //ShowMessage show = DisplayMessage;
            //show += LogMessage;// Gán thêm phương thức LogMessage vào delegate

            ////Gọi delegate ( thực thi phương thức được trỏ đến)
            //show -=DisplayMessage;
            //show("Xin chào"); // Gọi cả 2 phương thức


            //// Phần 2: Event

            //// Đăng ký phương thức xử lý sự kiện
            //Event.OnNotify += ShowNotification;

            //// kích hoạt sự kiện
            //Event.TriggerEvent("Bạn có một tin nhắn mới");


            ////Phần 3: Button
            //Button btn = new Button();

            ////Đăng ký phương thức xử lý sự kiện
            //btn.OnClick += ButtonClicked;

            //btn.Click(); // Giả lập người dùng bấm nút


            // Phần 4: Mẹ con
            Me me = new Me();
            Children con = new Children();

            // 4: đăng ký sự kiện: Khi mẹ gọi, con sẽ xuống ăn
            me.OnComChin += con.XuongAn;

            // 5: mẹ nấu cơm
            me.NauCom();


            Console.ReadKey();

        }

        private static void ButtonClicked()
        {
            Console.WriteLine("Sự kiện: Nút đã được nhấn");
        }

        private static void ShowNotification(string message)
        {
            Console.WriteLine("Sự kiện nhận được: " + message);
        }
    }
}
