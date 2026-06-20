using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class CanBoQL: NhanVien
    {
        string chucVu;
        float heSoCV;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public float HeSoCV { get => heSoCV; set => heSoCV = value; }

        public CanBoQL()
        {
            ChucVu = "TP";
            HeSoCV = 3.33f;
        }

        public CanBoQL(string maNV, string tenNV, float heSoLuong, string phongBan, int soNgayLam, string chucVu, float heSoCV) : base(maNV, tenNV, heSoLuong, phongBan, soNgayLam)
        {
            ChucVu = chucVu;
            HeSoCV = heSoCV;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("He so chuc vu: ");
            HeSoCV = float.Parse(Console.ReadLine());
        }

        public override float Luong()
        {
            return base.Luong() + HeSoCV * 1100;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chuc vu: " + ChucVu);
            Console.WriteLine("He so chuc vu: " + HeSoCV);
            Console.WriteLine("Luong (QL): " + Luong());
        }
    }
}
