using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NuocGiaiKhat nuoc1 = new NuocGiaiKhat();
            //nuoc1.Xuat();
            //NuocGiaiKhat nuoc2 = new NuocGiaiKhat("Coca","Chai",10,15000);
            //nuoc2.Xuat();
            //Console.ReadKey();

            //KhoaHoc kh1 = new KhoaHoc();
            //kh1.Xuat();

            //KhoaHoc kh2 = new KhoaHoc(kh1);
            //kh2.Xuat();

            //KhoaHoc kh3 = new KhoaHoc("KH234", "OOP", 20, "7, CN", 20, "Nguyen Nhat Minh Quan");
            //kh3.Xuat();

            HinhChuNhat hcn1 = new HinhChuNhat();
            hcn1.Xuat();

            HinhChuNhat hcn2 = new HinhChuNhat(10, 5);
            hcn2.Xuat();

            hcn2.ChangeSize(3, 2, 1);
            hcn2.Xuat();

            HinhChuNhat hcn3 = new HinhChuNhat(5, 3);
            hcn3.Xuat();

            hcn3.ChangeSize(hcn3, 1 );
            hcn3.Xuat();

            Console.ReadKey();
        }
    }
}
