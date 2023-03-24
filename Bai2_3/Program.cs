using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap duong kinh hinh tron: ");
            uint duong_kinh = uint.Parse(Console.ReadLine());
            const float pi = 3.14f;
            float ban_kinh = duong_kinh * 1f / 2;
            float dien_tich = pi * duong_kinh * duong_kinh / 4;
            float chu_vi = pi * duong_kinh;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Hinh tron co ban kinh la: {ban_kinh}");
            Console.WriteLine($"Dien tich hinh tron ban kinh {ban_kinh} la {dien_tich}");
            Console.WriteLine($"Chu vi hinh tron ban kinh {ban_kinh} la {chu_vi}");
            Console.ReadKey();  
        }
    }
}
