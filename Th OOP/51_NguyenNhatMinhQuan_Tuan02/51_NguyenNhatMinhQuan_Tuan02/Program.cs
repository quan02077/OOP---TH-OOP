using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NhanVien nv1 = new NhanVien();
            //nv1.Xuat();

            //NhanVien nv2 = new NhanVien("6789", "Phan Tan Trung", 2.34f, 2022);
            //nv2.Xuat();

            //NhanVien nv3 = new NhanVien();
            //nv3.Nhap();
            //nv3.Xuat();

            CongTy ct1 = new CongTy();
            //ct1.NhapDSNV();
            ct1.DocFileXML(@"..\..\congty.xml");
            ct1.XuatDSNV();
            Console.WriteLine("Tong luong nhan vien la: {0:N0}", ct1.TongLuong());
            NhanVien nvMax = ct1.TimNVMaxLuong();
            nvMax.Xuat();

            CongTy dsSapXep = ct1.DSNVSort();
            dsSapXep.XuatDSNV();

            Console.ReadKey();
        }
    }
}
