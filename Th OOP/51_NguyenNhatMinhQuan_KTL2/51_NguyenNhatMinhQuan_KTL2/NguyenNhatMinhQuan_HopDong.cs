using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_KTL2
{
    internal abstract class NguyenNhatMinhQuan_HopDong
    {
        string maHD;
        string tenHD;
        string tenKH;
        int thoiGianXayDung;
        float chieuDai;
        float chieuRong;
        float soTienTamUng;
        public static double DonGia = 4500;

        public string MaHD { get => maHD; set => maHD = value; }
        protected string TenKH { get => tenKH; set => tenKH = value; }
        protected int ThoiGianXayDung { get => thoiGianXayDung; set => thoiGianXayDung = value; }
        protected float ChieuDai { get => chieuDai; set => chieuDai = value; }
        protected float ChieuRong { get => chieuRong; set => chieuRong = value; }
        public float SoTienTamUng { get => soTienTamUng; set => soTienTamUng = value; }

        public NguyenNhatMinhQuan_HopDong()
        {
            MaHD = "0001";
            TenKH = "Nguyen Nhat Minh Quan";
            ThoiGianXayDung = 5;
            ChieuDai = 36.5f;
            ChieuRong = 28.7f;
            SoTienTamUng = 1150000;
        }

        public NguyenNhatMinhQuan_HopDong(string maHD, string tenKH, int thoiGianXayDung, float chieuDai, float chieuRong, float soTienTamUng)
        {
            MaHD = maHD;
            TenKH = tenKH;
            ThoiGianXayDung = thoiGianXayDung;
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
            SoTienTamUng = soTienTamUng;
        }

        public abstract double PhuThu();

        public double DienTichXayDung()
        {
            return ChieuDai * ChieuRong;
        }
        public double TongTien()
        {
            return SoTienTamUng + DienTichXayDung() * NguyenNhatMinhQuan_HopDong.DonGia + PhuThu();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma hop dong: " + MaHD);
            Console.WriteLine("Ten khach hang: " + TenKH);
            Console.WriteLine("Thoi gian xay dung: " + ThoiGianXayDung);
            Console.WriteLine("Chieu dai: {0:F2}", ChieuDai);
            Console.WriteLine("Chieu rong: {0:F2}", ChieuRong);
            Console.WriteLine("Dien tich xay dung: {0:F2}", DienTichXayDung());
            Console.WriteLine("So tien tam ung: {0:N0}", SoTienTamUng);
        }
    }
}
