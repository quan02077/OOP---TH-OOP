using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract04
{
    internal class HoaDonKhachHangThanThiet: HoaDon
    {
        public HoaDonKhachHangThanThiet(string maHang, string tenHang, float donGia, string maSo, string hoTen, string ngayLap, string matHang, int soLuong) : base(maHang, tenHang, donGia, maSo, hoTen, ngayLap, matHang, soLuong)
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
        public override double TienKhuyenMai()
        {
            if (SoLuong > 60)
                return 0.04 * DonGia * SoLuong;
            else if (SoLuong <= 50 && ThanhTien() >= 800000)
                return 0.03 * ThanhTien();
            else
                return 0;
        }

        public override double TriGia()
        {
            return ThanhTien() - TienKhuyenMai();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Thanh Tien: {0:N0}", ThanhTien());
            Console.WriteLine("Tien khuyen mai: {0:N0}", TienKhuyenMai());
            Console.WriteLine("Tri gia: {0:N0}", TriGia());
        }
    }
}
