using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_Delegate_Envent
{
    internal class Event
    {
        //Bước 1: Khai báo delegate
        public delegate void NotifyEventHandler(string message);

        //Bước 2: khai báo event sử dụng delegate
        public static event NotifyEventHandler OnNotify;

        // Phương thức để kích hoạt sự kiện ( nhưng không có main )
        public static void TriggerEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }
}
