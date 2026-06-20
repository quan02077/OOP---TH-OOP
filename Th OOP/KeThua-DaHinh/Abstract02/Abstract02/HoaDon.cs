using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract02
{
    internal abstract class HoaDon
    {
        string maKH;
        string tenKH;
        int soLuong;
        int giaBan;

        public string MaKH
        {
            get => maKH;
            set => maKH = value;
        }

        public string TenKH
        {
            get => tenKH;
            set => tenKH = value;
        }

        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }

        public int GiaBan
        {
            get => giaBan;
            set => giaBan = value;
        }

        public HoaDon()
        {
            MaKH = "0001";
            TenKH = "Nguyễn Nhật Minh Quân";
            SoLuong = 10;
            GiaBan = 250000;
        }

        public HoaDon(string maKH, string tenKH, int soLuong, int giaBan)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SoLuong = soLuong;
            GiaBan = giaBan;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma khach hang: " + MaKH);
            Console.WriteLine("Ten khach hang: " + TenKH);
            Console.WriteLine("So luong: " + SoLuong);
            Console.WriteLine("Gia ban: {0:N0}", GiaBan);
        }

        public abstract double ThanhTien();
    }
}
