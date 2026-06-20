using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _51_NguyenNhatMinhQuan_Tuan02
{
    internal class CongTy
    {
        List<NhanVien> Lst_DSNV;
        public CongTy()
        {
            Lst_DSNV = new List<NhanVien>();
        }

        public void NhapDSNV()
        {
            int n;
            Console.Write("Nhap vao so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine("Nhap vao nhan vien thu {0}: ", i + 1);
                NhanVien nhanVien = new NhanVien();
                nhanVien.Nhap();
                Lst_DSNV.Add(nhanVien);
            }
        }
                
        public void DocFileXML(string filepath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);
            XmlNodeList nodelist = doc.SelectNodes("/congty/nhanvien");
            foreach(XmlNode node in nodelist)
            {
                string maso = node["maso"].InnerText;
                string ten = node["ten"].InnerText;
                float hsl = float.Parse(node["hsl"].InnerText);
                int nvl = int.Parse(node["nvl"].InnerText);
                NhanVien nv = new NhanVien(maso, ten, hsl, nvl);
                Lst_DSNV.Add(nv);
            }
        }
        public void XuatDSNV()
        {
            Console.WriteLine("Danh sach nhan vien: ");
            for (int i = 0; i< Lst_DSNV.Count; i++)
            {
                Lst_DSNV[i].Xuat();
            }
        }
       
        public float TongLuong()
        {
            return Lst_DSNV.Sum(s => s.LuongNV());
        }

        public float TimLuongCaoNhat()
        {
            return Lst_DSNV.Max(s => s.LuongNV());
        }

        public NhanVien TimNVMaxLuong()
        {
            float MaxLuong = TimLuongCaoNhat();
            NhanVien nv = Lst_DSNV.FirstOrDefault(s => s.LuongNV() == MaxLuong);
            return nv;
        }

        public CongTy DSNVSort()
        {
            CongTy ds1 = new CongTy();
            ds1.Lst_DSNV = Lst_DSNV.OrderBy(s => s.NamVaoLam).ToList();
            return ds1;
        }
    }
}
