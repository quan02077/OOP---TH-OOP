using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_NguyenNhatMinhQuan_Tuan01
{
    internal class SanPhamDienTu
    {
        string hangSX;
        string soSeri;
        string tenSp;
        int giaBan;
        string loaiSp;
        public string HangSX
        {
            get
            {
                return hangSX;
            }
            set
            {
                hangSX = value;
            }
        }
        public string SoSeri
        {
            get
            {
                return soSeri;
            }
            set
            {
                if (value.StartsWith("S"))
                {
                    soSeri = value;
                }
                else
                {
                    Console.WriteLine("So seri khong hop le!");
                    soSeri = "S000";
                }
            }
        }
        public string TenSp
        {
            get
            {
                return tenSp;
            }
            set
            {
                tenSp = value;
            }
        }
        public int GiaBan
        {
            get
            {
                return giaBan;
            }
            set
            {
                if(value > 4000000)
                {
                    giaBan = value;
                }
                else
                {
                    Console.WriteLine("Loi nhap gia ban!");
                    giaBan = 0;
                }
            }
        }
        public string LoaiSp
        {
            get
            {
                return loaiSp;
            }
            set
            {
                if(string.Compare(value,"May tinh de ban", true) == 0 || string.Compare(value, "May tinh xach tay", true) == 0 || string.Compare(value,"Dien thoai di dong", true) == 0)
                {
                    loaiSp = value;
                }
                else
                {
                    Console.WriteLine("Loai san pham khong hop le!");
                    loaiSp = "Dien thoai di dong";
                }
            }
        }
        public SanPhamDienTu()
        {
            HangSX = "Xiaomi";
            SoSeri= "S12345";
            TenSp = "Redmi note 13";
            GiaBan = 5000000;
            LoaiSp = "Dien thoai di dong";
        }
        public SanPhamDienTu(string hsx, string ss, string tsp, int gb, string lsp)
        {
            HangSX = hsx;
            SoSeri = ss;
            TenSp = tsp;
            GiaBan = gb;
            LoaiSp = lsp;
        }
        public SanPhamDienTu(SanPhamDienTu spdt)
        {
            HangSX = spdt.HangSX;
            SoSeri = spdt.SoSeri;
            TenSp = spdt.TenSp;
            GiaBan = spdt.GiaBan;
            LoaiSp = spdt.LoaiSp;
        }
        public void Nhap()
        {
            Console.Write("Nhap vao hang san xuat: ");
            HangSX = Console.ReadLine();
            Console.Write("Nhap vao so seri: ");
            SoSeri = Console.ReadLine();
            Console.Write("Nhap vao ten san pham: ");
            TenSp = Console.ReadLine();
            Console.Write("Nhap vao gia ban: ");
            GiaBan = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao loai san pham: ");
            LoaiSp = Console.ReadLine();
        }
        public double ThanhTien()
        {
           
                if (LoaiSp == "May tinh de ban")
                    return GiaBan + GiaBan * 0.08 + GiaBan * 0.1;
                else if (LoaiSp == "May tinh xach tay")
                    return GiaBan + GiaBan * 0.05 + GiaBan * 0.1;
                else if (LoaiSp == "Dien thoai di dong" && HangSX == "SamSung" && (GiaBan * 0.1 <= 2000000))
                    return GiaBan + (GiaBan * 0.1) - 500000 + (GiaBan * 0.1);
                else if (LoaiSp == "Dien thoai di dong" && (GiaBan * 0.1 <= 2000000))
                    return GiaBan + (GiaBan * 0.1)  + (GiaBan * 0.1);
                else if (LoaiSp == "Dien thoai di dong" && HangSX == "SamSung" && (GiaBan * 0.1 > 2000000))
                    return GiaBan + 2000000 - 500000 + (GiaBan * 0.1);
                else if (LoaiSp == "Dien thoai di dong" && (GiaBan * 0.1 > 2000000))
                    return GiaBan + 2000000 + (GiaBan * 0.1);
                else
                    return 0;

        }
        public void Xuat()
        {
            Console.WriteLine($"Hang san xuat: {HangSX}");
            Console.WriteLine($"So series: {SoSeri}");
            Console.WriteLine($"Ten san pham: {TenSp}");
            Console.WriteLine($"Gia ban: {GiaBan}");
            Console.WriteLine($"Loai san pham: {LoaiSp}");
            Console.WriteLine($"Thanh tien: {ThanhTien()}");
        }
    }
}
