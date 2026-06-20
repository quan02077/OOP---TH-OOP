using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Buoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChungChiTinHoc c1 = new ChungChiTinHoc();
            Console.WriteLine("Ptkt mac dinh");
            c1.Xuat();

            ChungChiTinHoc c2 = new ChungChiTinHoc(c1);
            Console.WriteLine("Ptkt sao chep");
            c2.Xuat();

            ChungChiTinHoc c3 = new ChungChiTinHoc("Nguyen Nhat Minh Quan", "2001240388", 2006, 8.75f, 9.50f);
            Console.WriteLine("Ptkt co tham so");
            c3.Xuat();

            ChungChiTinHoc c4 = new ChungChiTinHoc();
            Console.WriteLine("Nhap bang tay");
            c4.Nhap();
            c4.Xuat();
        }
    }
}
