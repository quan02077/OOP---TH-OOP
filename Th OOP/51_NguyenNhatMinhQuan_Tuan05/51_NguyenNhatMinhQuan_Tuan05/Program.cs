using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CongTy cty = new CongTy();
            cty.DocFileXml(@"..\..\congty.xml");
            Console.WriteLine("---Danh sach nhan vien----");
            cty.XuatDS();

            Console.WriteLine("Tong thu nhap: {0:N0}", cty.TongThuNhap());
            Console.ReadKey();
        }
    }
}
