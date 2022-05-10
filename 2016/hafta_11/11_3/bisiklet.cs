using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    class bisiklet
    {
        public string marka;
        public int hız;
        public int hızlanma;
        public string tur;
        public string frengucu;
        public string renk;
        public int modelyili;
        public int vitessayi;
        public int ivme()
        {
            return hız + hızlanma;
        }
        public void markayaz()
        {
            Console.WriteLine("bisikletin markası= " + marka);
        }
        public void hızyaz()
        {
            Console.WriteLine("bisikletin hızı= " + hız);
        }
        public void hızlanmayaz()
        {
            Console.WriteLine("bisikletin yeni hızı= " + ivme());
        }
        public void turyaz()
        {
            Console.WriteLine("bisikletin türü= " + tur);
        }
        public void frengucuyaz()
        {
            Console.WriteLine("bisikletin fren gücü= " + frengucu);
        }
        public void renkyaz()
        {
            Console.WriteLine("bisikletin rengi= " + renk);
        }
        public void modelyiliyaz()
        {
            Console.WriteLine("bisikletin modeli= " + modelyili);
        }
        public int yashesap()
        {
            return 2016 - modelyili;
        }
        public void yasyaz()
        {
            Console.WriteLine("bisikletin yaşı= " + yashesap());
        }
        public void vitessayiyaz()
        {
            Console.WriteLine("bisikletin vites sayısı= " + vitessayi);
        }

    }
}
