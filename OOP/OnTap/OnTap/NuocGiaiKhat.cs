using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class NuocGiaiKhat
    {
        string tenHang;
        string donViTinh;
        int soLuong;
        float donGia;
        static public double VAT = 0.1;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }
            set
            {
                if(string.Compare(value,"Ket", true) == 0 || string.Compare(value, "Thung",true) == 0 || string.Compare(value,"Chai", true) == 0 || string.Compare(value, "Lon", true) == 0)
                {
                    donViTinh = value;
                }
                else
                {
                    Console.WriteLine("Don vi tinh khong hop le. Chi chap nhan Ket, Thung hoac Chai.");
                    donViTinh = "Ket";
                }
            }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if(value >= 0)
                {
                    soLuong = value;
                }
                else
                {
                    Console.WriteLine("So luong khong hop le. So luong phai lon hon hoac bang 0.");
                    soLuong = 0;
                }
            }
        }

        public float DonGia
        {
            get { return donGia; }
            set
            {
                if(value >= 0)
                {
                    donGia = value;
                }
                else
                {
                    Console.WriteLine("Don gia khong hop le. Don gia phai lon hon hoac bang 0.");
                    donGia = 0;
                }
            }
        }

        public NuocGiaiKhat()
        {
            TenHang = "Tiger";
            DonViTinh = "Ket";
            SoLuong = 30;
            DonGia = 150000;
        }

        public NuocGiaiKhat(string TenHang, string DonViTinh, int SoLuong, float DonGia)
        {
            this.TenHang = TenHang;
            this.DonViTinh = DonViTinh;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }

        public double ThanhTien()
        {
            if(DonViTinh == "Ket" || DonViTinh == "Thung")
            {
                return SoLuong * DonGia * (1+ VAT);
            }
            else if(DonViTinh == "Chai")
            {
                return SoLuong * (DonGia / 20) * (1 + VAT);
            }
            else
            {
                return SoLuong * (DonGia / 24) * (1 + VAT);
            }
        }

        public void Nhap()
        {
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap don vi tinh (Ket, Thung, Chai, Lon): ");
            DonViTinh = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            DonGia = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ten hang: {0}", TenHang);
            Console.WriteLine("Don vi tinh: {0}", DonViTinh);
            Console.WriteLine("So luong: {0}", SoLuong);
            Console.WriteLine("Don gia: {0}", DonGia);
            Console.WriteLine("Thanh tien: {0}", ThanhTien());
        }
    }
}
