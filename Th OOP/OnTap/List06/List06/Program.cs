using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoaDon hd = new HoaDon();
            hd.DocFileXml(@"..\..\hoaDon.xml");
            Console.WriteLine("----Thong tin hoa don----");
            hd.XuatDS();

            Console.WriteLine("\nTong thanh tien cua hoa don: {0}", hd.TongThanhTien());

            Console.WriteLine("\n----Danh sach sap xep----");
            HoaDon sx = hd.SapXepChiTietBH();
            sx.XuatDS();

            Console.WriteLine("\nThanh tien lon nhat: {0}", hd.ThanhTienLonNhat());
            Console.ReadKey();
        }
    }
}
