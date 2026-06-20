using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_KTL2
{
    internal class NguyenNhatMinhQuan_BietThu: NguyenNhatMinhQuan_HopDong, INguyenNhatMinhQuan_TriAn
    {
        float dienTichNgoaiVi;
        int soLuongHoBoi;

        public float DienTichNgoaiVi { get => dienTichNgoaiVi; set => dienTichNgoaiVi = value; }
        public int SoLuongHoBoi { get => soLuongHoBoi; set => soLuongHoBoi = value; }

        public NguyenNhatMinhQuan_BietThu()
        {
            DienTichNgoaiVi = 18.5f;
            SoLuongHoBoi = 3;
        }

        public NguyenNhatMinhQuan_BietThu(string maHD, string tenKH, int thoiGianXayDung, float chieuDai, float chieuRong, float soTienTamUng, float dienTichNgoaiVi, int soLuongHoBoi) : base(maHD, tenKH, thoiGianXayDung, chieuDai, chieuRong, soTienTamUng)
        {
            DienTichNgoaiVi = dienTichNgoaiVi;
            SoLuongHoBoi = soLuongHoBoi;
        }

        public double TriAn()
        {
            double quaTriAn = 0;
            if (SoLuongHoBoi == 0)
                quaTriAn = 30000;
            else
                quaTriAn = DienTichNgoaiVi * 3000 + SoLuongHoBoi * 1000;
            return quaTriAn;
        }

        public override double PhuThu()
        {
            return 5000 + DienTichNgoaiVi * 3000 + SoLuongHoBoi * 1200;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Dien tich ngoai vi: {0:F2}", DienTichNgoaiVi);
            Console.WriteLine("So luong ho boi: " + SoLuongHoBoi);
            Console.WriteLine("Tong Tien: {0:N0}", TongTien() - TriAn());
        }
    }
}
