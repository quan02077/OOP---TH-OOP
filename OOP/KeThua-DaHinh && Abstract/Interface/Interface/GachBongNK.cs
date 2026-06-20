using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class GachBongNK: HoaDon
    {
        string noiSX;
        int chatLuong;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Noi san xuat: ");
            noiSX = Console.ReadLine();
            Console.Write("Chat luong: ");
            chatLuong = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public override double GiamGia()
        {
            if ((string.Compare(noiSX, "Italia", true) == 0 || string.Compare(noiSX, "Japan", true) == 0))
                return 0;
            else
            {
                if (chatLuong == 1)
                    return 0.03 * SoLuong * DonGia;
                else if (chatLuong == 2)
                    return 0.02 * SoLuong * DonGia;
                else
                    return 0;
            }
        }

        public override double ThueNK()
        {
            return 0.05 * ThanhTien();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Noi san xuat: " + noiSX);
            Console.WriteLine("Chat luong: {0:F2}", chatLuong);
            Console.WriteLine("Giam gia: {0:N0}", GiamGia());
            Console.WriteLine("Thue: {0:N0}", Thue());
            Console.WriteLine("Tong tien: {0:N0}", ThanhTien() );
            Console.WriteLine();
        }
    }
}
