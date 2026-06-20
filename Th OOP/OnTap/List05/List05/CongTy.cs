using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace List05
{
    internal class CongTy
    {
        List<NhanVien> DSnhanvien = new List<NhanVien>();

        public CongTy()
        {
            DSnhanvien = new List<NhanVien>();
        }

        public void Nhap()
        {
            Console.Write("Nhap vao so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao nhan vien thu {i+1}", i);
                NhanVien nv = new NhanVien();
                nv.Nhap();
                DSnhanvien.Add(nv);
            }
        }
        public void DocFileXML(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList nodeList = doc.SelectNodes("/congty/nhanvien");
            foreach (XmlNode node in nodeList)
            {
                string manv = node["manv"].InnerText;
                string tennv = node["tennv"].InnerText;
                string phongban = node["phongban"].InnerText;
                string chucvu = node["chucvu"].InnerText;
                float hesoluong = float.Parse(node["hesoluong"].InnerText);
                int thamniencongtac = int.Parse(node["thamniencongtac"].InnerText);
                int songaylam = int.Parse(node["songaylam"].InnerText);
                NhanVien nv = new NhanVien(manv, tennv, phongban, chucvu, hesoluong, thamniencongtac, songaylam);
                DSnhanvien.Add(nv);
            }
        }
        public void XuatDS()
        {
            Console.WriteLine("----Danh sach nhan vien----");
            for (int i = 0; i < DSnhanvien.Count; i++)
            {
                DSnhanvien[i].Xuat();
            }
        }

        public void NhanVienTheoHeSoThiDua()
        {
            var nhom = DSnhanvien.GroupBy(s => s.HeSoThiDua());

            foreach (var g in nhom)
            {
                Console.WriteLine($"\n--- Nhom he so  {g.Key} ---");
                foreach (var nv in g)
                {
                    nv.Xuat();
                }
            }
        }

        public CongTy DSNhanVienPhongBan()
        {
            Console.Write("Nhap vao phong ban can xuat danh sach: ");
            string tenPhong = Console.ReadLine();
            CongTy ct = new CongTy();
            ct.DSnhanvien = DSnhanvien.Where(s => s.PhongBan == tenPhong).ToList();
            return ct;
        }

        public CongTy DSLanhDao()
        {
            CongTy ct = new CongTy();
            ct.DSnhanvien = DSnhanvien.Where(s => s.ChucVu == "Lanh dao").ToList();
            return ct;
        }

        public float TongLuong()
        {
            return DSnhanvien.Sum(s => s.Luong());
        }

        public CongTy XoaNhanVien()
        {
            CongTy ct = new CongTy();
            ct.DSnhanvien = DSnhanvien.Where(s => s.SoNgayLam > 10).ToList();
            return ct;
        }

        public CongTy DSnhanvienlonhon22()
        {
            CongTy ct = new CongTy();
            ct.DSnhanvien = DSnhanvien.Where(s => s.ChucVu == "Nhan vien" && s.SoNgayLam > 22).ToList();
            return ct;
        }

        public CongTy DSnhanvienhesoluong()
        {
            CongTy ct = new CongTy();
            ct.DSnhanvien = DSnhanvien.Where(s => s.HeSoLuong >= 4.34 && s.PhongBan == "Tai vu").ToList();
            return ct;
        }
    }
}
