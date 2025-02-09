using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BT_Bai_5_PhimBam
{
    internal class Butoon
    {
        //delegate hiển thị phím bấm có tham số
        public delegate void ThongBaoPhimBam(string phimBam);

        //even kích hoạt khi có phím bấm
        public event ThongBaoPhimBam HienThi;

        // phương thức Click
        public bool Click()
        {
            Console.Write("Nhấm phím: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                return false;
            } 

            //Kích hoạt event, truyền phím bấm vào
            HienThi?.Invoke(keyInfo.Key.ToString());
            return true;
        }
    }
}
