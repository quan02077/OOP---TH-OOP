using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract02
{
    internal class DaiLyCap1: HoaDon
    {
        int thoiGianHopTac;

        public DaiLyCap1()
        {
            thoiGianHopTac = 5;
        }
    
        public DaiLyCap1(string ma, string ten, int sl, int gia, int thoiGianHopTac)
            : base(ma, ten, sl, gia)
        {
            this.thoiGianHopTac = thoiGianHopTac;
        }
        public double ChietKhau()
        {
            double ck = 0.3 * GiaBan;
            if(thoiGianHopTac > 3)
            {
                int namThem = thoiGianHopTac - 3;
                ck += namThem * 0.01  * GiaBan;
            }
            if (ck > 0.35 * GiaBan)
                ck = 0.35 * GiaBan;
            return ck;
        }

        public override double ThanhTien()
        {
            return SoLuong * GiaBan - ChietKhau() + (SoLuong * GiaBan * 0.1);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Thoi gian hop tac: " + thoiGianHopTac);
            Console.WriteLine("Thanh tien: {0:N0}", ThanhTien());
        }
    }
}
