using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane;

namespace _14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            arac nesne = new arac();
            //nesne.Ad = "Tank";
            //nesne.AtesEt();

            Tank altay = new Tank();
            altay.Ad = "altay tank";
            //altay.AtesEt();
            //altay.HareketEt();
            //altay.PaletSayisi = 23;

            Ucak f16 = new Ucak();
            f16.Ad = "F16";
            //f16.BombaSayisi = 10;
            //f16.BombaBirak(5);
            //f16.HareketEt();
            //f16.AtesEt();

            nesne = altay;
            nesne.HareketEt();
            nesne.AtesEt();

            nesne = f16;
            nesne.HareketEt();
            nesne.AtesEt();          

            Console.ReadLine();

            
        }
    }
}
