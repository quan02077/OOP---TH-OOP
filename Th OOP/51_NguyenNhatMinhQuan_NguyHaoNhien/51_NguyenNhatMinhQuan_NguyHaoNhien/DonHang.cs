using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_NguyHaoNhien
{
    internal class DonHang
    {
        string maDH;
        string tenSP;
        string loaiSP;
        int soLuong;
        double donGia;
        DateTime ngayDatHang;
        double phiVanChuyen;
        public static double PhuPhiCoBan = 5000;
        public string MaDH
        {
            get
            {
                return maDH;
            }
            set
            {
                if (value.Length == 8 && value.StartsWith("DH"))
                {
                    maDH = value;
                }
                else
                {
                    Console.WriteLine("Ma don hang khong hop le!");
                    maDH = "DH000000";
                }
            }
        }

        public string TenSP
        {
            get
            {
                return tenSP;
            }
            set
            {
                if(value.Length <= 40)
                {
                    tenSP = value;
                }
                else
                {
                    Console.WriteLine("Ten san pham khong hop le!");
                    tenSP = null;
                }
            }
        }

        public string LoaiSP
        {
            get
            {
                return loaiSP;
            }
            set
            {
                if(string.Compare(value, "Dien tu", true) == 0 || string.Compare(value, "Thoi trang", true) == 0 || string.Compare(value, "Gia dung", true) == 0)
                {
                    loaiSP = value;
                }
                else
                {
                    Console.WriteLine("Loai san pham khong hop le!");
                    loaiSP = "Gia dung";
                }
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("So luong khong hop le!");
                    soLuong = 1;
                }
                else
                {
                    soLuong = value;
                }
            }
        }

        public double DonGia
        {
            get
            {
                return donGia;
            }
            set
            {
                if(value < 50000)
                {
                    donGia = 50000;
                }
                else
                {
                    donGia = value;
                }
            }
        }

        public DateTime NgayDatHang
        {
            get
            {
                return ngayDatHang;
            }
            set
            {
                ngayDatHang = value;
            }
        }

        public double PhiVanChuyen
        {
            get
            {
                return phiVanChuyen;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Phi van chuyen khong hop le!");
                    phiVanChuyen = 20000;
                }
                else
                {
                    phiVanChuyen = value;
                }
            }
        }

        public DonHang()
        {
            MaDH = "DH000001";
            TenSP = "May tinh Acer";
            LoaiSP = "Dien tu";
            SoLuong = 1;
            DonGia = 10000000;
            NgayDatHang = DateTime.Now;
            PhiVanChuyen = 50000;
        }
        
        public DonHang(string maDH, string tenSP, string loaiSP, int soLuong, double donGia, DateTime ngayDatHang, double phiVanChuyen)
        {
            MaDH = maDH;
            TenSP = tenSP;
            LoaiSP = loaiSP;
            SoLuong = soLuong;
            DonGia = donGia;
            NgayDatHang = ngayDatHang;
            PhiVanChuyen = phiVanChuyen;
        }

        public double PhuPhiSP()
        {
            if(string.Compare(LoaiSP,"Dien tu", true) == 0)
            {
                return (SoLuong * DonHang.PhuPhiCoBan) + 100000;
            }
            else
            {
                return SoLuong * DonHang.PhuPhiCoBan;
            }
        }

        public double TongTien()
        {
            return (SoLuong * DonGia) + PhiVanChuyen + PhuPhiSP();
        }

        public double GiamGia()
        {
            if(SoLuong >= 10)
            {
                return TongTien() * 0.05;
            }
            else if((SoLuong * DonGia) >= 5000000)
            {
                return TongTien() * 0.03;
            }
            else
            {
                return 0;
            }
        }


        public void Xuat()
        {
            Console.WriteLine("Ma don hang: "+MaDH);
            Console.WriteLine("Ten don hang: " + TenSP);
            Console.WriteLine("Loai san pham: " + LoaiSP);
            Console.WriteLine("So luong san pham: " + SoLuong);
            Console.WriteLine("Don gia san pham: {0:N0}", DonGia);
            Console.WriteLine("Ngay dat hang: " + NgayDatHang);
            Console.WriteLine("Phi van chuyen: {0:N0}",PhiVanChuyen);
            Console.WriteLine("Tong tien don hang: {0:N0}", TongTien());
            Console.WriteLine();
        }
    }
}
