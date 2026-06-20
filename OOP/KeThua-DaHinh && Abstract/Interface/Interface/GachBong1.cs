using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class GachBong1: HoaDon, IHoTro
    {
        string hangSX;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Hang san xuat: ");
            hangSX = Console.ReadLine();
            Console.WriteLine();
        }

        public double HoTro()
        {
            if (SoLuong < 200)
                return 0.03 * SoLuong * DonGia;
            else if (SoLuong >= 200 && SoLuong <= 800)
                return 0.04 * SoLuong * DonGia;
            else
                return 0.05 * SoLuong * DonGia;
        }

        public override double GiamGia()
        {
            if (string.Compare(hangSX, "Dong Tam", true) == 0)
                return 0.1 * DonGia * SoLuong;
            else
            {
                if (SoLuong >= 1000)
                    return 0.04 * DonGia * SoLuong;
                else
                    return 0;
            }
        }

        public override double ThueNK()
        {
            return 0;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Hang san xuat: " + hangSX);
            Console.WriteLine("Giam gia: {0:N0}", GiamGia());
            Console.WriteLine("Ho tro: {0:N0}", HoTro());
            Console.WriteLine("Thue: {0:N0}", Thue());
            Console.WriteLine("Tong tien: {0:N0}", ThanhTien() - HoTro());
            Console.WriteLine();
        }
    }
}
