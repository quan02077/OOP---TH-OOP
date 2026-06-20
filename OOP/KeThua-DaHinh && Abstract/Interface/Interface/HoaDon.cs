using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal abstract class HoaDon
    {
        string maHD;
        string tenGach;
        float chieuDai;
        float chieuRong;
        int soLuong;
        float donGia;
        public static float VAT = 0.1f;

        protected string MaHD 
        { 
            get => maHD; 
            set
            {
                if (value.Length == 6 && value.StartsWith("HD"))
                { 
                    string so = value.Substring(2);
                    if (so.All(char.IsDigit))
                        maHD = value;
                }
                else
                {
                    maHD = null;
                }
            }
        }
        protected string TenGach { get => tenGach; set => tenGach = value; }
        protected float ChieuDai { get => chieuDai; set => chieuDai = value; }
        protected float ChieuRong { get => chieuRong; set => chieuRong = value; }
        protected int SoLuong 
        {
            get => soLuong; 
            set
            {
                if (value <= 10)
                    soLuong = 0;
                else
                    soLuong = value;
            }
        }
        protected float DonGia { get => donGia; set => donGia = value; }

        public HoaDon()
        {
            MaHD = "HD0001";
            TenGach = "Op tuong phong khach";
            ChieuDai = 60;
            ChieuRong = 40;
            SoLuong = 1200;
            DonGia = 60000;
        }

        public HoaDon(string maHD, string tenGach, int soLuong)
        {
            MaHD = maHD;
            TenGach = tenGach;
            ChieuDai = 60;
            ChieuRong = 60;
            SoLuong = soLuong;
            DonGia = 35000;
        }

        public virtual void Nhap()
        {
            Console.Write("Ma hoa don: ");
            MaHD = Console.ReadLine();
            Console.Write("Ten gach bong: ");
            TenGach = Console.ReadLine();
            Console.Write("Chieu dai: ");
            ChieuDai = float.Parse(Console.ReadLine());
            Console.Write("Chieu rong: ");
            ChieuRong = float.Parse(Console.ReadLine());
            Console.Write("So luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Don gia: ");
            DonGia = float.Parse(Console.ReadLine());
        }

        public abstract double GiamGia();
        public double ThanhTien()
        {
            return (SoLuong * DonGia) - GiamGia();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma hoa don: " + MaHD);
            Console.WriteLine("Ten gach bong: " + TenGach);
            Console.WriteLine("Chieu dai {0:0.00}", ChieuDai);
            Console.WriteLine("Chieu rong: {0:0.00}", ChieuRong);
            Console.WriteLine("So luong: " + SoLuong);
            Console.WriteLine("Don gia: {0:0.00}", DonGia);
        }

        public abstract double ThueNK();

        public double Thue()
        {
            return HoaDon.VAT * ThanhTien() + ThueNK();
        }
    }
}
