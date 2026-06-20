using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract03
{
    internal abstract class MonHoc
    {
        string maMon;
        string tenMon;
        int soTC;
        string khoaPhuTrach;

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoTC { get => soTC; set => soTC = value; }
        public string KhoaPhuTrach { get => khoaPhuTrach; set => khoaPhuTrach = value; }

        public MonHoc()
        {
            maMon = string.Empty; 
            tenMon = string.Empty;
            soTC = 0;
            khoaPhuTrach = string.Empty;
        }

        public MonHoc(string maMon, string tenMon, int soTC, string khoaPhuTrach)
        {
            MaMon = maMon;
            TenMon = tenMon;
            SoTC = soTC;
            KhoaPhuTrach = khoaPhuTrach;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma mon hoc: " + MaMon);
            Console.WriteLine("Ten mon hoc: " + TenMon);
            Console.WriteLine("So tin chi: " + SoTC);
            Console.WriteLine("Khoa phu trach: " + KhoaPhuTrach);
        }
        public abstract double TinhHocPhi();
        public abstract double DTB();
        public abstract double TinhDiemTichLuy();
    }
}
