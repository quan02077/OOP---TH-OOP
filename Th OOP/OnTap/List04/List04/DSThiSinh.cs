using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace List04
{
    internal class DSThiSinh
    {
        List<ThiSinh> LST = new List<ThiSinh>();

        internal List<ThiSinh> LST1 { get => LST; set => LST = value; }

        public DSThiSinh()
        {
            LST1 = new List<ThiSinh>();
        }

        public void NhapDS()
        {
            int n;
            Console.Write("Nhap vao so luong thi sinh: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                Console.Write("Nhap vap thong tin thi sinh thu {0}: ", i+1);
                ThiSinh ts = new ThiSinh();
                ts.Nhap();
                LST1.Add(ts);
            }
        }

        public void DocFileXML(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList nodelist = doc.SelectNodes("/phong/thisinh");
            foreach (XmlNode node in nodelist)
            {
                string mats = node["mats"].InnerText;
                string hoten = node["hoten"].InnerText;
                string gioitinh = node["gioitinh"].InnerText;
                float diemlt = float.Parse(node["diemlt"].InnerText);
                float diemth = float.Parse(node["diemth"].InnerText);
                ThiSinh ts = new ThiSinh(mats, hoten, gioitinh, diemlt, diemth);
                LST1.Add(ts);
            }
        }
        public void XuatDS()
        {
            for(int i = 0; i< LST1.Count; i++)
            {
                LST1[i].Xuat();
            }
        }

        public DSThiSinh DSThiSinhDat()
        {
            DSThiSinh ds1 = new DSThiSinh();
            ds1.LST1 = LST1.Where(s => s.XetTuyen() == "Dau").ToList();
            return ds1;
        }

        public void SoThiSinhDauRot()
        {
            int Dau = LST1.Count(s => s.XetTuyen() == "Dau");
            int Rot = LST1.Count(s => s.XetTuyen() == "Rot");
            Console.WriteLine("So thi sinh dau: {0}", Dau);
            Console.WriteLine("So thi sinh rot: {0}", Rot);
        }

        public ThiSinh TimThiSinh()
        {
            Console.Write("Nhap vao ma thi sinh can tim: ");
            string mts = (Console.ReadLine());
            ThiSinh ts = new ThiSinh();
            ts = LST1.FirstOrDefault(s => s.MaThiSinh == mts);
            if(ts != null)
            {
                Console.WriteLine("Thi sinh can tim");
                ts.Xuat();
                return ts;
            }
            else
            {
                Console.WriteLine("Khong tim thay thong tin");
                return null;
            }
        }

        public DSThiSinh SapXepGiam()
        {
            DSThiSinh ds1 = new DSThiSinh();
            ds1.LST1 = LST1.OrderByDescending(s => s.DiemTongKet()).ToList();
            return ds1;
        }
    }
}
