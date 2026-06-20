using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NhanVien nv1 = new NhanVien();
            //nv1.Xuat();
            //NhanVien nv2 = new NhanVien();
            //nv2.Nhap();
            //nv2.Xuat();
            //NhanVien nv3 = new NhanVien("NV002", "Tran Hoang Anh", 25);
            //nv3.Xuat();
            //NhanVien nv4 = new NhanVien("NV004", "Tran Hoa", 1);
            //nv4.Xuat();

            SanPhamDienTu sp1 = new SanPhamDienTu();
            sp1.Nhap();
            sp1.Xuat();
            SanPhamDienTu sp2 = new SanPhamDienTu();
            sp2.Xuat();
            SanPhamDienTu sp3 = new SanPhamDienTu(sp2);
            sp3.Xuat();
            SanPhamDienTu sp4 = new SanPhamDienTu("Ipone", "56789", "Iphone 17", 30000000, "Dien thoai di dong");
            sp4.Xuat();
            Console.ReadKey();
        }
    }
}
