using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Bai_5_DongHo_1s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DongHo dongHo = new DongHo();
            dongHo.HienThi += HienThiThoiGianDaQua; // Đk sự kiện


            // Chạy đồng hồ trong luồng riêng
            Task.Run(() => dongHo.Start());

            //Kiểm tra phím ESC để thoát
            while (true)
            {
               if(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Thoát chương trình");
                    break;
                }    
            }
        }

        private static void HienThiThoiGianDaQua()
        {
            Console.WriteLine("Thời gian đã qua 2s");
        }
    }
}
