using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04
{
    internal class ThiSinh
    {
        string maThiSinh;
        string hoTen;
        string gioiTinh;
        float diemLT;
        float diemTH;

        public string MaThiSinh { get => maThiSinh; set => maThiSinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public float DiemLT { get => diemLT; set => diemLT = value; }
        public float DiemTH { get => diemTH; set => diemTH = value; }

        public ThiSinh()
        {
            MaThiSinh = "2001240388";
            HoTen = "Nguyen Nhat Minh Quan";
            GioiTinh = "Nam";
            DiemLT = 7.75f;
            DiemTH = 9.50f;
        }

        public ThiSinh(ThiSinh th)
        {
            MaThiSinh = th.MaThiSinh;
            HoTen = th.HoTen;
            GioiTinh= th.GioiTinh;
            DiemLT = th.DiemLT;
            DiemTH = th.DiemTH;
        }

        public ThiSinh(string maThiSinh, string hoTen, string gioiTinh, float diemLT,  float diemTH)
        {
            MaThiSinh= maThiSinh;
            HoTen= hoTen;
            GioiTinh = gioiTinh;
            DiemLT = diemLT;
            DiemTH = diemTH;
        }

        public float DiemTongKet()
        {
            return (DiemLT + DiemTH) / 2;
        }

        public string XetTuyen()
        {
            if (DiemTongKet() >= 5.00 && DiemLT >= 5.00 && DiemTH >= 5.00)
            {
                return "Dau";
            }
            else
            {
                return "Rot";
            }
        }

        public void Nhap()
        {
            Console.WriteLine("Ma thi sinh: ");
            MaThiSinh = Console.ReadLine();
            Console.WriteLine("Ho ten thi sinh: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Diem ly thuyet: ");
            DiemLT = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem thuc hanh: ");
            DiemTH = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma thi sinh: {0}", MaThiSinh);
            Console.WriteLine("Ho ten thi sinh: {0}", HoTen);
            Console.WriteLine("Diem ly thuyet: {0}", DiemLT);
            Console.WriteLine("Diem thuc hanh: {0}", DiemTH);
            Console.WriteLine("Diem tong ket: {0}", DiemTongKet());
            Console.WriteLine("Xet tuyen: {0}", XetTuyen());
        }


    }
}
