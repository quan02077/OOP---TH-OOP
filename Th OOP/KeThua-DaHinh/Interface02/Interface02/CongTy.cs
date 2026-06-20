using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface02
{
    internal class CongTy
    {
        List<BatDongSan> dsBDS;

        internal List<BatDongSan> DsBDS { get => dsBDS; set => dsBDS = value; }

        public CongTy()
        {
            DsBDS = new List<BatDongSan>();
        }

        public void DocFileXml(string fielPath)
        {
            BatDongSan bds;
            XmlDocument doc = new XmlDocument();
            doc.Load(fielPath);
            XmlNodeList nodeList = doc.SelectNodes("/congty/bds");
            foreach (XmlNode node in nodeList)
            {
                string loai = node["loai"].InnerText;
                string maSo = node["ma"].InnerText;
                float dai = float.Parse(node["dai"].InnerText);
                float rong = float.Parse(node["rong"].InnerText);
                if (loai == "1")
                    bds = new DatTrong(maSo, dai, rong);
                else if (loai == "2")
                {
                    int soLau = int.Parse(node["solau"].InnerText);
                    bds = new NhaO(maSo, dai, rong, soLau);
                }
                else if (loai == "3")
                {
                    int soSao = int.Parse(node["sosao"].InnerText);
                    bds = new KhachSan(maSo, dai, rong, soSao);
                }
                else
                    bds = new BietThu(maSo, dai, rong);
                DsBDS.Add(bds);
            }
        }

        public void XuatDS()
        {
            for(int i = 0; i< DsBDS.Count; i++) 
                DsBDS[i].Xuat();
        }

        public double TongGiaBan()
        {
            return DsBDS.Sum(s => s.GiaBan());
        }

        public double TongPhiKD()
        {
            double tongPhi = DsBDS.OfType<IPhiKD>().Sum(s => s.PhiKD());
            return tongPhi;
        }
    }
}
