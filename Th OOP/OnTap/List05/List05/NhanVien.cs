using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List05
{
    internal class NhanVien
    {
        string maNhanVien;
        string tenNhanVien;
        string phongBan;
        string chucVu;
        float heSoLuong;
        int thamNienCongTac;
        int soNgayLam;
        static public int LuongCoBan = 2340000;
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }

        public string ChucVu
        {
            get {  return chucVu;}
            set
            {
                if(string.Compare(value, "Lanh dao", true) == 0 || string.Compare(value, "Nhan vien", true) == 0)
                {
                    chucVu = value;
                }
                else
                {
                    Console.WriteLine("Chuc vu nhap vao khong hop le");
                    chucVu = null;
                }
            }
        }

        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int ThamNienCongTac { get => thamNienCongTac; set => thamNienCongTac = value; }
        public int SoNgayLam { get => soNgayLam; set => soNgayLam = value; }

        public NhanVien()
        {
            MaNhanVien = "001";
            TenNhanVien = "Minh Quan";
            PhongBan = "Quan ly";
            ChucVu = "Lanh dao";
            HeSoLuong = 5.75f;
            ThamNienCongTac = 20;
            SoNgayLam = 29;
        }
        public NhanVien(string maNhanVien, string tenNhanVien, string phongBan, string chucVu, float heSoLuong, int thamNienCongTac, int soNgaylam)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            PhongBan = phongBan;
            ChucVu = chucVu;
            HeSoLuong = heSoLuong;
            ThamNienCongTac = thamNienCongTac;
            SoNgayLam = soNgaylam;
        }

        public float HeSoThiDua()
        {
            if (string.Compare(ChucVu, "Lanh dao", true) == 0)
                return 1.0f;
            else if (string.Compare(ChucVu, "Nhan vien", true) == 0)
            {
                if (SoNgayLam >= 22)
                    return 1.0f;
                else if (SoNgayLam >= 20)
                    return 0.8f;
                else
                    return 0.6f;
            }
            else
                return 0;
        }


        public int PhuCap()
        {
            if (ChucVu == "Lanh dao")
                return 1350000;
            else
            {
                return 0;
            }
        }

        public float Luong()
        {
            return HeSoLuong * LuongCoBan * HeSoThiDua() + 1100000 + PhuCap();
        }

        public void Nhap()
        {
            Console.Write("Ma nhan vien: ");
            MaNhanVien = Console.ReadLine();
            Console.Write("Ten nhan vien: ");
            TenNhanVien = Console.ReadLine();
            Console.Write("Phong ban: ");
            PhongBan = Console.ReadLine();
            Console.Write("Chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("He so luong: ");
            HeSoLuong = float.Parse(Console.ReadLine());
            Console.Write("Tham nien cong tac: ");
            ThamNienCongTac = int.Parse(Console.ReadLine());
            Console.Write("So ngay lam viec trong thang: ");
            SoNgayLam = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma nhan vien: {0}", MaNhanVien);
            Console.WriteLine("Ten nhan vien: {0}", TenNhanVien);
            Console.WriteLine("Phong ban: {0}", PhongBan);
            Console.WriteLine("Chuc vu: {0}", ChucVu);
            Console.WriteLine("He so luong: {0}", HeSoLuong);
            Console.WriteLine("Tham nien cong tac: {0}", ThamNienCongTac);
            Console.WriteLine("So ngay lam viec trong thang: {0}",SoNgayLam);
            Console.WriteLine("Luong: {0}", Luong());
        }
    }
}
