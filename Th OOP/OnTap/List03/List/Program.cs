using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MonHoc mh1 = new MonHoc("MH9827", "Chu Nghia Xa Hoi Khoa Hoc");
            //mh1.Xuat();

            //MonHoc mh2 = new MonHoc("MH1234", "Tieng Tay", 3.75f, 5.50f, 7.50f);
            //mh2.Xuat();
            //HocSinh hs = new HocSinh();
            //hs.NhapHS();
            //hs.XuatHS();
            HocSinh hs = new HocSinh();
            hs.DocFileXML(@"..\..\hocSinh.xml");
            hs.XuatHS();
            Console.WriteLine("Diem trung binh: {0:N0}", hs.DiemTrungBinh());

            Console.WriteLine("Ket qua va xep loai cua hoc sinh");

            Console.WriteLine("Xep loai: {0}", hs.XepLoai());

            Console.WriteLine("Ket qua: {0}", hs.KetQuaHS());

            Console.Write("Nhap vao ma hoc sinh muon xem mon hoc DAT: ");
            string mhs;
            mhs = Console.ReadLine();
            if (hs.MaHS == mhs)
                hs.MonHocDat();
             else
            {
                Console.WriteLine("Khong tim thay hoc sinh voi ma {0}", mhs);
            }

            
            Console.ReadKey();
        }
    }
}
