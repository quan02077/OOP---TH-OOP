using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface02
{
    internal abstract class BatDongSan
    {
        string maSo;
        float chieuDai;
        float chieuRong;

        protected string MaSo
        {
            get => maSo;
            set => maSo = value;
        }

        protected float ChieuDai
        {
            get => chieuDai;
            set => chieuDai = value;
        }

        protected float ChieuRong
        {
            get => chieuRong;
            set => chieuRong = value;
        }

        public BatDongSan()
        {
            maSo = string.Empty;
            ChieuDai = 0.00f;
            ChieuRong = 0.00f;
        }

        public BatDongSan(string maSo, float chieuDai, float chieuRong)
        {
            MaSo = maSo;
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public abstract double GiaBan();

        public virtual void Xuat()
        {
            Console.WriteLine("Ma so: " + MaSo);
            Console.WriteLine("Chieu dai: {0:F2}", ChieuDai);
            Console.WriteLine("Chieu rong: {0:F2}", ChieuRong);
        }
    }
}
