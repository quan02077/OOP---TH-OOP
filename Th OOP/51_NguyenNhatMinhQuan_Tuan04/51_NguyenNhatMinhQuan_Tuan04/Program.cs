using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NhanVien nv = new NhanVien();
            //nv.Xuat();

            //CanBoLanhDao cb = new CanBoLanhDao();
            //cb.Xuat();

            CongTyABC ct = new CongTyABC();
            ct.DocFileXml(@"..\..\DSCTY.xml");
            Console.WriteLine("----Danh sach nhan vien----");
            ct.XuatDS();

            Console.WriteLine("Luong cao nhat: {0:N0}", ct.LuongMax());
            Console.WriteLine("----Nhan vien co luong cao nhat----");
            NhanVien nv = ct.NVLuongMax();
            nv.Xuat();

            Console.WriteLine("----Danh sach can bo----");
            ct.XuatCB();
            Console.ReadKey();
        }
    }
}
