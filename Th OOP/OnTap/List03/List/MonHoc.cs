using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class MonHoc
    {
        string maMH;
        string tenMH;
        float diemKTTX;
        float diemGK;
        float diemCK;

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public float DiemKTTX { get => diemKTTX; set => diemKTTX = value; }
        public float DiemGK { get => diemGK; set => diemGK = value; }
        public float DiemCK { get => diemCK; set => diemCK = value; }

        public MonHoc()
        {
            MaMH = "1234";
            TenMH = "Tieng Tay";
            DiemKTTX = 3.75f;
            DiemGK = 5.50f;
            DiemCK = 7.50f;
        }

        public MonHoc(string maMh, string tenMh)
        {
            MaMH = maMh;
            TenMH = tenMh;
        }

        public MonHoc(string maMH, string tenMH, float diemKTTX, float diemGK, float diemCK)
        {
            MaMH = maMH;
            TenMH = tenMH;
            DiemKTTX = diemKTTX;
            DiemGK = diemGK;
            DiemCK = diemCK;
        }

        public float DiemTongKet()
        {
            return (DiemKTTX * 1 + DiemGK * 2 + DiemCK * 3) / 6;
        }

        public string KetQua()
        {
            if (DiemTongKet() >= 5.00)
                return "Dat!";
            else
                return "Khong dat!";
        }

        public void Nhap()
        {
            Console.Write("Ma mon hoc: ");
            MaMH = Console.ReadLine();
            Console.Write("Ten mon hoc: ");
            TenMH = Console.ReadLine();
            Console.Write("Diem thuong xuyen: ");
            DiemKTTX = float.Parse(Console.ReadLine());
            Console.Write("Diem giua ki: ");
            DiemGK = float.Parse(Console.ReadLine());
            Console.Write("Diem cuoi ki: ");
            DiemCK = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma mon hoc: {0}", MaMH);
            Console.WriteLine("Ten mon hoc: {0}", TenMH);
            Console.WriteLine("Diem thuong xuyen: {0:F2}", DiemKTTX);
            Console.WriteLine("Diem giua ki: {0:F2}", DiemGK);
            Console.WriteLine("Diem cuoi ki: {0:F2}", DiemCK);
            Console.WriteLine("Diem tong ket: {0:F2}", DiemTongKet());
            Console.WriteLine("Ket qua: {0}", KetQua());
        }
    }
}
