using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace List
{
    internal class HocSinh
    {
        string maHS;
        string tenHs;
        List<MonHoc> dsMH = new List<MonHoc>();

        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHs { get => tenHs; set => tenHs = value; }
        internal List<MonHoc> DsMH { get => dsMH; set => dsMH = value; }

        public HocSinh()
        {
            MaHS = "2001240388";
            TenHs = "Nguyen Van A";
            DsMH = new List<MonHoc>();
        }

        public void NhapHS()
        {
            Console.Write("Nhap ma hoc sinh: ");
            maHS = Console.ReadLine();
            Console.Write("Nhap ten hoc sinh: ");
            tenHs = Console.ReadLine();
            int n;
            Console.Write("Nhap vao so mon hoc: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                Console.Write("Nhap vao thong tin mon hoc thu {0}: ", i + 1);
                MonHoc mh = new MonHoc();
                mh.Nhap();
                DsMH.Add(mh);
            }
        }

        public void DocFileXML(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList nodelist = doc.SelectNodes("/truong/hocsinh");
            foreach (XmlNode node in nodelist)
            {
                MaHS = node["mahs"].InnerText;
                TenHs = node["tenhs"].InnerText;
                XmlNodeList monhocNodes = node.SelectNodes("monhoc");
                foreach (XmlNode mhNode in monhocNodes)
                {
                    string mamh = mhNode["mamh"].InnerText;
                    string tenmh = mhNode["tenmh"].InnerText;
                    float diemtx = float.Parse(mhNode["diemtx"].InnerText);
                    float diemgk = float.Parse(mhNode["diemgk"].InnerText);
                    float diemck = float.Parse(mhNode["diemck"].InnerText);

                    MonHoc mh = new MonHoc(mamh, tenmh, diemtx, diemgk, diemck);
                    DsMH.Add(mh);
                }
            }
        }

        public void XuatHS()
        {
            Console.WriteLine("----- Thong tin hoc sinh -----");
            Console.WriteLine("Ma hoc sinh: {0}", MaHS);
            Console.WriteLine("Ten hoc sinh: {0}", TenHs);
            for(int i = 0; i < DsMH.Count; i++)
            {
                Console.WriteLine("Thong tin mon hoc thu {0}: ", i + 1);
                DsMH[i].Xuat();
            }
        }

        public float DiemTrungBinh()
        {
            return DsMH.Average(s => s.DiemTongKet());
        }

        public string XepLoai()
        {
            bool monDuoi65 = DsMH.Any(s => DiemTrungBinh() < 6.50);
            bool monDuoi5 = DsMH.Any(s => DiemTrungBinh() < 5.00);
            bool monDuoi35 = DsMH.Any(s => DiemTrungBinh() < 3.50);
            bool monDuoi2 = DsMH.Any(s => DiemTrungBinh() < 2.00);

            if (DiemTrungBinh() >= 8.00 && !monDuoi65)
                return "Gioi";
            else if (DiemTrungBinh() >= .650 && !monDuoi5)
                return "Kha";
            else if (DiemTrungBinh() >= 5.00 && !monDuoi35)
                return "Trung binh";
            else if (DiemTrungBinh() >= 3.50 && !monDuoi2)
                return "Yeu";
            else
                return "Kem";
        }

        public string KetQuaHS()
        {
            if (XepLoai() == "Gioi" || XepLoai() == "Kha" || XepLoai() == "Trung binh")
                return "Duoc len lop";
            else if (XepLoai() == "Yeu")
                return "Thi lai";
            else
                return "O lai lop";
        }
        public void MonHocDat()
        {
            Console.WriteLine("Danh sach cac mon hoc co ket qua dat cua hoc sinh");
            if(!DsMH.Any(s => s.KetQua() == "Dat!"))
            {
                Console.WriteLine("Hoc sinh khong co mon nao dat!");
            }
            else
            {
                DsMH.Where(s => s.KetQua() == "Dat!").ToList().ForEach(s => s.Xuat());      
            }
        }
    }
}
