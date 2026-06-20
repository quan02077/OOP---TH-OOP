using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface02
{
    internal class BietThu: BatDongSan, IPhiKD
    {
        public BietThu(string maSo, float chieuDai, float chieuRong) : base(maSo, chieuDai, chieuRong)
        {
            MaSo = maSo;
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public override double GiaBan()
        {
            return (ChieuDai * ChieuRong) * 400000;
        }

        public double PhiKD()
        {
            return (ChieuDai * ChieuRong) * 1000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Phi kinh doanh: {0:N0}", PhiKD());
            Console.WriteLine("Gia ban: {0:N0}", GiaBan() + PhiKD());
            Console.WriteLine();
        }
    }
}
