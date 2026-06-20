using System;

namespace phan_so
{
    internal class PhanSo
    {
        int tuso;
        int mauso;

        public void Nhap()
        {
            Console.Write("Nhap vao tu so: ");
            tuso = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap vao mau so (khac 0): ");
                mauso = int.Parse(Console.ReadLine());
            } while (mauso == 0);
        }

        public void Xuat()
        {
            Console.WriteLine($"{tuso}/{mauso}");
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(tuso), Math.Abs(mauso));
            tuso /= ucln;
            mauso /= ucln;

            if (mauso < 0) 
            {
                tuso = -tuso;
                mauso = -mauso;
            }
        }
    }

    class Program
    {
        static void Minh(string[] args)
        {
            PhanSo ps = new PhanSo();
            ps.Nhap();
            Console.Write("Phan so vua nhap: ");
            ps.Xuat();

            ps.RutGon();
            Console.Write("Phan so sau khi rut gon: ");
            ps.Xuat();

            Console.ReadLine(); 
        }
    }
}
