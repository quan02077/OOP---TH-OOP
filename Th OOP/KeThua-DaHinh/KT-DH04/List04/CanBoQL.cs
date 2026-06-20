using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04
{
    internal class CanBoQL: NhanVien
    {
        string chucVu;
        int thamNienQL;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int ThamNienQL { get => thamNienQL; set => thamNienQL = value; }

        public CanBoQL()
        {
            MaNV = "NV009";
            TenNV = "Dieu Hien";
            HeSoLuong = 4.67f;
            ChucVu = "Giam doc";
            ThamNienQL = 10;
        }

        public override double TinhThuNhap()
        {
            if (string.Compare(ChucVu, "Giam doc", true) == 0)
                return base.TinhThuNhap() * 1500000 * 7.0;
            else if (string.Compare(ChucVu, "Truong phong", true) == 0)
                return base.TinhThuNhap() * 1500000 * 6.0;
            else if (string.Compare(ChucVu, "Pho phong", true) == 0)
                return base.TinhThuNhap() * 1500000 * 4.5;
            else
                return base.TinhThuNhap() * 1.0;
        }

        public override void Xuat()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("Chuc vu: " + ChucVu);
            Console.WriteLine("Tham nien quan ly: " + ThamNienQL);
            Console.WriteLine("Thu nhap cua can bo lanh dao: " + TinhThuNhap());
        }
    }
}
