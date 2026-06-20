using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan05
{
    internal abstract class NhanVien
    {
        string maNV;
        string hoTen;
        int namSinh;
        string gioiTinh;
        float heSoLuong;
        int namVaoLam;
        public static int LuongCB = 2340000;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { 
            get => gioiTinh; set
            {
                if(string.Compare(value, "Nam", true) == 0 || string.Compare(value, "Nu", true) == 0)
                    gioiTinh = value;
                else
                {
                    Console.WriteLine("Chi co nam hoac nu!");
                    gioiTinh = "Nam";
                }
            }
        }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int NamVaoLam { get => namVaoLam; set => namVaoLam = value; }

        public NhanVien()
        {
            maNV = string.Empty;
            hoTen = string.Empty;
            namSinh = 0;
            gioiTinh= string.Empty;
            heSoLuong = 0.00f;
            NamVaoLam = 0;
        }

        public NhanVien(string maNV, string hoTen, int namSinh, string gioiTinh, float heSoLuong, int namVaoLam)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            HeSoLuong = heSoLuong;
            NamVaoLam = namVaoLam;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + HoTen);
            Console.WriteLine("Nam sinh: " + NamSinh);
            Console.WriteLine("Gioi tinh: " + GioiTinh);
            Console.WriteLine("He so luong: {0:F2}", HeSoLuong);
            Console.WriteLine("Nam vao lam: " + NamVaoLam);
        }

        public double PhuCapThamNien()
        {
            int soNamLamViec = DateTime.Now.Year - NamVaoLam;
            if (soNamLamViec >= 5)
                return (soNamLamViec / 100) * NhanVien.LuongCB;
            else
                return 0;
        }

        public abstract char XepLoai();
        public abstract double Luong();
    }
}
