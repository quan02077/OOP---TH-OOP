using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH01
{
    internal class NhanVienSanXuat: NhanVien
    {
        public static float heSoPhuCapNangNhoc = 0.1f;
        int soNgayNghi;
        
        public void NhapNN()
        {
            Console.Write("Ngay nghi: ");
            soNgayNghi = int.Parse(Console.ReadLine());
        }
        public override char XepLoai()
        {
            if (soNgayNghi <= 1)
                return 'A';
            else if (soNgayNghi <= 3)
                return 'B';
            else if (soNgayNghi <= 5)
                return 'C';
            else
                return 'D';
        }

        public override double Luong()
        {
            if (XepLoai() == 'A')
                return 1 * ((HeSoLuong * NhanVien.LuongCB * (1 + 0.1)) + PhuCapThamNien());
            else if (XepLoai() == 'B')
                return 0.75 * ((HeSoLuong * NhanVien.LuongCB + (1 + 0.1)) + PhuCapThamNien());
            else if (XepLoai() == 'C')
                return 0.5 * ((HeSoLuong * NhanVien.LuongCB * (1 + 0.1)) + PhuCapThamNien());
            else
                return (HeSoLuong * NhanVien.LuongCB * (1 + 0.1)) + PhuCapThamNien();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Luong: {0:N0}", Luong());
        }
    }
}
