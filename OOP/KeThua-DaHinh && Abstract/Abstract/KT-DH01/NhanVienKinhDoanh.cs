using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH01
{
    internal class NhanVienKinhDoanh: NhanVien
    {
        int doanhSoBanHang;
        int doanhSoToiThieu;
        public void NhapDS()
        {
            Console.Write("Doanh so toi thieu cua thang: ");
            doanhSoToiThieu = int.Parse(Console.ReadLine());
            Console.Write("Doanh so ban hang cua thang: ");
            doanhSoBanHang = int.Parse(Console.ReadLine());
        }
        public override char XepLoai()
        {
            if (doanhSoBanHang < 0.5 * doanhSoToiThieu)
                return 'D';
            else if (doanhSoBanHang < doanhSoToiThieu)
                return 'C';
            else if (doanhSoBanHang > 2 * doanhSoToiThieu)
                return 'A';
            else
                return 'B';
        }

        public override double Luong()
        {
            double hoaHong = 0;
            if (doanhSoBanHang > doanhSoToiThieu)
            {
                hoaHong = 0.15 * (doanhSoBanHang - doanhSoToiThieu);
            }
            else
                hoaHong = 0;

            if (XepLoai() == 'A')
                return 1 * ((HeSoLuong * NhanVien.LuongCB + hoaHong) + PhuCapThamNien());
            else if (XepLoai() == 'B')
                return 0.75 * ((HeSoLuong * NhanVien.LuongCB + hoaHong) + PhuCapThamNien());
            else if (XepLoai() == 'C')
                return 0.5 * ((HeSoLuong * NhanVien.LuongCB +hoaHong) + PhuCapThamNien());
            else
                return (HeSoLuong * NhanVien.LuongCB + hoaHong) + PhuCapThamNien();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Luong: {0:N0}", Luong());
        }
    }
}
