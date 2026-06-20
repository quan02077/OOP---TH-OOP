using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface02
{
    internal class KhachSan: BatDongSan, IPhiKD
    {
        int soSao;
        public int SoSao { get => soSao; set => soSao = value; }

        public KhachSan(string maSo, float chieuDai, float chieuRong, int soSao): base(maSo, chieuDai, chieuRong)
        {
            SoSao =  soSao;
        }

        public override double GiaBan()
        {
            return 100000 + SoSao * 50000;
        }

        public double PhiKD()
        {
            return ChieuRong * 5000;
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
