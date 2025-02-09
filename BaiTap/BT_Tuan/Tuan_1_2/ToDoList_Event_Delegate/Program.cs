using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_Event_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ToDoList toDoList = new ToDoList();

            // Bước 3: Đăng ký sự kiện để hiển thị thông báo & ghi log
            toDoList.CongViecMoi += HienThiThongBao;
            toDoList.CongViecMoi += GhiLog;

            while (true) 
            {
                Console.Write("\n Nhập công việc mới ( hoặc 'exit' để thoát): ");
                string congViec = Console.ReadLine();

                if (congViec.ToLower() == "exit")
                {
                    Console.WriteLine("Thoát chương trình");
                    break;
                } 
                
                //Thêm công việc vào danh sách
                toDoList.ThemCongViec(congViec);
            }

            //Hiển thị danh sách công việc sau khi thoát
            toDoList.HienThiDanhSach();
        }

        private static void GhiLog(string congViec)
        {
            string logMessage = $"{DateTime.Now}: {congViec}\n";
            File.AppendAllText("Log.txt", logMessage);
        }

        private static void HienThiThongBao(string congViec)
        {
            Console.WriteLine($"Đã thêm công việc: {congViec}");
        }
    }
}
