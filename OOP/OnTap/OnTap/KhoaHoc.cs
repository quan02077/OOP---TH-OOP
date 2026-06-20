using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class KhoaHoc
    {
        string maKH;
        string tenKH;
        int soBuoi;
        string gioHoc;
        int soLuongHV;
        string giaoVien;
        static public int HocPhi = 100000;
        static public int ThuLao = 500000;
        public string MaKH
        {
            get { return maKH; }
            set
            {
                if(value.Length == 5 && value.StartsWith("KH"))
                {
                    char loai = value[2];
                    if ((loai == '1' || loai == '2' || loai == '3') && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                    {
                        maKH = value;
                    }
                }
                else
                {
                    Console.WriteLine("Ma khong hop le!");
                    maKH = null;
                }
            }
        }

        public string TenKH 
        {             
            get { return tenKH; }
            set { tenKH = value; }
        }

        public int SoBuoi
        {
            get
            {
                return soBuoi;
            }
            set
            {
                if (value > 0)
                {
                    soBuoi = value;
                }
                else
                {
                    Console.WriteLine("So buoi phai lon hon 0.");
                    soBuoi = 0;
                }
            }
        }

        public string GioHoc
        {
            get { return gioHoc; }
            set
            {
               if (string.Compare(value, "2, 4, 6", true) == 0 || string.Compare(value, "3, 5, 7", true) == 0 || string.Compare(value, "7, CN", true) == 0)
                {
                    gioHoc = value;
                }
                else
                {
                    Console.WriteLine("Gio hoc khong hop le!");
                    gioHoc = "2, 4, 6";
                }
            }
        }

        public int SoLuongHV
        {
            get { return soLuongHV; }
            set
            {
                if (value >= 10 && value <= 20)
                {
                    soLuongHV = value;
                }
                else
                {
                    Console.WriteLine("So luong hoc vien khong hop le!");
                    soLuongHV = 0;
                }
            }
        }

        public string GiaoVien
        {
            get { return giaoVien; }
            set { giaoVien = value; }
        }

        public KhoaHoc()
        {
            MaKH = "KH123";
            TenKH = "Lap trinh C#";
            SoBuoi = 10;
            GioHoc = "2, 4, 6";
            SoLuongHV = 15;
            GiaoVien = "Nguyen Van A";
        }

        public KhoaHoc(string MaKH, string TenKH, int SBuoi, string GoHoc, int SoLuongHV, string GiaoVien)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.SoBuoi = SBuoi;
            this.GioHoc = GoHoc;
            this.SoLuongHV = SoLuongHV;
            this.GiaoVien = GiaoVien;
        }
        
        public KhoaHoc(KhoaHoc kh)
        {
            MaKH = kh.MaKH;
            TenKH = kh.TenKH;
            SoBuoi = kh.SoBuoi;
            GioHoc = kh.GioHoc;
            SoLuongHV = kh.SoLuongHV;
            GiaoVien = kh.GiaoVien;
        }

        public double TinhHocPhi()
        {
            if(GioHoc == "2, 4, 6" || GioHoc == "3, 5, 7")
            {
                return SoBuoi * KhoaHoc.HocPhi;
            }
            else
            {
                return SoBuoi * KhoaHoc.HocPhi * 1.2;
            }
        }

        public int TinhThuLao()
        {
            if (SoLuongHV > 15)
            {
                return SoBuoi * (KhoaHoc.ThuLao + 10000);
            }
            return SoBuoi * KhoaHoc.ThuLao;
        }

        public void Nhap()
        {
            Console.Write("Ma khoa hoc: ");
            MaKH = Console.ReadLine();
            Console.Write("Ten khoa hoc: ");
            TenKH = Console.ReadLine();
            Console.Write("So buoi: ");
            SoBuoi = int.Parse(Console.ReadLine());
            Console.Write("Gio hoc: ");
            GioHoc = Console.ReadLine();
            Console.Write("So luong hoc vien: ");
            SoLuongHV = int.Parse(Console.ReadLine());
            Console.Write("Giao vien giang day: ");
            GiaoVien = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma khoa hoc: {MaKH}");
            Console.WriteLine($"Ten khoa hoc: {TenKH}");
            Console.WriteLine($"So buoi: {SoBuoi}");
            Console.WriteLine($"Gio hoc: {GioHoc}");
            Console.WriteLine($"So luong hoc vien: {SoLuongHV}");
            Console.WriteLine($"Giao vien giang day: {GiaoVien}");
            Console.WriteLine($"Hoc phi cua khoa hoc: {HocPhi}");
            Console.WriteLine($"Hoc phi 1 buoi hoc: {TinhHocPhi()}");
            Console.WriteLine($"Thu lao 1 buoi: {ThuLao}");
            Console.WriteLine($"So tien giao vien nhan duoc khi ket thuc khoa hoc: {TinhThuLao()}");
        }
    }
}
