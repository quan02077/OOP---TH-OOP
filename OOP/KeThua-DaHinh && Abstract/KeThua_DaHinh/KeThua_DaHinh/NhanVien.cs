using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class NhanVien
    {
        protected string maNV;
        protected string tenNV;
        protected float heSoLuong;
        protected string phongBan;
        protected int soNgayLam;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public int SoNgayLam { get => soNgayLam; set => soNgayLam = value; }

        public NhanVien()
        {
            MaNV = "0001";
            TenNV = "Peter Griffin";
            HeSoLuong = 3.36f;
            PhongBan = "Ke toan";
            SoNgayLam = 26;
        }

        public NhanVien(string maNV, string tenNV, float heSoLuong, string phongBan, int soNgayLam)
        {
            MaNV = maNV;
            TenNV = tenNV;
            HeSoLuong = heSoLuong;
            PhongBan = phongBan;
            SoNgayLam = soNgayLam;
        }

        public string XepLoai()
        {
            if (SoNgayLam > 25)
                return "Loai A";
            else if (SoNgayLam > 22)
                return "Loai B";
            else
                return "Loai C";
        }

        public float HeSoThiDua()
        {
            if (XepLoai() == "Loai A")
                return 1.00f;
            else if (XepLoai() == "Loai B")
                return 0.75f;
            else
                return 0.50f;
        }

        public virtual float Luong()
        {
            return 1210 * HeSoLuong * HeSoThiDua();
        }

        public virtual void Nhap()
        {
            Console.Write("Ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("Ten nhan vien: ");
            TenNV = Console.ReadLine();
            Console.Write("He so luong: ");
            HeSoLuong = float.Parse(Console.ReadLine());
            Console.Write("Phong ban: ");
            PhongBan = Console.ReadLine();
            Console.Write("So ngay lam: ");
            SoNgayLam = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Phong ban: " + PhongBan);
            Console.WriteLine("So ngay lam: " + SoNgayLam);
            Console.WriteLine("Luong: " + Luong());
        }
    }
}
