using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_Si
{
    internal class RapNho: HopDong, IHoTro
    {
        int quyMo;

        public int QuyMo
        {
            get { return quyMo; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    Console.WriteLine("Quy mo khong hop le");
                    quyMo = 1;
                }
                else
                    quyMo = value;
            }
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap vao quy mo: ");
            QuyMo = int.Parse(Console.ReadLine());
        }

        public override double PhiQuangCao()
        {
            return 10000000 + 2000000 * soTM;
        }

        public double HoTro()
        {
            if (QuyMo >= 1 && QuyMo <= 3)
                return 1000000;
            else
                return 0;
        }

        public override void Xuat()
        {
            Console.WriteLine("Quy mo: " + QuyMo);
            base.Xuat();
            Console.WriteLine("Thanh tien: {0:N0}", ThanhTien() - HoTro());
            Console.WriteLine("Thue: {0:N0}", Thue());
        }
    }
}
