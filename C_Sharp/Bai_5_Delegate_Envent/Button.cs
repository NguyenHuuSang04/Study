using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_Delegate_Envent
{
    internal class Button
    {
        public delegate void ButtonClickHandler();
        public event ButtonClickHandler OnClick;

        public void Click()
        {
            Console.WriteLine("Nút đã được bấm!");
            OnClick?.Invoke(); // Kích hoạt sự kiện
        }

        
    }
}
