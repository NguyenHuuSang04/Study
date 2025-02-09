using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static List<string> toDoList = new List<string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===QUẢN LÝ DANH SÁCH CÔNG VIỆC===");
                Console.WriteLine("1. Thêm công việc");
                Console.WriteLine("2. Hiển thị danh sách công việc");
                Console.WriteLine("3. Xóa công việc");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng (1 - 4): ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ThemCongViec();
                        break;
                    case "2":
                        HienThiCongViec();
                        break;
                    case "3":
                        XoaCongViec();
                        break;
                    case "4":
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Nhấn phím bất kỳ để tiếp tục");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void XoaCongViec()
        {
            HienThiCongViec();
            Console.WriteLine("\nNhập thứ tự công việc muốn xóa");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
            {
                Console.WriteLine($"Đã xóa công việc: {toDoList[index - 1]}");
                toDoList.RemoveAt(index - 1);
            }
            else
            {
                Console.WriteLine("Số thứ tự không hợp lệ");
            }
            Console.ReadKey();
        }

        private static void HienThiCongViec()
        {
            Console.WriteLine("\n===Danh sách công việc===");
            if (toDoList.Count == 0)
            {
                Console.WriteLine("Danh sách trống");
            }
            else
            {
                for(int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i+1}, {toDoList[i]}");
                }
            }
            Console.ReadKey();
        }

        private static void ThemCongViec()
        {
            Console.WriteLine("Nhập công việc mới");
            string congViec = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(congViec)) // kiểm tra có rỗng hoặc null không
                // nếu rỗng or null --> trả về true
                // Nếu có nội dung --> trả về false
                // string.IsNullOrEmpty(): kiểm tra chuỗi có dữ liệu hợp lệ không
                // string.IsNullOrWhilteSpace(): chặt chẽ hơn vì kiểm tra cả khoảng trắng
            {
                toDoList.Add(congViec);
                Console.WriteLine("Đã thêm công việc!");
            }
            else
            {
                Console.WriteLine("Công việc không được để trống");
            }
            Console.ReadKey();
        }
    }
}
