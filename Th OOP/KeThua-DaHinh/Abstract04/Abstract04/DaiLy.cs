using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Abstract04
{
    internal class DaiLy
    {
        List<HoaDon> dsHoaDon = new List<HoaDon>();

        internal List<HoaDon> DsHoaDon { get => dsHoaDon; set => dsHoaDon = value; }

        public DaiLy()
        {
            DsHoaDon = new List<HoaDon>();
        }

        public void DocFileXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList nodeList = doc.SelectNodes("/daily/dshoadon/hd");
            foreach (XmlNode node in nodeList)
            {
                HoaDon hd;
                string maHang = node["mahang"].InnerText;
                string tenHang = node["tenhang"].InnerText; 
                float donGia = float.Parse(node["dongia"].InnerText); 
                string maSo = node["maso"].InnerText; 
                string hoTen = node["hoten"].InnerText; 
                string ngayLap = node["ngaylap"].InnerText; 
                string matHang = node["mathang"].InnerText; 
                int soLuong = int.Parse(node["soluong"].InnerText);
                string loai = string.Empty;
                loai = node.Attributes["loai"].Value;
                if (loai == "1")
                    hd = new HoaDonKhachVIP(maHang, tenHang, donGia, maSo, hoTen, ngayLap, matHang, soLuong);
                else if (loai == "2")
                    hd = new HoaDonKhachHangThanThiet(maHang, tenHang, donGia, maSo, hoTen, ngayLap, matHang, soLuong);
                else
                    hd = new HoaDonKhachVangLai(maHang, tenHang, donGia, maSo, hoTen, ngayLap, matHang, soLuong);
                DsHoaDon.Add(hd);
            }
        }

        public void XuatDS()
        {
            for (int i = 0; i < DsHoaDon.Count; i++)
            {
                DsHoaDon[i].Xuat();
                Console.WriteLine();
            }
        }

        public void XuatDSVL()
        {
            for(int i = 0;i < DsHoaDon.Count; i++)
            {
                if (DsHoaDon[i] is HoaDonKhachVangLai)
                {
                    DsHoaDon[i].Xuat();
                    Console.WriteLine();
                }
            }
        }

        public double TongTriGia()
        {
            return DsHoaDon.Sum(s => s.TriGia());
        }

        public HoaDon TriGiaMax()
        {
            return DsHoaDon.OrderByDescending(s => s.TriGia()).FirstOrDefault();
        }

        public void HoaDonVipTT()
        {
            List<HoaDonKhachVIP> vip = DsHoaDon.OfType<HoaDonKhachVIP>().ToList();
           List<HoaDonKhachHangThanThiet> tt = DsHoaDon.OfType<HoaDonKhachHangThanThiet>().ToList();
            int soLuongVIP = vip.Count;
            int soLuongTT = tt.Count;
            Console.WriteLine();
            Console.WriteLine("So luong hoa don cua khach vip: " + soLuongVIP);
            Console.WriteLine("So luong hoa son cua khach hang than thiet: " + soLuongTT);
            Console.WriteLine();
        }

        public DaiLy SapXep()
        {
            DaiLy dl = new DaiLy();
            dl.DsHoaDon = DsHoaDon.OrderBy(s => s.TriGia()).ThenByDescending(s => s.MaSo).ToList();
            return dl;
        }
    }
}
