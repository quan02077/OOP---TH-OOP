using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List06
{
    internal class ChiTietBH
    {
        string maSP;
        string tenSP;
        float giaBan;
        int soLuong;
        public static float TiLeThue = 0.1f;

        public string MaSP
        {
            get
            {
                return maSP;
            }
            set
            {
                if(value.StartsWith("SP") && value.Length == 6)
                {
                    maSP = value;
                }
                else
                {
                    Console.WriteLine("Ma san pham khong hop le!");
                    maSP = "SP0000";
                }
            }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public float GiaBan
        {
            get { return  giaBan; }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Gia ban khong hop le!");
                    giaBan = 0;
                }
                else
                {
                    giaBan = value;
                }
            }
        }

        public int SoLuong
        {
            get{ return soLuong; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("So luong khong hop le!");
                    soLuong = 0;
                }
                else
                {
                    soLuong= value;
                }
            }
        }

        public ChiTietBH()
        {
            MaSP = "SP0010";
            TenSP = "May tinh Dell";
            GiaBan = 15.000f;
            SoLuong = 2;
        }

        public ChiTietBH(ChiTietBH ct)
        {
            MaSP = ct.MaSP;
            TenSP = ct.TenSP;
            GiaBan = ct.GiaBan;
            SoLuong = ct.SoLuong;
        }

        public ChiTietBH(string maSP, string tenSP, float giaBan, int soLuong)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaBan = giaBan;
            this.SoLuong = soLuong;
        }

        public float ThanhTien()
        {
            return SoLuong * GiaBan * (1 + ChiTietBH.TiLeThue);
        }

        public void Nhap()
        {
            Console.WriteLine("Ma san pham: ");
            MaSP = Console.ReadLine();
            Console.WriteLine("Ten san pham: ");
            tenSP = Console.ReadLine();
            Console.WriteLine("Gia ban: ");
            GiaBan = float.Parse(Console.ReadLine());
            Console.WriteLine("So luong: ");
            SoLuong = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma san pham: {0}", MaSP);
            Console.WriteLine("Ten san pham: {0}", TenSP);
            Console.WriteLine("Gia ban cua san pham: {0:0.000}", GiaBan);
            Console.WriteLine("So luong cua san pham: {0}", SoLuong);
            Console.WriteLine("Thanh tien: {0:0.00}", ThanhTien());
        }
    }
}
