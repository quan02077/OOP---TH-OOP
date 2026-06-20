using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Buoi3
{
    internal class ChungChiTinHoc
    {
        string hoVaTen;
        string soBaoDanh;
        int namSinh;
        float diemThiLT;
        float diemThiTH;

        // Property
        public string HoVaTen
        {
            get
            {
                return hoVaTen;
            }
            set
            {
                hoVaTen = value;
            }
        }

        public string SoBaoDanh
        {
            get
            {
                return soBaoDanh;
            }
            set
            {
                soBaoDanh = value;
            }
        }

        public int NamSinh
        {
            get
            {
                return namSinh;
            }
            set
            {
                if (value <= 0)
                {
                    namSinh = 0;
                    Console.Write("Nam sinh vua nhap khong hop le.");
                }
                else
                {
                    namSinh = value;
                }
            }
        }

        public float DiemThiLT
        {
            get
            {
                return diemThiLT;
            }
            set
            {
                diemThiLT = value;
            }
        }

        public float DiemThiTH
        {
            get
            {
                return diemThiTH;
            }
            set
            {
                diemThiTH = value;
            }
        }

        //PTKT

        public ChungChiTinHoc()
        {
            HoVaTen = "Nguyen Nhat Minh Quan";
            SoBaoDanh = "2001240388";
            NamSinh = 2006;
            DiemThiLT = 8.88f;
            DiemThiTH = 9.99f;
        }

        public ChungChiTinHoc(ChungChiTinHoc ccth)
        {
            HoVaTen = ccth.HoVaTen;
            SoBaoDanh = ccth.SoBaoDanh;
            NamSinh= ccth.NamSinh;
            DiemThiLT = ccth.DiemThiLT;
            DiemThiTH = ccth.DiemThiTH;
        }

        public ChungChiTinHoc(string ht, string sbd, int ns, float lt, float th)
        {
            HoVaTen = ht;
            SoBaoDanh = sbd;
            NamSinh = ns;
            DiemThiLT = lt;
            DiemThiTH = th;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap vao ho va ten: ");
            hoVaTen = Console.ReadLine(); 
            Console.WriteLine("Nhap vao so bao danh: ");
            soBaoDanh = Console.ReadLine();
            Console.WriteLine("Nhap vao nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem thi ly thuyet: ");
            diemThiLT = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem thi thuc hanh: ");
            diemThiTH = float.Parse(Console.ReadLine());
        }
        

        public string XetDauRot()   
        {
            if(diemThiLT >= 5 &&  diemThiTH >= 5 && (diemThiLT + diemThiTH >= 10))
            {
                return "Dau.";
            }
            else
            {
                return "Rot.";
            }
        }

        public void Xuat()
        {
            Console.Write($"Ho va ten: {hoVaTen}");
            Console.Write($"So bao danh: {soBaoDanh}");
            Console.WriteLine($"Nam sinh: {namSinh}");
            Console.WriteLine($"Điem LT: {diemThiLT}");
            Console.WriteLine($"Điem TH: {diemThiTH}");
            Console.WriteLine($"Ket qua: {XetDauRot()}");
        }
    }
}
