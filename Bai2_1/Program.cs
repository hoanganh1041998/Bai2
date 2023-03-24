using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen duong a = ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Nhap vao so nguyen duong b = ");
            uint b = uint.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            uint tich_so = a * b;
            uint tong = a + b;
            Int64 hieu_ab = Convert.ToInt64(a) - Convert.ToInt64(b);
            float thuong_ab = a * 1f / b;
            Console.WriteLine("Ket qua cua cac phep tinh nhu sau: ");
            Console.WriteLine($"{a} + {b} = {tong}");
            Console.WriteLine($"{a} - {b} = {hieu_ab}");
            Console.WriteLine($"{b} - {a} = {0-hieu_ab}");
            Console.WriteLine($"{a} x {b} = {tich_so}");
            Console.WriteLine($"{a} : {b} = {thuong_ab}");
            Console.WriteLine($"{b} : {a} = {1/thuong_ab}");
            Console.ReadKey();
        }
    }
}
