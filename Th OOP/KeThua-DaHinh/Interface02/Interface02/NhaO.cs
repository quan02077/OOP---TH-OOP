using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface02
{
    internal class NhaO: BatDongSan
    {
        int soLau;

        public int SoLau { get => soLau; set => soLau = value; }

        public NhaO(string maSo, float chieuDai, float chieuRong, int soLau) : base(maSo, chieuDai, chieuRong)
        {
            SoLau = soLau;
        }

        public override double GiaBan()
        {
            return (ChieuDai * ChieuRong) * 10000 + SoLau * 100000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Gia ban: {0:N0}", GiaBan());
            Console.WriteLine();
        }
    }
}
