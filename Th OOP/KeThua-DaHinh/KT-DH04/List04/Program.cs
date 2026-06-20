using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            Console.WriteLine("Thong tin nhan vien: ");
            nv.Xuat();

            CanBoQL qb = new CanBoQL();
            Console.WriteLine("Thong tin can bo lanh dao: ");
            qb.Xuat();

            Console.ReadKey();
        }
    }
}
