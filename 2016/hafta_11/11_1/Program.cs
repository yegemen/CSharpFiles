using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeline daki alan hesapla metodunun üzerine mouse ile gel.

            dortgen nesne1 = new dortgen();
            dortgen nesne2 = new dortgen(4,8);
            //nesne2.Boy = 50;
            //nesne2.En = 20;
            nesne1.En = 5;
            nesne1.Boy = 10;
            Console.WriteLine(nesne2.AlanHesapla());
            Console.WriteLine(nesne1.AlanHesapla());
            nesne1.BilgiYaz();
            nesne2.BilgiYaz();
            Console.WriteLine(nesne2.CevreHesapla());
            Console.ReadLine();
        }
    }
}
