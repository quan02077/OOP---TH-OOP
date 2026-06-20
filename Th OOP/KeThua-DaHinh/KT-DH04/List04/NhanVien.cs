using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04
{
    internal class NhanVien
    {
        string maNV;
        string tenNV;
        float heSoLuong;
        public static int LuongCB = 2340000;
        protected string MaNV
        {
            get
            {
                return maNV;
            }
            set
            {
                if(value.StartsWith("NV"))
                    maNV = value;
                else
                {
                    Console.WriteLine("Ma nhan vien khong hop le!");
                    maNV = "NV001";
                }
            }
        }
        protected string TenNV { get => tenNV; set => tenNV = value; }
        protected float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

        public NhanVien()
        {
            MaNV = "NV001";
            TenNV = "Nguyen Nhat Minh Quan";
            HeSoLuong = 2.34f;
        }

        public NhanVien(string maNV, string tenNV, float heSoLuong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            HeSoLuong = heSoLuong;
        }

        public virtual double TinhThuNhap()
        {
            return HeSoLuong * NhanVien.LuongCB;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Thu nhap cua nhan vien: " + TinhThuNhap());
        }
    }
}
