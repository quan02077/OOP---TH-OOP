using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CongTy ct1 = new CongTy();
            ct1.DocFileXML(@"..\..\congTy.xml");
            ct1.XuatDS();

            Console.WriteLine("----Danh sach nhan vien theo nhom he so thi dua----");
            ct1.NhanVienTheoHeSoThiDua();
            Console.WriteLine("----Danh sach nhan vien theo phong ban----");
            CongTy nvtim = ct1.DSNhanVienPhongBan();
            nvtim.XuatDS();
            Console.WriteLine("----Danh sach nhan vien co chuc vu lanh dao----");
            CongTy lanhdao = ct1.DSLanhDao();
            lanhdao.XuatDS();
            Console.WriteLine("Tong luong cong ty phai tra cho nhan vien: {0}", ct1.TongLuong());
            Console.WriteLine("----Danh sach sau khi xoa nhung nhan vien co so ngay lam < 10----");
            CongTy xoanv = ct1.XoaNhanVien();
            xoanv.XuatDS();
            Console.WriteLine("----Danh sach nhan vien khong phai lanh dao co so ngay lam > 22----");
            CongTy dsnv = ct1.DSnhanvienlonhon22();
            dsnv.XuatDS();
            Console.WriteLine("----Danh sach nhan vien co he so luong > 4.34 va o phong tai vu----");
            CongTy dshsl = ct1.DSnhanvienhesoluong();
            dshsl.XuatDS();
            Console.ReadKey();
        }
    }
}
