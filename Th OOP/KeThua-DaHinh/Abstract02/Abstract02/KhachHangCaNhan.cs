using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract02
{
    internal class KhachHangCaNhan: HoaDon, IHoTro
    {
        int khoangCachGiaoHang;

        public KhachHangCaNhan()
        {
            khoangCachGiaoHang = 11;
        }

        public KhachHangCaNhan(string ma, string ten, int sl, int gia, int khoangCach)
            : base(ma, ten, sl, gia)
        {
            this.khoangCachGiaoHang = khoangCach;
        }

        public double HoTro()
        {
            double hoTro = 0;
            hoTro = 0.02 * SoLuong * GiaBan;
            if (SoLuong > 2)
                hoTro += 100000;

            return hoTro;
        }
        public double ChietKhau()
        {
            double ck = 0;
            if (SoLuong < 5)
                ck = 0;
            else
                ck = SoLuong * GiaBan * 0.03;

            if (khoangCachGiaoHang < 10)
                ck += SoLuong * 20000;

            return ck;

        }

        public override double ThanhTien()
        {
            return (SoLuong * GiaBan - ChietKhau() + (SoLuong * GiaBan * 0.1)) - HoTro();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Khoang cach giao hang: " + khoangCachGiaoHang);
            Console.WriteLine("Thanh tien: {0:N0}", ThanhTien());
        }
    }
}
