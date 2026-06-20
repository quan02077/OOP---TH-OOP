using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Abstract03
{
    internal class SinhVien
    {
        List<MonHoc> dsMonHoc = new List<MonHoc>();

        internal List<MonHoc> DsMonHoc { get => dsMonHoc; set => dsMonHoc = value; }

        public SinhVien()
        {
            DsMonHoc = new List<MonHoc>();
        }

        public void DocFileXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList nodelist = doc.SelectNodes("/monhocs/mh");
            foreach (XmlNode node in nodelist)
            {
                MonHoc mh;
                string ma = node["ma"].InnerText;
                string ten = node["ten"].InnerText;
                int soTC = int.Parse(node["sotc"].InnerText);
                string khoa = node["khoa"].InnerText;
                string loai = string.Empty;
                loai = node.Attributes["loai"].Value;
                if (loai == "Ly thuyet")
                {
                    float diemTL = float.Parse(node["diemtl"].InnerText);
                    float diemGK = float.Parse(node["diemgk"].InnerText);
                    float diemCK = float.Parse(node["diemck"].InnerText);
                    mh = new MonLyThuyet(ma, ten, soTC, khoa, diemTL, diemGK, diemCK);
                }
                else if (loai == "Thuc hanh")
                {
                    float diemKT1 = float.Parse(node["diemkt1"].InnerText);
                    float diemKT2 = float.Parse(node["diemkt2"].InnerText);
                    float diemKT3 = float.Parse(node["diemkt3"].InnerText);
                    float diemKT4 = float.Parse(node["diemkt4"].InnerText);
                    mh = new MonThucHanh(ma, ten, soTC, khoa, diemKT1, diemKT2, diemKT3, diemKT4);
                }
                else
                {
                    float diemGVHD = float.Parse(node["diemgvhd"].InnerText);
                    float diemGVPB = float.Parse(node["diemgvpb"].InnerText);
                    mh = new DoAn(ma, ten, soTC, khoa, diemGVHD, diemGVPB);
                }
                DsMonHoc.Add(mh);
            }
        }

        public void XuatDS()
        {
            for(int i = 0; i < DsMonHoc.Count; i++)
            {
                DsMonHoc[i].Xuat();
                Console.WriteLine();
            }
        }

        public double TongHocPhi()
        {
            return DsMonHoc.Sum(s => s.TinhHocPhi());
        }

        public double GPA()
        {
            double tongTichLuy = DsMonHoc.Sum(s => s.TinhDiemTichLuy());
            int tongTinChi = DsMonHoc.Sum(s => s.SoTC);
            if (tongTinChi == 0)
                return 0;
            return tongTichLuy/tongTinChi;
        }
    }
}
