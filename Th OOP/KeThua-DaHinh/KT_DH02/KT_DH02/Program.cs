using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangHoa hh = new HangHoa();
            Console.WriteLine("Thong tin hang hoa: ");
            hh.Xuat();

            NuocGiaiKhat ng = new NuocGiaiKhat();
            Console.WriteLine("Thong tin nuoc giai khat: ");
            ng.Xuat();

            Console.ReadKey();
        }
    }
}
