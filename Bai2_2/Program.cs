using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai 1 canh cua hinh chu nhat: ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai canh con lai cua hinh chu nhat: ");
            uint b = uint.Parse(Console.ReadLine());
            uint dien_tich = a * b;
            uint chu_vi = (a + b) * 2;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Dien tich hinh chu nhat la: {dien_tich}");
            Console.WriteLine($"Chu vi hinh chu nhat la: {chu_vi}");
            Console.ReadKey();
        }
    }
}
