using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuhane_13_2
{
    //kalıtım (miras-inheritance)
    public class arac
    {
        public int YolcuSayisi { get; set; }
        public string Renk { get; set; }
        public string Ad { get; set; }

        public void HareketEt()//geri değer döndürmeyen metot tanımladık
        {
            Console.WriteLine(Ad + " Aracı Hareket Etti !");
        }

        public void AtesEt()
        {
            Console.WriteLine(Ad + " Aracı Ateş Etti !");
        }
    }
    public class Tank : arac //Miras alarak class(sınıf) oluşturduk.
    {
        public int PaletSayisi { get; set; }
        public void KuleDondur()
        {
            Console.WriteLine(Ad + " Kulesi Döndürüldü.");
        }
    }
    public class Ucak : arac
    {
        public int KanatBoyu { get; set; }
        public int BombaSayisi { get; set; }
        public void BombaBirak(int bombasayisi)
        {
            Console.WriteLine(bombasayisi.ToString() + " bomba bırakıldı.");
        }

    }
    public class Otobus : arac
    {
        public int BagajHacmi { get; set; }
        public int KoltukSayisi { get; set; }
        public void YolcuIndir(int inenYolcuSayisi)
        {
            Console.WriteLine(inenYolcuSayisi.ToString() + " kadar yolcu indirildi.");
        }
    }
}
