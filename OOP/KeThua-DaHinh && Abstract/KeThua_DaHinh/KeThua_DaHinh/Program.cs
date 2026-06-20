using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Nhap thong tin nhan vien ===");
            NhanVien nv = new NhanVien();
            nv.Nhap();

            Console.WriteLine("\n=== Nhap thong tin can bo quan ly ===");
            CanBoQL cbql = new CanBoQL();
            cbql.Nhap();

            Console.WriteLine("\n=== Thong tin nhan vien vua nhap ===");
            nv.Xuat();

            Console.WriteLine("\n=== Thong tin can bo quan ly vua nhap ===");
            cbql.Xuat();

            Console.ReadKey();
        }
    }
}
