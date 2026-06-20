using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract03
{
    internal class DoAn: MonHoc
    {
        float diemGVHD;
        float diemGVPB;

        public float DiemGVHD { get => diemGVHD; set => diemGVHD = value; }
        public float DiemGVPB { get => diemGVPB; set => diemGVPB = value; }

        public DoAn()
        {
            DiemGVHD = 0.0f;
            DiemGVPB = 0.0f;
        }

        public DoAn(string maMon, string tenMon, int soTC, string khoaPT, float diemGVHD, float diemGVPB): base(maMon, tenMon, soTC, khoaPT)
        {
            DiemGVHD = diemGVHD;
            DiemGVPB= diemGVPB;
        }

        public override double DTB()
        {
            return (2 * DiemGVHD + DiemGVPB) / 3;
        }

        public override double TinhDiemTichLuy()
        {
            return DTB() * SoTC;
        }

        public override double TinhHocPhi()
        {
            return SoTC * 2000000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Diem giao vien huong dan: {0:F2}", DiemGVHD);
            Console.WriteLine("Diem giao vien phan bien: {0:F2}", DiemGVPB);
            Console.WriteLine("Diem trung binh: {0:F2}", DTB());
            Console.WriteLine("Hoc phi cua mon hoc: {0:N0}", TinhHocPhi());
        }
    }
}
