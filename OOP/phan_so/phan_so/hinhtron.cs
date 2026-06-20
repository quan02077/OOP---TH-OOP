using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phan_so
{
    internal class hinhtron
    {
        public double r;
        public double Tinhchuvi()
        {
            return 2 * Math.PI * r;
        }
        public double Tinhdientich()
        {
            return Math.PI * r * r;
        }
    }
    class program
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao ban kinh: ");
            double r = double.Parse(Console.ReadLine());
            hinhtron ht = new hinhtron();
            ht.r = r;
            Console.WriteLine($"Chu vi: {ht.Tinhchuvi():F2}");
            Console.WriteLine($"Dien tich: {ht.Tinhdientich():F2}");
        }
    }
}
