using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ca_Si
{
    internal abstract class HopDong
    {
        protected string maHD;
        protected string tenCS;
        protected int soTM;
        protected DateTime ngayBD;
        protected float donGia;
        protected float phuPhi;
        public static double TiLeThue = 0.15;
        
        public string MaHD
        {
            get
            {
                return maHD;
            }
            set
            {
                if(value.Length == 6)
                {
                    string so = value.Substring(2);
                    if(value.StartsWith("HD") && so.All(char.IsDigit))
                    {
                        maHD = value;
                    }
                }
                else
                {
                    Console.WriteLine("Ma hop dong khong hop le!");
                    maHD = null;
                }
            }
        }

        public float DonGia
        {
            get
            {
                return donGia;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Don gia khong hop le!");
                    donGia = 0;
                }
                else
                    donGia = value;
            }
        }

        public HopDong()
        {
            MaHD = "HD3418";
            tenCS = "QuanThuHai";
            soTM = 3;
            ngayBD = new DateTime(2024, 03, 24);
            DonGia = 4000000;
            phuPhi = 2000000;
        }

        public HopDong(string maHD, string ten, float donGia)
        {
            MaHD = maHD;
            tenCS = ten;
            soTM = 2;
            ngayBD = new DateTime(2024, 03, 24);
            donGia = DonGia;
            phuPhi = 0;
        }

        public double ThanhTien()
        {
            return DonGia * soTM + phuPhi + PhiQuangCao();
        }

        public abstract double PhiQuangCao();

        public double Thue()
        {
            return HopDong.TiLeThue * ThanhTien();
        }

        public virtual void Xuat()
        {
            string formatted = ngayBD.ToString("dd/M/yyyy");
            Console.WriteLine("Ma hop dong: " + MaHD);
            Console.WriteLine("Ten ca si: " + tenCS);
            Console.WriteLine("So tiet muc bieu dien: " + soTM);
            Console.WriteLine("Ngay bieu dien:  " + formatted);
            Console.WriteLine("Don gia: {0:N0}", DonGia);
            Console.WriteLine("Phu phi: {0:N0}", phuPhi);
        }
    }
}
