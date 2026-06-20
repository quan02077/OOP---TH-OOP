using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract03
{
    internal class MonLyThuyet: MonHoc
    {
        float diemTL;
        float diemGK;
        float diemCK;

        public float DiemTL { get => diemTL; set => diemTL = value; }
        public float DiemGK { get => diemGK; set => diemGK = value; }
        public float DiemCK { get => diemCK; set => diemCK = value; }

        public MonLyThuyet()
        {
            DiemTL = 0.0f;
            DiemGK = 0.0f;
            DiemCK = 0.0f;
        }

        public MonLyThuyet(string maMon, string tenMon, int soTC, string khoaPT, float diemTL, float diemGK, float diemCK): base(maMon, tenMon, soTC, khoaPT)    
        {
            DiemTL = diemTL;
            DiemGK = diemGK;
            DiemCK = diemCK;
        }

        public override double DTB()
        {
            return DiemTL * 0.2 + DiemGK * 0.3 + DiemCK * 0.5;
        }

        public override double TinhDiemTichLuy()
        {
            return DTB() * SoTC;
        }

        public override double TinhHocPhi()
        {
            return SoTC * 250000;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem tieu luan: {0:F2}", DiemTL);
            Console.WriteLine("Diem giua ki: {0:F2}", DiemGK);
            Console.WriteLine("Diem cuoi ki: {0:F2}", DiemCK);
            Console.WriteLine("Diem trung binh: {0:F2}", DTB());
            Console.WriteLine("Hoc phi cua mon hoc: {0:N0}", TinhHocPhi());
        }
    }
}
