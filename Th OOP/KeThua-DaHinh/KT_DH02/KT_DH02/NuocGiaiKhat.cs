using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_DH02
{
    internal class NuocGiaiKhat : HangHoa
    {
        string donViTinh;
        int soLuong;
        float donGia;
        public static float TiLeChietKhau = 0.05f;

        public string DonViTinh
        {
            get { return donViTinh; }
            set
            {
                if(string.Compare(value,"Ket",true) == 0 || string.Compare(value, "Thung", true) == 0 || string.Compare(value, "Chai", true) == 0 || string.Compare(value, "Lon", true) == 0)
                    donViTinh = value;
                else
                {
                    Console.WriteLine("Don vi tinh khong hop le!");
                    donViTinh = "Ket";
                }
            }
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }

        public NuocGiaiKhat()
        {
            DonViTinh = "Thung";
            SoLuong = 5;
            DonGia = 150000f;
        }

        public NuocGiaiKhat(string maHang, string tenHang, string donViTinh, int soLuong, float donGia) : base(maHang, tenHang)
        {
            DonViTinh = donViTinh;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public float ThanhTien()
        {
            if (string.Compare(DonViTinh, "Ket", true) == 0 || string.Compare(DonViTinh, "Thung", true) == 0)
                return SoLuong * DonGia;
            else if (string.Compare(DonViTinh, "Chai", true) == 0)
                return SoLuong * DonGia / 20;
            else
                return SoLuong * DonGia / 24;
        }

        public float TongTien()
        {
            return ThanhTien() * NuocGiaiKhat.TiLeChietKhau;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Don vi tinh: " + DonViTinh);
            Console.WriteLine("So luong: " + SoLuong);
            Console.WriteLine("Don gia: " + DonGia);
            Console.WriteLine("Tong tien: " + TongTien());
        }
    }
}
