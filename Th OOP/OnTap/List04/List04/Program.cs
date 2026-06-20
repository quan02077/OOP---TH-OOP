using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSThiSinh ds1 = new DSThiSinh();
            ds1.DocFileXML(@"..\..\thiSinh.xml");
            Console.WriteLine("----DANH SACH THI SINH----");
            ds1.XuatDS();
            Console.WriteLine("----DANH SACH THI SINH DAU----");
            DSThiSinh dsDat = ds1.DSThiSinhDat();
            dsDat.XuatDS();
            Console.WriteLine("----SO THI SINH DAU, ROT----");
            ds1.SoThiSinhDauRot();
            Console.WriteLine("----THI SINH CAN TIM----");
            ThiSinh ts = ds1.TimThiSinh();
            Console.WriteLine("----DANH SACH THI SINH SAP XEP GIAM DAN THEO DIEM TONG KET----");
            DSThiSinh dsSapXep = ds1.SapXepGiam();
            dsSapXep.XuatDS();

            Console.ReadKey();
        }
    }
}
