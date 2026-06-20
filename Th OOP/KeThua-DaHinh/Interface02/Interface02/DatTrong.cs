using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface02
{
    internal class DatTrong: BatDongSan
    {
        public DatTrong(string maSo, float chieuDai, float chieuRong): base(maSo, chieuDai, chieuRong)
        {
            MaSo = maSo;
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }
        public override double GiaBan()
        {
            return (ChieuDai * ChieuRong) * 10000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Gia ban: {0:N0}", GiaBan());
            Console.WriteLine();
        }
    }
}
