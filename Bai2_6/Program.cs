using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ngay: ");
            string ngay = Console.ReadLine();
            Console.Write("Nhap vao thang: ");
            string thang = Console.ReadLine();
            Console.Write("Nhap vao nam: ");
            string nam = Console.ReadLine();
            var date = DateTime.Parse(thang + "/" + ngay + "/" + nam);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ngay hom qua la:\t{0}", date.AddDays(-1).ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay hom nay la:\t{0}", date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay mai la: \t{0}", date.AddDays(+1).ToString("dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
