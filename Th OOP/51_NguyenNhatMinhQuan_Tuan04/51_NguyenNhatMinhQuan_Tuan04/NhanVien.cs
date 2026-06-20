using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan04
{
    internal class NhanVien
    {
        string maNV;
        string tenNV;
        int namVaoLam;
        float heSoLuong;
        int soNgayNghi;

        public static int LuongCB = 2340000;
        protected string MaNV
        {
            get => maNV;
            set => maNV = value;
        }

        protected string TenNV
        {
            get => tenNV;
            set => tenNV = value;
        }

        protected int NamVaoLam
        {
            get => namVaoLam;
            set
            {
                if(namVaoLam > DateTime.Now.Year)
                {
                    Console.WriteLine("Nam vao lam khong hop le!");
                    namVaoLam = DateTime.Now.Year;
                }
                else 
                    namVaoLam = value;
            }
        }

        protected float HeSoLuong
        {
            get => heSoLuong;
            set => heSoLuong = value;
        }

        protected int SoNgayNghi
        {
            get => soNgayNghi;
            set
            {
                if (soNgayNghi > 0)
                {
                    Console.WriteLine("So ngay nghi khong hop le!");
                    soNgayNghi = 0;
                }
                else
                    soNgayNghi = value;
            }
        }

        public NhanVien()
        {
            MaNV = "0001";
            TenNV = "Nguyen Nhat Minh Quan";
            NamVaoLam = 2006;
            HeSoLuong = 2.36f;
            SoNgayNghi = 5;
        }

        public NhanVien(string maNV, string tenNV, float heSoLuong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NamVaoLam = DateTime.Now.Year;
            HeSoLuong = heSoLuong;
            SoNgayNghi = 0;
        }

        public NhanVien(string maNV, string tenNV, int namVaoLam, float heSoLuong, int soNgayNghi)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NamVaoLam = namVaoLam;
            HeSoLuong = heSoLuong;
            SoNgayNghi = soNgayNghi;
        }

        public float PhuCapThamNien()
        {
            int ThamNien = DateTime.Now.Year - NamVaoLam;

            if (ThamNien >= 5)
                return ThamNien * NhanVien.LuongCB / 100;
            else
                return 0;
        }

        public virtual char XepLoai()
        {
            if (SoNgayNghi <= 1)
                return 'A';
            else if (SoNgayNghi <= 3)
                return 'B';
            else
                return 'C';
        }

        public virtual double TinhLuong()
        {
            if (XepLoai() == 'A')
                return NhanVien.LuongCB * HeSoLuong * 1.0 + PhuCapThamNien();
            else if (XepLoai() == 'B')
                return NhanVien.LuongCB * HeSoLuong * 0.75 + PhuCapThamNien();
            else
                return NhanVien.LuongCB * HeSoLuong * 0.5 + PhuCapThamNien();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("Nam vao lam: " + NamVaoLam);
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("So ngay nghi: " + SoNgayNghi);
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Luong: {0:N0}", TinhLuong());
        }
    }
}
