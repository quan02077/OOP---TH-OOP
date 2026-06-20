using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class HinhChuNhat
    {
        int chieuDai;
        int chieuRong;

        public int ChieuDai
        {
            get { return chieuDai; }
            set
            {
                if (value > 0)
                {
                    chieuDai = value;
                }
                else
                {
                    Console.WriteLine("Chieu dai phai lon hon 0.");
                    chieuDai = 1;
                }
            }
        }

        public int ChieuRong
        {
            get { return chieuRong; }
            set
            {
                if (value > 0)
                {
                    chieuRong = value;
                }
                else
                {
                    Console.WriteLine("Chieu rong phai lon hon 0.");
                    chieuRong = 1;
                }
            }
        }

        public HinhChuNhat()
        {
            ChieuDai = 5;
            ChieuRong = 3;
        }

        public HinhChuNhat(int ChieuDai, int ChieuRong)
        {
            this.ChieuDai = ChieuDai;
            this.ChieuRong = ChieuRong;
        }

        public HinhChuNhat(HinhChuNhat hcn)
        {
            ChieuDai = hcn.ChieuDai;
            ChieuRong = hcn.ChieuRong;
        }

        public int TinhChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }

        public int TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public int TinhDuongCheo()
        {
            return (int)Math.Sqrt(ChieuDai * ChieuDai + ChieuRong * ChieuRong);
        }

        public void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            ChieuDai = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            ChieuRong = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Chieu dai: " + ChieuDai);
            Console.WriteLine("Chieu rong: " + ChieuRong);
            Console.WriteLine("Chu vi: " + TinhChuVi());
            Console.WriteLine("Dien tich: " + TinhDienTich());
            Console.WriteLine("Duong cheo: " + TinhDuongCheo());
        }

        public void ChangeSize(int tx, int ty, int kieu)
        {
            if (kieu == 1)
            {
                ChieuDai += tx;
                ChieuRong += ty;
            }
            else if (kieu == 2)
            {
                ChieuDai -= tx;
                ChieuRong -= ty;
                if (ChieuDai <= 0)
                {
                    Console.WriteLine("Chieu dai phai lon hon 0.");
                    ChieuDai = 0;
                }
                if (ChieuRong <= 0)
                {
                    Console.WriteLine("Chieu rong phai lon hon 0.");
                    ChieuRong = 0;
                }
            }
            else
            {
                Console.WriteLine("Kieu khong hop le.");
            }
        }

        public void ChangeSize(HinhChuNhat a, int kieu)
        {
            if (kieu == 1)
            {
                ChieuDai += a.ChieuDai;
                ChieuRong += a.ChieuRong;
            }
            else if (kieu == 2)
            {
                ChieuDai -= a.ChieuDai;
                ChieuRong -= a.ChieuRong;
                if (ChieuDai <= 0)
                {
                    Console.WriteLine("Chieu dai phai lon hon 0.");
                    ChieuDai = 0;
                }
                if (ChieuRong <= 0)
                {
                    Console.WriteLine("Chieu rong phai lon hon 0.");
                    ChieuRong = 0;
                }
            }
            else
            {
                Console.WriteLine("Kieu khong hop le.");
            }
        }
    }
}
