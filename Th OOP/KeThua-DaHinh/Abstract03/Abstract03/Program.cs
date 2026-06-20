using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.DocFileXml(@"..\..\monHoc.xml");
            Console.WriteLine("----Thong tin mon hoc----");
            sv.XuatDS();

            Console.WriteLine("Hoc phi cua sinh vien: {0:N0}", sv.TongHocPhi());
            Console.WriteLine("GPA cua sinh vien: {0:F2}", sv.GPA());
            Console.ReadKey();
        }
    }
}
