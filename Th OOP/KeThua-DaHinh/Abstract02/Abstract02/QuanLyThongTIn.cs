using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Abstract02
{
    internal class QuanLyThongTIn
    {
        string tenCTY;
        string sDT;
        string diaChi;
        List<HoaDon> dsHoaDon = new List<HoaDon>();

        public string TenCTY { get => tenCTY; set => tenCTY = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        internal List<HoaDon> DsHoaDon { get => dsHoaDon; set => dsHoaDon = value; }

        public QuanLyThongTIn()
        {
            tenCTY = string.Empty;
            sDT = string.Empty;
            diaChi = string.Empty;
            DsHoaDon = new List<HoaDon>();
        }

        public void DocFileXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            TenCTY = doc.SelectSingleNode("/congty/tencty").InnerText;
            SDT = doc.SelectSingleNode("/congty/sdt").InnerText;
            DiaChi = doc.SelectSingleNode("/congty/diachi").InnerText;
            XmlNodeList nodelist = doc.SelectNodes("/congty/dshoadon/kh");
            foreach(XmlNode node in nodelist)
            {
                HoaDon hd;
                string makh = node["makh"].InnerText;
                string tenkh = node["tenkh"].InnerText;
                int soluong = int.Parse(node["soluong"].InnerText);
                int giaban = int.Parse(node["giaban"].InnerText);
                string loai = string.Empty;
                loai = node.Attributes["loai"].Value;
                if(loai == "Ca nhan")
                {
                    int khoangcach = int.Parse(node["khoangcach"].InnerText);
                    hd = new KhachHangCaNhan(makh, tenkh, soluong, giaban, khoangcach);
                }
                else if(loai == "Dai ly")
                {
                    int thoigian = int.Parse(node["thoigianht"].InnerText);
                    hd = new DaiLyCap1(makh, tenkh, soluong, giaban, thoigian);
                }
                else
                {
                    int soluongnv = int.Parse(node["soluongnv"].InnerText);
                    hd = new KhachHangLaCTY(makh, tenkh, soluong, giaban, soluongnv);
                }
                DsHoaDon.Add(hd);
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("Ten cong ty: " + TenCTY);
            Console.WriteLine("So dien thoai: " + SDT);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine();
            for(int i = 0; i < DsHoaDon.Count; i++)
            {
                DsHoaDon[i].Xuat();
                Console.WriteLine();
            }
        }

        public HoaDon KHSLMuaMax()
        {
            return DsHoaDon.OrderByDescending(s => s.SoLuong).FirstOrDefault();
        }

        public double TongChietKhau()
        {
            return DsHoaDon.OfType<KhachHangLaCTY>().Sum(s => s.ChietKhau());
        }

        public void ThongTinKHDaiLy1()
        {
            List<DaiLyCap1> DsDL = DsHoaDon.OfType<DaiLyCap1>().ToList();
            int soLuongKH = DsDL.Count;
            Console.WriteLine("----Thong tin khach hang la dai ly 1 cua cong ty----");
            Console.WriteLine("Tong so khach hang la: " + soLuongKH);

            for(int i = 0; i < DsHoaDon.Count; i++)
            {
                if (DsHoaDon[i] is DaiLyCap1)
                {
                    DsHoaDon[i].Xuat();
                    Console.WriteLine();
                }
            }
        }

        public QuanLyThongTIn SapXep()
        {
            QuanLyThongTIn ds = new QuanLyThongTIn();
            ds.DsHoaDon = DsHoaDon.OrderBy(s => s.SoLuong).ThenByDescending(s => s.ThanhTien()).ToList();
            return ds;
        }

        public void XuatThongTinTheoMaX()
        {
            Console.Write("Nhap vao ma khach hanh can tim: ");
            string maX = Console.ReadLine();
            List<HoaDon> Kh = DsHoaDon.Where(s => s.MaKH == maX).ToList();
            if(Kh .Count == 0)
            {
                Console.WriteLine("Khach hang la!");
            }
            else
            {
                foreach (HoaDon hd in Kh)
                    hd.Xuat();
            }
        }
    }
}
