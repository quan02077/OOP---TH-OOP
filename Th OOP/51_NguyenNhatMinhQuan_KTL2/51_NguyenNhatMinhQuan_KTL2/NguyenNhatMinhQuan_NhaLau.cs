using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_KTL2
{
    internal class NguyenNhatMinhQuan_NhaLau: NguyenNhatMinhQuan_HopDong, INguyenNhatMinhQuan_TriAn
    {
        int soSan;
        bool trangTriMaiNha;

        public int SoSan { get => soSan; set => soSan = value; }
        public bool TrangTriMaiNha { get => trangTriMaiNha; set => trangTriMaiNha = value; }

        public NguyenNhatMinhQuan_NhaLau()
        {
            soSan = 3;
            trangTriMaiNha = true;
        }

        public NguyenNhatMinhQuan_NhaLau(string maHD, string tenKH, int thoiGianXayDung, float chieuDai, float chieuRong, float soTienTamUng, int soSan, bool trangTriMaiNha) :base(maHD, tenKH, thoiGianXayDung, chieuDai, chieuRong, soTienTamUng)
        {
            SoSan = soSan;
            TrangTriMaiNha = trangTriMaiNha;
        }

        public double TriAn()
        {
           double quaTriAn = 0.01 * TongTien();
            if (quaTriAn <= 50000)
                return quaTriAn;
            else
                quaTriAn = 50000;
            return quaTriAn;
        }
        
        public double ChiPhiLamMai()
        {
            if (TrangTriMaiNha == true)
                return (ChieuDai * ChieuRong) * 1200;
            else
                return 0;
        }

        public override double PhuThu()
        {
            return SoSan * (ChieuDai * ChieuRong) * 5000 + ChiPhiLamMai();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So san: " + SoSan);
            Console.WriteLine("Trang tri mai nha: " + TrangTriMaiNha);
            Console.WriteLine("Tong Tien: {0:N0}", TongTien() - TriAn());
        }
    }
}
