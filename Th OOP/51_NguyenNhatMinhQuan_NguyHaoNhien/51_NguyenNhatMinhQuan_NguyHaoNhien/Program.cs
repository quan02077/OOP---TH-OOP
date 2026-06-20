using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_NguyHaoNhien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuaHang ch = new CuaHang();
            ch.DocFileXML(@"..\..\CuaHang.xml");
            Console.WriteLine("----Danh sach thong tin cua hang----");
            ch.XuatTTCH();

            Console.WriteLine("Tong doanh thu tu cac don hang: " + ch.TongDoanhThu());
            Console.WriteLine();

            Console.WriteLine("----Danh sach thong tin cua hang sau khi sap xep giam dan theo ngay dat hang----");
            CuaHang SXDS = ch.SXDSDH();
            SXDS.XuatTTCH();

            Console.WriteLine("----Don hang co tong tien cao nhat----");
            DonHang dh = ch.DonHangTongTienMax();
            dh.Xuat();
            Console.ReadKey();
        }
    }
}
