using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nguoi n1 = new Nguoi();
            Console.WriteLine("Thong tin nguoi can luu tru: ");
            n1.Xuat();

            SinhVien sv1 = new SinhVien();
            Console.WriteLine("Thong tin sinh vien: ");
            sv1.Xuat();

            Console.ReadKey();
        }
    }
}
