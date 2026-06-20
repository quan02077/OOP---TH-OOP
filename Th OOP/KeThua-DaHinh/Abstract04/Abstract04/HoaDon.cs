
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract04
{
    internal abstract class HoaDon
    {
        string maHang;
        string tenHang;
        float donGia;
        string maSo;
        string hoTen;
        string ngayLap;
        string matHang;
        int soLuong;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MatHang { get => matHang; set => matHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public HoaDon()
        {
            maHang = string.Empty;
            tenHang = string.Empty;
            donGia = 0.00f;
            maSo = string.Empty;
            hoTen = string.Empty;
            ngayLap = string.Empty;
            matHang = string.Empty;
            soLuong = 0;

        }

        public HoaDon(string maHang, string tenHang, float donGia, string maSo, string hoTen, string ngayLap, string matHang, int soLuong)
        {
            MaHang = maHang;
            TenHang = tenHang;
            DonGia = donGia;
            MaSo = maSo;
            HoTen = hoTen;
            NgayLap = ngayLap;
            MatHang = matHang;
            SoLuong = soLuong;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma so: " + maSo);
            Console.WriteLine("Ho ten khach: " + HoTen);
            Console.WriteLine("Ngay lap: " + NgayLap);
            Console.WriteLine("Mat hang: " + MatHang);
            Console.WriteLine("So luong: " + SoLuong);
        }

        public abstract double TienKhuyenMai();
        public double ThanhTien()
        {
            return SoLuong * DonGia;
        }
        public abstract double TriGia();
    }
}
