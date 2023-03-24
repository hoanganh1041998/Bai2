using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Ho va ten hoc sinh: ");
            string ho_ten = Console.ReadLine();
            Console.Write("Lop: ");
            string lop = Console.ReadLine();
            Console.Write("Diem trung binh HK1: ");
            float dtb_hk1 = float.Parse(Console.ReadLine());
            Console.Write("Diem trung binh HK2: ");
            float dtb_hk2 = float.Parse(Console.ReadLine());
            float dtb_cn = (dtb_hk1 + dtb_hk2 * 2) / 3;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Diem trung binh ca nam cua {ho_ten} lop {lop} la: {dtb_cn} ");
            Console.ReadKey();
        }
    }
}
