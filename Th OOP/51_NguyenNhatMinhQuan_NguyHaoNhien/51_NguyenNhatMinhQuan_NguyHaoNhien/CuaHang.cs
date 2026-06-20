using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _51_NguyenNhatMinhQuan_NguyHaoNhien
{
    internal class CuaHang
    {
        string tenCH;
        string diaChi;
        List<DonHang> LstdonHang = new List<DonHang>();

        public string TenCH { get => tenCH; set => tenCH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        internal List<DonHang> LSTDonHang { get => LstdonHang; set => LstdonHang = value; }

        public CuaHang()
        {
            TenCH = "Quan Nhien Foundation";
            DiaChi = "140 Le Trong Tan";
            LSTDonHang = new List<DonHang>();
        }

        public void DocFileXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            TenCH = doc.SelectSingleNode("/cuahang/ten").InnerText;
            DiaChi = doc.SelectSingleNode("/cuahang/diachi").InnerText;
            XmlNodeList nodeList = doc.SelectNodes("/cuahang/dsdonhang/donhang");
            foreach (XmlNode node in nodeList)
            {
                string maDon = node["madon"].InnerText;
                string tenSp = node["tensp"].InnerText;
                string loaiSp = node["loaisp"].InnerText;
                int soLuong = int.Parse(node["soluong"].InnerText);
                double donGia = double.Parse(node["dongia"].InnerText);
                DateTime ngayDat = DateTime.Parse(node["ngaydat"].InnerText);
                double phiVanChuyen = double.Parse(node["phivc"].InnerText);

                DonHang dh = new DonHang(maDon, tenSp, loaiSp, soLuong, donGia, ngayDat, phiVanChuyen);
                LSTDonHang.Add(dh);
            }
        }

        public void XuatTTCH()
        {
            Console.WriteLine("Ten cua hang: " + tenCH);
            Console.WriteLine("Dia chi cua hang: " + DiaChi);
            for(int i = 0; i < LSTDonHang.Count; i++)
            {
                LSTDonHang[i].Xuat();
            }
        }

        public double TongDoanhThu()
        {
            return LSTDonHang.Sum(s => s.TongTien());
        }
        
        public CuaHang SXDSDH()
        {
            CuaHang cuaHang = new CuaHang();
            cuaHang.LSTDonHang = LSTDonHang.OrderByDescending(s => s.NgayDatHang).ToList();
            return cuaHang;
        }

        public DonHang DonHangTongTienMax()
        {
            return LSTDonHang.OrderByDescending(s => s.TongTien()).First();
        }
    }
}
