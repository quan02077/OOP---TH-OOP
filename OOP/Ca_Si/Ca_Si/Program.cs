  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_Si
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaiNha  hd = new TaiNha();
            hd.Nhap();
            hd.Xuat();

            RapNho hd2 = new RapNho();
            hd2.Nhap();
            hd2.Xuat();

            RapLon hd3 = new RapLon();
            hd3.Nhap();
            hd3.Xuat();

            Console.ReadKey();
        }
    }
}
