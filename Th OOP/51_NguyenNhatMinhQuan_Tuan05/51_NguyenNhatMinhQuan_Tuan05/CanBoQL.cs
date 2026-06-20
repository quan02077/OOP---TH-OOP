using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan05
{
    internal class CanBoQL: NhanVien
    {
        string chucVu;
        float heSoCV;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public float HeSoCV { get => heSoCV; set => heSoCV = value; }

        public CanBoQL(string maNV, string hoTen, int namSinh, string gioiTinh, float heSoLuong, int namVaoLam, string chucVu, float heSoCV) : base(maNV, hoTen, namSinh, gioiTinh, heSoLuong, namVaoLam)
        {
            ChucVu = chucVu;
            HeSoCV = heSoCV;
        }

        public override char XepLoai()
        {
            return 'A';
        }

        public override double Luong()
        {
            float phuCapCV = HeSoCV * 1350;
            return 1 * (HeSoLuong * NhanVien.LuongCB + phuCapCV) + PhuCapThamNien();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chuc vu: " + ChucVu);
            Console.WriteLine("He so chuc: {0:F2}", HeSoCV);
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Luong: {0:N0}", Luong());
        }
    }
}
