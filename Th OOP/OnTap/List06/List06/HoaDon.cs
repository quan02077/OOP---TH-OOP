using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace List06
{
    internal class HoaDon
    {
        string maHoaDon;
        string tenKH;
        List<ChiTietBH> DSbanhang = new List<ChiTietBH>();

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        internal List<ChiTietBH> DSBanHang { get => DSbanhang; set => DSbanhang = value; }

        public HoaDon()
        {
            MaHoaDon = "001";
            TenKH = "Rau ma";
            DSBanHang = new List<ChiTietBH>();
        }

        public void NhapDS()
        {
            Console.Write("Ma hoa don: ");
            MaHoaDon = Console.ReadLine();
            Console.Write("Ten khach hang: ");
            TenKH = Console.ReadLine();
            Console.Write("Nhap vao so luong san pham: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao san pham thu {0}", i + 1);
                ChiTietBH ct = new ChiTietBH();
                ct.Nhap();
                DSBanHang.Add(ct);
            }
        }

        public void DocFileXml(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList nodelist = doc.SelectNodes("/khachhang/hoadon");
            foreach (XmlNode node in nodelist)
            {
                MaHoaDon = node["mahd"].InnerText;
                TenKH = node["tenkh"].InnerText;
                XmlNodeList sanphamnode = node.SelectNodes("chitietbh");
                foreach(XmlNode spnode in sanphamnode)
                {
                    string masp = spnode["masp"].InnerText;
                    string tensp = spnode["tensp"].InnerText;
                    float giaban = float.Parse(spnode["giaban"].InnerText);
                    int soluong = int.Parse(spnode["soluong"].InnerText);
                    ChiTietBH ct = new ChiTietBH(masp, tensp, giaban, soluong);
                    DSBanHang.Add(ct);
                }
            }
        }
        public float TongThanhTien()
        {
            return DSBanHang.Sum(s => s.ThanhTien());
        }

        public void XuatDS()
        {
            Console.WriteLine("Ma hoa don: {0}", MaHoaDon);
            Console.WriteLine("Ten khach hang: {0}", TenKH);
            for(int i = 0; i < DSBanHang.Count; i++)
            {
                DSBanHang[i].Xuat();
            }
        }

        public HoaDon SapXepChiTietBH()
        {
            HoaDon hd = new HoaDon();
            hd.DSBanHang = DSBanHang.OrderByDescending(s => s.ThanhTien()).ThenBy(s => s.GiaBan).ToList();
            return hd;
        }

        public float ThanhTienLonNhat()
        {
            return DSBanHang.Max(s => s.ThanhTien());
        }
    }
}
