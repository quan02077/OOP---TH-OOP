using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH03
{
    internal class Nguoi
    {
        string hoTen;
        DateTime ngaySinh;
        string gioiTinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                if(string.Compare(value,"Nam", true) == 0 || string.Compare(value, "Nam", true) == 0)
                    gioiTinh = value;
                else
                {
                    Console.WriteLine("Gioi tinh khong hop le!");
                    gioiTinh = "Nam";
                }
            }
        }

        public Nguoi()
        {
            HoTen = "Nguyen Nhat Minh Quan";
            NgaySinh = new DateTime(2006, 9, 8);
            GioiTinh = "Nam";
        }

        public Nguoi(string hoTen, DateTime ngaySinh, string gioiTinh)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Ngay sinh: " +  NgaySinh);
            Console.WriteLine("Gioi tinh: " + GioiTinh);
        }
    }
}
