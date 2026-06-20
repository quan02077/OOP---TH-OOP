using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _51_NguyenNhatMinhQuan_Tuan05
{
    internal class CongTy
    {
        List<NhanVien> dsNhanVien;

        internal List<NhanVien> DsNhanVien { get => dsNhanVien; set => dsNhanVien = value; }

        public CongTy()
        {
            DsNhanVien = new List<NhanVien>();
        }

        public void DocFileXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList nodeList = doc.SelectNodes("/congty/nhanvien");
            foreach (XmlNode node in nodeList)
            {
                NhanVien nv;
                string loai = node["loai"].InnerText;
                string maNV = node["manv"].InnerText;
                string hoTen = node["hoten"].InnerText;
                int namSinh = int.Parse(node["namsinh"].InnerText);
                string gioiTinh = node["gioitinh"].InnerText;
                float heSoLuong = float.Parse(node["hesoluong"].InnerText);
                int namVaoLam = int.Parse(node["namvaolam"].InnerText);
                if (loai == "1")
                {
                    int sonn = int.Parse(node["sonn"].InnerText);
                    nv = new NhanVienSX(maNV, hoTen, namSinh, gioiTinh, heSoLuong, namVaoLam, sonn);
                }
                else if (loai == "2")
                {
                    int dsbh = int.Parse(node["dsbh"].InnerText);
                    int dstt = int.Parse(node["dstt"].InnerText);
                    nv = new NhanVienKD(maNV, hoTen, namSinh, gioiTinh, heSoLuong, namVaoLam, dsbh, dstt);
                }
                else
                {
                    string chucVu = node["chucvu"].InnerText;
                    float heSoCV = float.Parse(node["hesocv"].InnerText);
                    nv = new CanBoQL(maNV, hoTen, namSinh, gioiTinh, heSoLuong, namVaoLam, chucVu, heSoCV);
                }
                DsNhanVien.Add(nv);
            }
        }

        public void XuatDS()
        {
            for(int i = 0; i < DsNhanVien.Count; i++)
            {
                DsNhanVien[i].Xuat();
                Console.WriteLine();
            }
        }

        public double TongThuNhap()
        {
            return DsNhanVien.Sum(s => s.Luong());
        }
    }
}
