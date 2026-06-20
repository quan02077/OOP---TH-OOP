using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH01
{
    internal abstract class NhanVien
    {
        string maNV;
        string hoTen;
        string ngaySinh;
        string gioiTinh;
        int soThangLamViec;
        float heSoLuong;
        public static int LuongCB = 1300000;

        protected string MaNV
        {
            get
            {
                return maNV;
            }
            set
            {
                if(value.Length == 6)
                {
                    string Chu = value.Substring(0, 2);
                    string So = value.Substring(2, 3);
                    if(Chu == "VG" && So.All(char.IsDigit))
                    {
                        maNV = value;
                    }
                }
                else
                {
                    Console.WriteLine("Ma nhan vien khong hop le!");
                    maNV = null;
                }
            }
        }

        protected string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        protected string NgaySinh
        {
            get => ngaySinh;
            set => ngaySinh = value;
        }

        protected string GioiTinh
        {
            get => gioiTinh;
            set
            {
                if(string.Compare(value, "Nam", true) == 0 || string.Compare(value, "Nu", true) == 0)
                {
                    gioiTinh = value;
                }
                else
                {
                    Console.WriteLine("Gioi tinh khong hop le!");
                    gioiTinh = null;
                }
            }
        }

        protected int SoThangLamViec
        {
            get => soThangLamViec;
            set => soThangLamViec = value;
        }

        protected float HeSoLuong
        {
            get => heSoLuong;
            set
            {
                if (value >= 2.0 && value <= 4.0)
                    heSoLuong = value;
                else
                {
                    Console.WriteLine("He so luong khong hop le!");
                    heSoLuong = 0.00f;
                }
            }
        }

        public NhanVien()
        {
            maNV = string.Empty;
            hoTen = string.Empty;
            ngaySinh = string.Empty;
            gioiTinh = string.Empty;
            soThangLamViec = 0;
            heSoLuong = 0;
        }

        public NhanVien(string maNV, string hoTen, string ngaySinh, string gioiTinh, int soThangLamViec, float heSoLuong)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoThangLamViec = soThangLamViec;
            HeSoLuong = heSoLuong;
        }

        public void Nhap()
        {
            Console.Write("Ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("Ten nhan vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            NgaySinh = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("So thang lam viec: ");
            SoThangLamViec = int.Parse(Console.ReadLine());
            Console.Write("He so luong: ");
            HeSoLuong = float.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma nhan vien: " + MaNV);
            Console.WriteLine("Ten nhan vien: " + HoTen);
            Console.WriteLine("Ngay sinh: " + NgaySinh);
            Console.WriteLine("Gioi tinh: " + GioiTinh);
            Console.WriteLine("So thang lam viec: {0}", SoThangLamViec);
            Console.WriteLine("He so luong: {0:0.00}", HeSoLuong);
        }

        public float ThamNien()
        {
            return SoThangLamViec / 12f;
        }

        public int PhuCapThamNien()
        {
            if (ThamNien() <= 3)
                return 1000000;
            else if (ThamNien() <= 6)
                return 2000000;
            else if (ThamNien() <= 10)
                return 4000000;
            else
            {
                int phuCap = 5000000;
                int namThem = (int)ThamNien() - 10;
                phuCap += namThem * 500000;
                return phuCap;
            }
        }

        public abstract char XepLoai();
        public abstract double Luong();
    }
}
