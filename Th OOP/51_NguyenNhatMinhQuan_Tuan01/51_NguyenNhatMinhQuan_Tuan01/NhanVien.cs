using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan01
{
    internal class NhanVien
    {
        string maSo;
        public string MaSo
        {
            get
            {
                return maSo;
            }
            set
            {
                maSo = value;
            }
        }
        string hoTen;
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }
        int ngayCong;
        public int NgayCong
        {
            get
            {
                return ngayCong;
            }
            set
            {
                if(value >= 0)
                {
                    ngayCong = value;
                }
                else
                {
                    ngayCong = 0;
                    Console.WriteLine("So ngay cong khong hop le!");
                }
            }
        }
        public char XepLoai
        {
            get
            {
                if (NgayCong > 26)
                    return 'A';
                else if (NgayCong >= 22 && NgayCong <= 26)
                    return 'B';
                else
                    return 'C';
            }
        }
        static public int LuongNgay = 200000;
        public NhanVien()
        {
            MaSo = "0001";
            HoTen = "Nguyen Nhat Minh Quan";
            NgayCong = 23;
        }
        public NhanVien (string ms, string ht, int nc)
        {
            MaSo = ms;
            HoTen = ht;
            NgayCong = nc;
        }
        public NhanVien(NhanVien nv)
        {
            MaSo = nv.MaSo;
            HoTen = nv.HoTen;
            NgayCong = nv.NgayCong;
        }
        public void Nhap()
        {
            Console.Write("Nhap vao ma so: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap vao ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap vao so ngay cong: ");
            NgayCong = int.Parse(Console.ReadLine());
        }
        public int TinhLuong()
        {
            return NgayCong * NhanVien.LuongNgay;
        }
        public double TinhThuong()
        {
            if (XepLoai == 'A')
                return TinhLuong() * 0.05;
            else if (XepLoai == 'B')
                return TinhLuong() * 0.02;
            else
                return 0;
        }
        public void Xuat()
        {
            Console.WriteLine($"Ma so: {MaSo}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"So ngay cong: {NgayCong}");
            Console.WriteLine($"Xep loai: {XepLoai}");
            Console.WriteLine($"Luong: {TinhLuong()}");
            Console.WriteLine($"Thuong: {TinhThuong()}");
        }
    }
}
