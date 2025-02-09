using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhDoanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int soCanDoan = random.Next(1, 100);
            int soLanThu = 0;
            int soNguoiChoiDoan;

            Console.WriteLine("Chào mừng bạn đến với game đoán số");
            Console.WriteLine("Máy đã chọn một số từ 1 - 100. Hãy thử đoán nào!!!");

            do
            {
                Console.Write("Nhập số bạn đoán: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out soNguoiChoiDoan)) 
     // TryParse là một phương thức int giúp chuyển đổi chuỗi string sang số nguyên
     //out soNguoiChoiDoan: nếu chuyển đổi thành công, giá trị số nguyên sẽ được lưu vào biến soNguoiChoiDoan
     // + Nếu thất bại soNguoiChoiDoan giữ nguyên giá trị mặc định là 0
     // if(!int.TryParse(...)): nếu người chơi nhập sai định dạng, tryParse sẽ trả về false--> dấu ! (phủ định) biến false thành true --> if kích hoạt
     // continue; bỏ qua phần còn lại của vòng lặp hiện tại và bắt đầu vòng lặp mới
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ");
                    continue;
                }

                soLanThu++;

                if (soNguoiChoiDoan < soCanDoan)
                {
                    Console.WriteLine("Lớn lên");
                }
                else if (soNguoiChoiDoan > soCanDoan)
                {
                    Console.WriteLine("Nhỏ lại");
                }
                else
                {
                    Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng sau {soLanThu} lần thử");
                    break;

                }
            } while (true);
            Console.WriteLine("Cảm ơn bạn đã chơi");
            Console.ReadKey();
        }
    }
}
