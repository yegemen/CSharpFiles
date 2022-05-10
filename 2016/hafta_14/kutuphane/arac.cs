using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane
{
    public class arac
    {
        public int YolcuSayisi { get; set; }
        public string Renk { get; set; }
        public string Ad { get; set; }

        public virtual void HareketEt() //diğer türetilen sınıflarda değiştirilecek ek özellikler eklenmesi sağlıyor.
        {
            Console.WriteLine(Ad + " aracı hareket etti.");
        }
        public virtual void AtesEt()
        {
            Console.WriteLine(Ad + " aracı ateş etti.");
        }
    }
    public class Tank : arac //iki nokta ile araç sınıfının tüm özelliklerini yeni oluşan tank sınıfına dahil ettik.
    {
        public int PaletSayisi { get; set; }
        public void KuleDondur()
        {
            Console.WriteLine(Ad + " Kulesi Döndürüldü.");
        }
        public override void AtesEt() //ateşet metodu yeniden yüklendi(aşırı yükleme), önceki metodu ezilerek(override) yeniden kullanıldı.
        {
            Console.WriteLine(" tankın topu ateşlendi, hedef isabetle vuruldu.");
        }
        public override void HareketEt()
        {
            Console.WriteLine("tankın paletleri hareket etti.");
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
        public override void HareketEt()
        {
            Console.WriteLine("uçak yeniden havalandı. 1000m yüksekliğe ulaştı.");
        }
        public override void AtesEt()
        {
            Console.WriteLine("lazer güdümlü bomba ateşlendi.");
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
