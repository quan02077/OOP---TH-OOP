using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract02
{
    internal class KhachHangLaCTY: HoaDon, IHoTro
    {
        int soLuongNV;

        public KhachHangLaCTY()
        {
            soLuongNV = 2000;
        }

        public KhachHangLaCTY(string ma, string ten, int sl, int gia, int soLuongNV)
            : base(ma, ten, sl, gia)
        {
            this.soLuongNV = soLuongNV;
        }
        public double ChietKhau()
        {
            if (soLuongNV > 5000)
                return SoLuong * GiaBan * 0.05; 
            else if (soLuongNV > 1000)
                return SoLuong * GiaBan * 0.03; 
            else
                return 0;
        }
        public double HoTro()
        {
            return 12000 * SoLuong;
        }
        public override double ThanhTien()
        {
            return (SoLuong * GiaBan - ChietKhau() - (SoLuong * GiaBan * 0.1)) - HoTro();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So luong nhan vien: " + soLuongNV);
            Console.WriteLine("Thanh tien: {0:N0}", ThanhTien());
        }
    }
}
