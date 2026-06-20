using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _51_NguyenNhatMinhQuan_KTL2
{
    internal class NguyenNhatMinhQuan_CongTyXayDung
    {
        string tenCTY;
        string sDT;
        List<NguyenNhatMinhQuan_HopDong> dsHD;

        public string TenCTY { get => tenCTY; set => tenCTY = value; }
        public string SDT { get => sDT; set => sDT = value; }
        internal List<NguyenNhatMinhQuan_HopDong> DsHD { get => dsHD; set => dsHD = value; }

        public NguyenNhatMinhQuan_CongTyXayDung()
        {
            TenCTY = "Quan Phu Ho";
            SDT = "0908509406";
            DsHD = new List<NguyenNhatMinhQuan_HopDong>();
        }

        public void DocFileXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            TenCTY = doc.SelectSingleNode("xaydung/tenct").InnerText;
            SDT = doc.SelectSingleNode("xaydung/dienthoai").InnerText;
            XmlNodeList nodelist = doc.SelectNodes("xaydung/dshd/hd");
            foreach (XmlNode node in nodelist)
            {
                NguyenNhatMinhQuan_HopDong hd;
                string maHD = node["mahd"].InnerText;
                string tenKH = node["tenkh"].InnerText;
                int thoiGianLam = int.Parse(node["thoigianlam"].InnerText);
                float chieuDai = float.Parse(node["dai"].InnerText);
                float chieuRong = float.Parse(node["rong"].InnerText);
                float soTienTamUng = float.Parse(node["sotientamung"].InnerText);
                string loai = string.Empty;
                loai = node.Attributes["loai"].Value;   
                if(loai == "nha4")
                {
                    float dienTichCongTrinhPhu = float.Parse(node["dientichcongtrinhphu"].InnerText);
                    hd = new NguyenNhatMinhQuan_NhaCap4(maHD, tenKH, thoiGianLam, chieuDai, chieuRong, soTienTamUng, dienTichCongTrinhPhu);
                }
                else if(loai == "nhalau")
                {
                    int soSan = int.Parse(node["sosan"].InnerText);
                    bool trangTri = bool.Parse(node["trangtri"].InnerText);
                    hd = new NguyenNhatMinhQuan_NhaLau(maHD, tenKH, thoiGianLam, chieuDai, chieuRong, soTienTamUng, soSan, trangTri);
                }
                else
                {
                    float dienTichNV = float.Parse(node["dientichngoaivi"].InnerText);
                    int soLuongHB = int.Parse(node["soluonghoboi"].InnerText);
                    hd = new NguyenNhatMinhQuan_BietThu(maHD, tenKH, thoiGianLam, chieuDai, chieuRong, soTienTamUng, dienTichNV, soLuongHB);
                }
                DsHD.Add(hd);
            }
        }

        public void XuatDS()
        {
            for(int i = 0; i < DsHD.Count; i++)
            {
                DsHD[i].Xuat();
            }
        }

        public double TongTienHD()
        {
            return DsHD.Sum(s => s.TongTien());
        }

        public NguyenNhatMinhQuan_CongTyXayDung SapXep()
        {
            NguyenNhatMinhQuan_CongTyXayDung hd = new NguyenNhatMinhQuan_CongTyXayDung();
            hd.DsHD = DsHD.OrderBy(S => S.TongTien()).ThenBy(s => s.DienTichXayDung()).ToList();
            return hd;
        }

        public double TongTriAn()
        {
            List<NguyenNhatMinhQuan_NhaLau> nl = DsHD.OfType<NguyenNhatMinhQuan_NhaLau>().ToList();
            return nl.OfType<INguyenNhatMinhQuan_TriAn>().Sum(s => s.TriAn());
        }

        public double TongTienTamUngBietThu()
        {
            return DsHD.OfType<NguyenNhatMinhQuan_BietThu>().Sum(s => s.SoTienTamUng);
        }

        public void Tim()
        {
            Console.Write("Nhap vao ma hop dong can tim: ");
            string maX = Console.ReadLine();
            var ketQua = DsHD.FirstOrDefault(s => s.MaHD == maX);
            if (ketQua != null)
                ketQua.Xuat();
            else
                Console.WriteLine($"Hop dong ma {maX} khong ton tai!");
        }
    }
}
