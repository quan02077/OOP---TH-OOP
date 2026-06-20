using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan02
{
    internal class NhanVien
    {
        string maNV;
        string tenNV;
        float heSoLuong;
        int namVaoLam;
        public static int MucLuongToiThieu = 2340000;
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }

        public float HeSoLuong
        {
            get
            {
                return heSoLuong;
            }
            set
            {
                if(value > 0)
                {
                    heSoLuong = value;
                }
                else
                {
                    Console.WriteLine("He so luong khong hop le");
                    heSoLuong = 0;
                }
            }
        }

        public int NamVaoLam
        {
            get
            {
                return namVaoLam;
            }
            set
            {
                if(value <= 0 || value > DateTime.Today.Year)
                    namVaoLam = DateTime.Today.Year;
                else
                {
                    namVaoLam = value;
                }
            }
        }

        public NhanVien()
        {
            MaNV = "1234";
            TenNV = "Phung Thanh Do";
            HeSoLuong = 5.55f;
            NamVaoLam = 2021;
        }

        public NhanVien(string maNV, string tenNV, float heSoLuong, int namVaoLam)
        {
            MaNV = maNV;
            TenNV = tenNV;
            HeSoLuong = heSoLuong;
            NamVaoLam = namVaoLam;
        }

        public NhanVien(NhanVien nv)
        {
            MaNV = nv.MaNV;
            TenNV = nv.TenNV;
            HeSoLuong = nv.HeSoLuong;
            NamVaoLam = nv.NamVaoLam;
        }

        public float LuongCoBan()
        {
            return HeSoLuong * NhanVien.MucLuongToiThieu;
        }

        public float HeSoPhuCap()
        {
            return (DateTime.Today.Year - NamVaoLam)/100.0f;
        }

        public float LuongNV()
        {
            return LuongCoBan() * (1 + HeSoPhuCap());
        }

        public void Nhap()
        {
            Console.Write("Ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("Ten nhan vien: ");
            TenNV = Console.ReadLine();
            Console.Write("He so luong: ");
            HeSoLuong = float.Parse(Console.ReadLine());
            Console.Write("Nam vao lam: ");
            NamVaoLam = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma nhan vien: {0}", MaNV);
            Console.WriteLine("Ten nhan vien: {0}", TenNV);
            Console.WriteLine("He so luong cua nhan vien: {0}", HeSoLuong);
            Console.WriteLine("Nam vao lam cua nhan vien: {0}", NamVaoLam);
            Console.WriteLine("Luong cua nhan vien: {0:N0}", LuongNV());
        }
    }
}
