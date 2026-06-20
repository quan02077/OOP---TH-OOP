using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan05
{
    internal class NhanVienSX: NhanVien
    {
        public static float HeSoPhuCapNangNhoc = 0.01f;
        int soNgayNghi;

        public int SoNgayNghi { get => soNgayNghi; set => soNgayNghi = value; }

        public NhanVienSX(string maNV, string hoTen, int namSinh, string gioiTinh, float heSoLuong, int namVaoLam, int sonn): base(maNV, hoTen, namSinh, gioiTinh, heSoLuong, namVaoLam)
        {
            SoNgayNghi = sonn;
        }
        public override char XepLoai()
        {
            if (SoNgayNghi <= 1)
                return 'A';
            else if (SoNgayNghi <= 3)
                return 'B';
            else if (SoNgayNghi <= 5)
                return 'C';
            else
                return 'D';
        }

        public override double Luong()
        {
            if (XepLoai() == 'A')
                return 1 * (HeSoLuong * NhanVien.LuongCB * (1 + HeSoPhuCapNangNhoc)) + PhuCapThamNien();
            else if (XepLoai() == 'B')
                return 0.75 * (HeSoLuong * NhanVien.LuongCB * (1 + HeSoPhuCapNangNhoc)) + PhuCapThamNien();
            else if (XepLoai() == 'C')
                return 0.5 * (HeSoLuong * NhanVien.LuongCB * (1 + HeSoPhuCapNangNhoc)) + PhuCapThamNien();
            else
                return (HeSoLuong * NhanVien.LuongCB * (1 + HeSoPhuCapNangNhoc)) + PhuCapThamNien();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So ngay nghi: " + SoNgayNghi);
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Luong: {0:N0}", Luong());
        }
    }
}
