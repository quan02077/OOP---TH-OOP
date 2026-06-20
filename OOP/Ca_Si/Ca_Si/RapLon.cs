using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_Si
{
    internal class RapLon: HopDong, IHoTro
    {
        int khanGia;

        public void Nhap()
        {
            Console.WriteLine("Nhap vao so luong khan gia: ");
            khanGia = int.Parse(Console.ReadLine());
        }

        public override double PhiQuangCao()
        {
            if (khanGia < 1000000)
                return 30000000;
            else
                return 50000000;
        }

        public double HoTro()
        {
            int cumKG = khanGia / 100000;

            double hotro = cumKG * 1000000;

            if (hotro > 20000000)
                hotro = 20000000;
            return hotro;   
        }

        public override void Xuat()
        {
            Console.WriteLine("So luong khan gia: " + khanGia);
            base.Xuat();
            Console.WriteLine("Thanh tien: {0:N0}", ThanhTien() - HoTro());
            Console.WriteLine("Thue: {0:N0}", Thue());
        }
    }
}
