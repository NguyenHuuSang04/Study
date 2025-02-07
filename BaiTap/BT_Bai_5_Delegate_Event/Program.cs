using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Bai_5_Delegate_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Tạo đối tượng button
            Button button = new Button();

            // Đăng ký sự kiện: Khi nhấn nút, hiển thị thông báo
            button.HienThi += ThongTinPhimBam;


            // chạy vòng lặp để người dùng nhập liên tục
            while (true)
            {
                button.Click();

                // Nếu bấm ESC thì thoát chương trình
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Thoát chương trình");
                    break;
                }
            }
        }

        private static void ThongTinPhimBam(string key)
        {
            Console.WriteLine($"Bạn đã bấm phím: {key}");
        }
        // Giải thích:
        // Console.Readkey(): chờ người dùng nhấn 1 phím
        // Biến keyInfo: sẽ chứa thông tin về phím được nhấn
        // keyInfo.Key: hiển thị tên của phím được nhấn
    }
}
