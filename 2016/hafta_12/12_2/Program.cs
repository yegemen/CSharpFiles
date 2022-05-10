using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            arac otomobil = new arac();
            otomobil.Yakit = 90;
            Console.WriteLine("otomobilin gideceği mesafe : {0}", otomobil.MaksimumMesafe);
            otomobil.HareketEt(100);
            Console.WriteLine("otomobilin gideceği mesafe : {0}", otomobil.MaksimumMesafe);
            otomobil.Yakit = 40;
            otomobil.Renk = "kırmızı";
            Console.WriteLine("otomobilin gideceği mesafe : {0}", otomobil.MaksimumMesafe);
            Console.WriteLine("otomobilin rengi= " + otomobil.Renk);
            Console.ReadLine();

        }
    }
}
