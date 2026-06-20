using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH01
{
    internal class CanBoQuanLy: NhanVien
    {
        string chucVu;
        float heSoCV;

        public void NhapCV()
        {
            Console.Write("Chuc vu: ");
            chucVu = Console.ReadLine();
            Console.Write("He so chuc vu: ");
            heSoCV = float.Parse(Console.ReadLine());
        }

        public override char XepLoai()
        {
            return 'A';
        }

        public override double Luong()
        {
            float phuCapCV = heSoCV * 2000000;
            return 1 * ((HeSoLuong * NhanVien.LuongCB + phuCapCV) + PhuCapThamNien());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Luong: {0:N0}", Luong());
        }
    }
}
