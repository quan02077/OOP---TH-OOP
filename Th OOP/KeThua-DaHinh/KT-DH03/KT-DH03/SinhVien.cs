using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH03
{
    internal class SinhVien : Nguoi
    {
        string maSV;
        string heDaoTao;

        public string MaSV { get => maSV; set => maSV = value; }

        public string HeDaoTao
        {
            get => heDaoTao;
            set
            {
                if(string.Compare(value, "Dai hoc", true) == 0 || string.Compare(value, "Cao dang", true) == 0 || string.Compare(value, "Cao dang nghe", true) == 0)
                    heDaoTao = value;
                else
                {
                    Console.WriteLine("He dao tao khong hop le!");
                    heDaoTao = "Dai hoc";
                }
            }
        }

        public SinhVien()
        {
            MaSV = "2001240388";
            HeDaoTao = "Dai hoc";
        }

        public SinhVien(string hoTen, DateTime ngaySinh, string gioiTinh, string maSV, string heDaoTao) : base(hoTen, ngaySinh, gioiTinh)
        {
            MaSV = maSV;
            HeDaoTao = heDaoTao;
        }

        public int TongSoTC()
        {
                if (string.Compare(HeDaoTao, "Dai hoc", true) == 0)
                    return 150;
                else if (string.Compare(HeDaoTao, "Cao dang", true) == 0)
                    return 100;
                else
                    return 130;
        }

        public int TongHocPhi()
        {
            if (string.Compare(HeDaoTao, "Dai hoc", true) == 0)
                return TongSoTC() * 200000;
            else if (string.Compare(HeDaoTao, "Cao dang", true) == 0)
                return TongSoTC() * 150000;
            else
                return TongSoTC() * 120000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma so sinh vien: " + MaSV);
            Console.WriteLine("He dao tao: " + HeDaoTao);
            Console.WriteLine("Tong so tin chi: " + TongSoTC());
            Console.WriteLine("Tong hoc phi: " + TongHocPhi());
        }
    }
}
