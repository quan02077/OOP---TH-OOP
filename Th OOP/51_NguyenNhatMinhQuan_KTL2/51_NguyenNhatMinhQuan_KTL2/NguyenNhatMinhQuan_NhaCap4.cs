using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_KTL2
{
    internal class NguyenNhatMinhQuan_NhaCap4: NguyenNhatMinhQuan_HopDong
    {
        public static float DonGiaCongTrinhPhu = 1500;
        float dienTichCongTrinhPhu;

        public float DienTichCongTrinhPhu { get => dienTichCongTrinhPhu; set => dienTichCongTrinhPhu = value; }

        public NguyenNhatMinhQuan_NhaCap4()
        {
            DienTichCongTrinhPhu = 30.6f;
        }
        public NguyenNhatMinhQuan_NhaCap4(string maHD, string tenKH, int thoiGianXayDung, float chieuDai, float chieuRong, float soTienTamUng, float dienTichCongTrinhPhu) : base(maHD, tenKH, thoiGianXayDung, chieuDai, chieuRong, soTienTamUng)
        {

            DienTichCongTrinhPhu = dienTichCongTrinhPhu;

        }

        public override double PhuThu()
        {
            return DienTichCongTrinhPhu * DonGiaCongTrinhPhu;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Dien tich cong trinh phu: {0:F2}", DienTichCongTrinhPhu);
            Console.WriteLine("Tong Tien: {0:N0}", TongTien());
        }
    }
}
