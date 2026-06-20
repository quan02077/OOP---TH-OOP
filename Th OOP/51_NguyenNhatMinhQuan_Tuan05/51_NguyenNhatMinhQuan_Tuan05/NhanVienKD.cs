using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan05
{
    internal class NhanVienKD: NhanVien
    {
        int doanhSoBanHang;
        int doanhSoToiThieu;

        public int DoanhSoBanHang { get => doanhSoBanHang; set => doanhSoBanHang = value; }
        public int DoanhSoToiThieu { get => doanhSoToiThieu; set => doanhSoToiThieu = value; }

        public NhanVienKD(string maNV, string hoTen, int namSinh, string gioiTinh, float heSoLuong, int namVaoLam, int dsbn, int dstt) : base(maNV, hoTen, namSinh, gioiTinh, heSoLuong, namVaoLam)
        {
            DoanhSoBanHang = dsbn;
            DoanhSoToiThieu = dstt;
        }
        public override char XepLoai()
        {
            if (DoanhSoBanHang < 0.5 * DoanhSoToiThieu)
                return 'D';
            else if (DoanhSoBanHang < DoanhSoToiThieu)
                return 'C';
            else if (DoanhSoBanHang > 2 * DoanhSoToiThieu)
                return 'A';
            else
                return 'B';
        }

        public override double Luong()
        {
            double hoaHong = 0.00f;
            if (DoanhSoBanHang > DoanhSoToiThieu)
                hoaHong =  0.15 * (DoanhSoBanHang - DoanhSoToiThieu);
            else
                hoaHong = 0;

            if (XepLoai() == 'A')
                return 1 * (HeSoLuong * NhanVien.LuongCB + hoaHong) + PhuCapThamNien();
            else if (XepLoai() == 'B')
                return 0.75 * (HeSoLuong * NhanVien.LuongCB + hoaHong) + PhuCapThamNien();
            else if (XepLoai() == 'C')
                return 0.5 * (HeSoLuong * NhanVien.LuongCB + hoaHong) + PhuCapThamNien();
            else 
                return (HeSoLuong * NhanVien.LuongCB + hoaHong) + PhuCapThamNien();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Doanh so ban hang thuc te: " + DoanhSoBanHang);
            Console.WriteLine("Doanh so toi thieu: " + DoanhSoToiThieu);
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Luong: {0:N0}", Luong());
        }
    }
}
