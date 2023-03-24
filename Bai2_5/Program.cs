using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai2_5
{
    internal class Program
    {
        struct ThongTinNhanVien
        {
            public string hoTen;
            public string gioiTinh;
            public DateTime ngaySinh;
            public float HSL;
            public float LCB;
            public float soNam;
            public float PC;
            public float tamTinh;
            public float Luong;
        };

        static void nhap_thong_tin(out ThongTinNhanVien NV)
        {
            NV = new ThongTinNhanVien();
            Console.Write("Ho ten: ");
            NV.hoTen = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            NV.gioiTinh = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            NV.ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Luong co ban la: ");
            NV.LCB = float.Parse(Console.ReadLine());
            Console.Write("He so luong: ");
            NV.HSL = float.Parse(Console.ReadLine());
            Console.Write("So nam lam viec: ");
            NV.soNam = float.Parse(Console.ReadLine());
        }

        static void xuat_thong_tin(ThongTinNhanVien NV)
        {
            Console.WriteLine("Ho va ten: " + NV.hoTen);
            Console.WriteLine("Gioi tinh: " + NV.gioiTinh);
            Console.WriteLine("Luong co ban: " + NV.LCB);
            Console.WriteLine("He so luong: " + NV.HSL);
            Console.WriteLine("So nam lam viec: " + NV.soNam);

            if (NV.soNam >= 5)
            {
                NV.PC = NV.LCB / 2;
            }
            else
            {
                NV.PC = 0;
            }
            Console.WriteLine("Phu cap: " + NV.PC);

            NV.tamTinh = (int)Math.Ceiling(NV.LCB * NV.HSL);
            NV.Luong = NV.tamTinh + NV.PC;
            Console.WriteLine("Tam tinh: " + NV.tamTinh);
            Console.WriteLine("Tong luong: " + NV.Luong);
        }

        static void Main(string[] args)
        {
            ThongTinNhanVien NV1 = new ThongTinNhanVien();
            Console.WriteLine("Nhap thong tin nhan vien 1: ");
            nhap_thong_tin(out NV1);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Thong tin nhan vien 1 la:");
            xuat_thong_tin(NV1);
            Console.ReadLine();
            ThongTinNhanVien NV2 = new ThongTinNhanVien();
            Console.WriteLine("Nhap thong tin nhan vien 2: ");
            nhap_thong_tin(out NV2);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Thong tin nhan vien 2 la:");
            xuat_thong_tin(NV2);
            Console.ReadLine();
        }
    }
}