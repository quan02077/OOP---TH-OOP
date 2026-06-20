using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaiLy dl = new DaiLy();
            dl.DocFileXml(@"..\..\daily.xml");
            Console.WriteLine("----Danh sach hoa don----");
            dl.XuatDS();
            Console.WriteLine("----Danh sach hoa don cua khach vang lai----");
            dl.XuatDSVL();
            Console.WriteLine("Tong tri gia: {0:N0}", dl.TongTriGia());
            Console.WriteLine();
            Console.WriteLine("----Hoa don co tri gia cao nhat----");
            HoaDon hd = dl.TriGiaMax();
            hd.Xuat();
            dl.HoaDonVipTT();
            DaiLy dl1 = dl.SapXep();
            Console.WriteLine("----Danh sach sau khi sap xep----");
            dl1.XuatDS();
            Console.ReadKey();
        }
    }
}
