using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //HoaDon hd = new KhachHangCaNhan();
            //hd.Xuat();

            //HoaDon hd1 = new DaiLyCap1();
            //hd1.Xuat();

            //HoaDon hd2 = new KhachHangLaCTY();
            //hd2.Xuat();

            QuanLyThongTIn tt = new QuanLyThongTIn();
            Console.WriteLine("----Thông tin công ty && danh sách hóa đơn----");
            tt.DocFileXml(@"..\..\DsHoaDon.xml");
            tt.XuatDS();

            HoaDon hd = tt.KHSLMuaMax();
            Console.WriteLine("----Thông tin khách hàng có số lượng mua nhiều nhất----");
            hd.Xuat();
            Console.WriteLine();

            Console.WriteLine("Tổng chiết khấu của khách hàng là công ty: {0:N0}",tt.TongChietKhau());
            Console.WriteLine();

            tt.ThongTinKHDaiLy1();

            QuanLyThongTIn tt1 = tt.SapXep();
            Console.WriteLine("----Danh sách sau khi sắp xếp----");
            tt1.XuatDS();

            Console.WriteLine("----Thong tin can tim----");
            tt.XuatThongTinTheoMaX();
            Console.ReadKey();
        }
    }
}
