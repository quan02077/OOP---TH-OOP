using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_Si
{
    internal class TaiNha: HopDong
    {
        float khoangCach;

        public void Nhap()
        {
            Console.WriteLine("Nhap vao khoang cach: ");
            khoangCach = float.Parse(Console.ReadLine());
        }
        public override double PhiQuangCao()
        {
            double phi = 0;
            if (khoangCach < 20)
                phi = 400000 * khoangCach;
            else
                phi = 300000 * khoangCach;
            if (phi > 15000000)
                phi = 15000000;
            return phi;
        }

        public override void Xuat()
        {
            Console.WriteLine("Khoang cach di chuyen: {0:0.00}", khoangCach);
            base.Xuat();
            Console.WriteLine("Thanh tien: {0:N0}", ThanhTien());
            Console.WriteLine("Thue: {0:N0}", Thue());
        }
    }
}
