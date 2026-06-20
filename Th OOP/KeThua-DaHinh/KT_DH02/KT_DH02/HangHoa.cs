using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH02
{
    internal class HangHoa
    {
        protected string maHang;
        protected string tenHang;

        public string MaHang
        {
            get { return maHang; }
            set
            {
                if (value.Length == 5 && value.StartsWith("HH") && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                    maHang = value;
                else
                {
                    Console.WriteLine("Ma hang khong hop le!");
                    maHang = "HH001";
                }
            }
        }

        public string TenHang { get => tenHang; set => tenHang = value; }

        public HangHoa()
        {
            MaHang = "HH001";
            TenHang = "Pepsi";
        }

        public HangHoa(string maHang, string tenHang)
        {
            MaHang = maHang;
            TenHang = tenHang;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ma hang: " + MaHang);
            Console.WriteLine("Ten hang: " + TenHang);
        }
    }
}
