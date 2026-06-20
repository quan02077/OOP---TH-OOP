using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan04
{
    internal class CanBoLanhDao: NhanVien
    {
        string chucVu;
        string phongBan;
        float heSoPhuCap;

        public string ChucVu
        {
            get => chucVu;
            set
            {
                if(string.Compare(value, "Giam doc", true) == 0 || string.Compare(value, "Pho giam doc", true) == 0 || string.Compare(value, "Truong phong", true) == 0 || string.Compare(value, "Pho truong phong", true) == 0)
                    chucVu = value;
                else
                {
                    Console.WriteLine("Chuc vu khong hop le!");
                    chucVu = null;
                }
            }
        }

        public string PhongBan { get => phongBan; set => phongBan = value; }
        public float HeSoPhuCap { get => heSoPhuCap; set => heSoPhuCap = value; }

        public CanBoLanhDao()
        {
            ChucVu = "Truong phong";
            PhongBan = "Hanh chinh";
            HeSoPhuCap = 5.0f;
        }

        public CanBoLanhDao(string maNV, string tenNV, float heSoLuong, string chucVu, float heSoPhuCap): base(maNV, tenNV, DateTime.Now.Year, heSoLuong, 1)
        {
            ChucVu = chucVu;
            PhongBan = "Hanh chinh";
            HeSoPhuCap = heSoPhuCap;
        }

        public CanBoLanhDao(string maNV, string tenNV, int namVaoLam, float heSoLuong, int soNgayNghi, string chucVu, string phongBan, float heSoPhuCap): base(maNV, tenNV, namVaoLam, heSoLuong, soNgayNghi)
        {
            ChucVu = chucVu;
            PhongBan = phongBan;
            HeSoPhuCap = heSoPhuCap;
        }

        public override char XepLoai()
        {
            return 'A';
        }

        public double TinhPCLD()
        {
            return HeSoPhuCap * NhanVien.LuongCB;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() + TinhPCLD();
        }

        public override void Xuat()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + TenNV);
            Console.WriteLine("Nam vao lam: " + NamVaoLam);
            Console.WriteLine("He so luong: " + HeSoLuong);
            Console.WriteLine("So ngay nghi: " + SoNgayNghi);
            Console.WriteLine("Xep loai: " + XepLoai());
            Console.WriteLine("Chuc vu: " + ChucVu);
            Console.WriteLine("Phong ban: " + PhongBan);
            Console.WriteLine("He so phu cap lanh dao: " + HeSoPhuCap);
            Console.WriteLine("Luong cua can bo: {0:N0}", TinhLuong());
        }
    }
}
