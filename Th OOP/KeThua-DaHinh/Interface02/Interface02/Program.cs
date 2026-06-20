using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CongTy ct = new CongTy();
            ct.DocFileXml(@"..\..\BDS.xml");
            Console.WriteLine("----Thong tin bat dong san---");
            ct.XuatDS();
            Console.WriteLine("Tong gia ban: {0:N0}", ct.TongGiaBan());
            Console.WriteLine("Tong phi kinh doanh: {0:N0}", ct.TongGiaBan());
            Console.ReadKey();
        }
    }
}
