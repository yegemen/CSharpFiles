using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuhane_13_2;

namespace _13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //arac nesne = new arac();
            //nesne.Ad = "tank";
            //nesne.Renk = "yeşil";
            //nesne.YolcuSayisi = 3;
            //nesne.HareketEt();
            //nesne.AtesEt();

            Tank tank = new Tank();
            tank.Ad = "Altay";
            tank.Renk = "siyah";
            tank.YolcuSayisi = 3;
            tank.HareketEt();
            tank.AtesEt();
            tank.PaletSayisi = 23;

            Ucak f16 = new Ucak();
            f16.Ad = "F16";
            f16.HareketEt();
            f16.BombaSayisi = 10;
            f16.BombaBirak(f16.BombaSayisi); //veya f16.BombaBirak(50);

            Console.ReadLine();
        }
    }
}
