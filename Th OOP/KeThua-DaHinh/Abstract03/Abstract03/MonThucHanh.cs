using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract03
{
    internal class MonThucHanh: MonHoc
    {
        float diemKT1;
        float diemKT2;
        float diemKT3;
        float diemKT4;

        public float DiemKT1 { get => diemKT1; set => diemKT1 = value; }
        public float DiemKT2 { get => diemKT2; set => diemKT2 = value; }
        public float DiemKT3 { get => diemKT3; set => diemKT3 = value; }
        public float DiemKT4 { get => diemKT4; set => diemKT4 = value; }

        public MonThucHanh()
        {
            DiemKT1 = 0.0f;
            DiemKT2 = 0.0f;
            DiemKT3 = 0.0f;
            DiemKT4 = 0.0f;
        }

        public MonThucHanh(string maMon, string tenMon, int soTC, string khoaPT, float diemKT1, float diemKT2, float diemKT3, float diemKT4): base(maMon, tenMon, soTC, khoaPT)
        {
            DiemKT1 = diemKT1;
            DiemKT2 = diemKT2;
            DiemKT3 = diemKT3;
            DiemKT4 = diemKT4;
        }

        public override double DTB()
        {
            return (DiemKT1 + DiemKT2 + DiemKT3 + DiemKT4) / 4;
        }

        public override double TinhDiemTichLuy()
        {
            return DTB() * SoTC;
        }

        public override double TinhHocPhi()
        {
            return (SoTC * 350000) + 100000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem kiem tra 1: {0:F2}", DiemKT1);
            Console.WriteLine("Diem kiem tra 2: {0:F2}", DiemKT2);
            Console.WriteLine("Diem kiem tra 3: {0:F2}", DiemKT3);
            Console.WriteLine("Diem kiem tra 4: {0:F2}", DiemKT4);
            Console.WriteLine("Diem trung binh: {0:F2}", DTB());
            Console.WriteLine("Hoc phi cua mon hoc: {0:N0}", TinhHocPhi());
        }
    }
}
