using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GachBong1 hd1 = new GachBong1();
            hd1.Nhap();
            hd1.Xuat();

            GachBong2 hd2 = new GachBong2();
            hd2.Nhap();
            hd2.Xuat();

            GachBongNK hd3 = new GachBongNK();
            hd3.Nhap();
            hd3.Xuat();
            Console.ReadKey();
        }
    }
}
