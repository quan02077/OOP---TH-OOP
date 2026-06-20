using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class GachBong2: HoaDon, IHoTro
    {
        string loai;
        float khoangcachGH;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Loai gach: ");
            loai = Console.ReadLine();
            Console.Write("Khoang cach giao hang: ");
            khoangcachGH = float.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public double HoTro()
        {
            if (string.Compare(loai, "Granite", true) == 0)
                return 0.03 * SoLuong;
            else
                return 0.05 * SoLuong;
        }

        public override double GiamGia()
        {
            if (khoangcachGH > 15)
                return 0;
            else if (khoangcachGH < 5)
                return 0.05 * DonGia * SoLuong;
            else
                return 0.03 * DonGia * SoLuong;
        }

        public override double ThueNK()
        {
            return 0;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Loai gach: " + loai);
            Console.WriteLine("Khoang cach giao hang: {0:F2}", khoangcachGH);
            Console.WriteLine("Giam gia: {0:N0}", GiamGia());
            Console.WriteLine("Ho tro: {0:N0}", HoTro());
            Console.WriteLine("Thue: {0:N0}", Thue());
            Console.WriteLine("Tong tien: {0:N0}", ThanhTien() - HoTro());
            Console.WriteLine();
        }
    }
}
