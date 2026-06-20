using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_KTL2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NguyenNhatMinhQuan_CongTyXayDung cty = new NguyenNhatMinhQuan_CongTyXayDung();
            cty.DocFileXml(@"..\..\NguyenNhatMinhQuan_CongTy.xml");

            Console.WriteLine("=== DANH SACH HOP DONG ===");
            cty.XuatDS();

            Console.WriteLine("\nTong tien tat ca hop dong: {0:N0}", cty.TongTienHD());
            Console.WriteLine("Tong tri an: {0:N0}", cty.TongTriAn());
            Console.WriteLine("Tong tien tam ung biet thu: {0:N0}", cty.TongTienTamUngBietThu());

            Console.WriteLine("\n=== DANH SACH SAU KHI SAP XEP ===");
            cty.SapXep().XuatDS();

            Console.WriteLine();
            cty.Tim();

            Console.ReadKey();
        }
    }
}
