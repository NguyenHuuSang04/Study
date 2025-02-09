using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Bai_5_PhimBam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Butoon bt = new Butoon();
            bt.HienThi += HienThiPhimBam;

            while (bt.Click()) { } //Nếu Click() trả về false, thoát vòng lặp
            Console.WriteLine("Thoát vòng lặp");
           
        }

        private static void HienThiPhimBam(string phimBam)
        {
            string logMessage = $"Bạn đã bấm phím: {phimBam}";
            File.AppendAllText("Log.txt",logMessage + Environment.NewLine);
            Console.WriteLine(logMessage);
        }
    }
}
