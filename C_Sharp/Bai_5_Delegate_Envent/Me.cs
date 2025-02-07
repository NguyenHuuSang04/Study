using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_Delegate_Envent
{
    internal class Me
    {
        //1 Delegate: Hứa sẽ gọi con khi cơm chính
        public delegate void GoiConXuongAn();

        //2 Event: KHi cơm chín, sự kiện này sẽ xảy ra
        public event GoiConXuongAn OnComChin;

        public void NauCom()
        {
            Console.WriteLine("Mẹ: Đang nấu cơm...");
            System.Threading.Thread.Sleep(1000); // Giả lập thời gian nấu cơm
            Console.WriteLine("Cơm đã chín!!!");

            //3: Kích hoạt sự kiện gọi con xuống ăn cơm
            OnComChin?.Invoke();
        }
    }
}
