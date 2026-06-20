using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _51_NguyenNhatMinhQuan_Tuan04
{
    internal class CongTyABC
    {
        string tenCTY;
        string diaChi;
        string sDT;
        List<NhanVien> dsnv = new List<NhanVien>();

        public string TenCTY { get => tenCTY; set => tenCTY = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        internal List<NhanVien> DSNV { get => dsnv; set => dsnv = value; }

        public CongTyABC()
        {
            TenCTY = string.Empty;
            DiaChi = string.Empty;
            SDT = string.Empty;
            DSNV = new List<NhanVien>();
        }

        public void DocFileXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            TenCTY = doc.SelectSingleNode("/congty/tencty").InnerText;
            DiaChi = doc.SelectSingleNode("/congty/diachi").InnerText;
            SDT = doc.SelectSingleNode("/congty/dt").InnerText;

            XmlNodeList nodelist = doc.SelectNodes("/congty/dsnv/nv");
            foreach (XmlNode node in nodelist)
            {
                NhanVien nv;
                string maso = node["ma"].InnerText;
                string ten = node["ten"].InnerText;
                int nvl = int.Parse(node["nvl"].InnerText);
                float hsl = float.Parse(node["hsl"].InnerText);
                int snn = int.Parse(node["snn"].InnerText);
                string loai = string.Empty;
                loai = node.Attributes["loai"].Value;
                if (loai == "1")
                    nv = new NhanVien(maso, ten, nvl, hsl, snn);
                else
                {
                    string cv = node["cv"].InnerText;
                    string phongban = node["phongban"].InnerText;
                    float hspccv = float.Parse(node["hspccv"].InnerText);
                    nv = new CanBoLanhDao(maso, ten, nvl, hsl, snn, cv, phongban, hspccv);
                }
                DSNV.Add(nv);
            }
        }

        public double LuongMax()
        {
            return DSNV.Max(s => s.TinhLuong());
        }

        public NhanVien NVLuongMax()
        {
            double Max = LuongMax();
            NhanVien nv = DSNV.FirstOrDefault(s => s.TinhLuong() == Max);
            return nv;
        }
        public void XuatDS()
        {
            Console.WriteLine("Ten cong ty: " + TenCTY);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("So dien thoai: " + SDT);
            foreach (NhanVien nv in DSNV)
            {
                nv.Xuat();
                Console.WriteLine();
            }
        }

        public void XuatCB()
        {
            foreach (NhanVien nv in DSNV)
            {
                if (nv is CanBoLanhDao)
                {
                    nv.Xuat();
                    Console.WriteLine();
                }
            }
        }
    }
}
