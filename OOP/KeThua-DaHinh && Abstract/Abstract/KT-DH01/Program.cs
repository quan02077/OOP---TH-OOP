using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVienSanXuat nvsx = new NhanVienSanXuat();
            Console.WriteLine("----Nhap thong tin nhan vien san xuat----");
            nvsx.Nhap();
            nvsx.NhapNN();
            Console.WriteLine();
            Console.WriteLine("----Thong tin nhan vien san xuat----");
            nvsx.Xuat();
            Console.WriteLine();

            NhanVienKinhDoanh nvkd = new NhanVienKinhDoanh();
            Console.WriteLine("----Nhap thong tin nhan vien kinh doanh----");
            nvkd.Nhap();
            nvkd.NhapDS();
            Console.WriteLine();
            Console.WriteLine("----Thong tin nhan vien kinh doanh----");
            nvkd.Xuat();
            Console.WriteLine();

            CanBoQuanLy cbql = new CanBoQuanLy();
            Console.WriteLine("----Nhap thong tin can bo quan ly----");
            cbql.Nhap();
            cbql.NhapCV();
            Console.WriteLine();
            Console.WriteLine("----Thong tin can bo quan ly----");
            cbql.Xuat();

            Console.ReadKey();
        }
    }
}
