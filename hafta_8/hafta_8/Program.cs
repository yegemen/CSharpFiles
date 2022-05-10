using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_8
{

    public abstract class Kisi //abstrac olarak tanımlanan metotların hepsinin ezdirilmesi gerekir.
    {

        public string AdSoyad;

        public abstract string Meslek
        {
            get;
        }

        public abstract int Yas();

        public virtual void Yaz() // Polymorphism
        {
            Console.WriteLine("Adı Soyadı: " + AdSoyad);
            Console.WriteLine("Meslek: " + Meslek);
        }



    }

    public class Ogrenci : Kisi
    {
        public int sinif;

        public Ogrenci()
        {
            this.sinif = 3;
        }

        public override string Meslek
        {
            get { return "ogrenci"; }
        }

        public override int Yas()
        {
            return 21;
        }

        public override void Yaz()
        {
            base.Yaz();
            Console.WriteLine("Sınıf: " + sinif);
        }
    }

    public class Ogretmen : Kisi
    {
        public string brans;

        public override string Meslek
        {
            get { return "Ogretmen "; }
        }

        public override int Yas()
        {
            return 45;
        }
        public override void Yaz()
        {
            base.Yaz();
            Console.WriteLine("Branş: {0}", brans);
        }
    }

    public class GeriDonusTipleri
    {
        public Ogretmen OgretmenBilgileriDondur(Ogretmen ogretmen)
        {
            ogretmen.AdSoyad = "Sefa Tuncer";
            ogretmen.brans = "Bilgisayar Mühendisi";
            return ogretmen;
        }

        public Ogrenci OgrenciOlustur()
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                AdSoyad = "Ahmet Yüksel",
                sinif = 4
            };
            // ogrenci.AdSoyad = "Ahmet Yüksel";
            return ogrenci;
        }

        public Ogrenci OgrenciOlustur2()
        {
            return new Ogrenci()
            {
                AdSoyad = "Ahmet Yüksel",
                sinif = 4
            };
        }

        public List<string> IsimListesi(Ogretmen ogretmen, Ogrenci ogrenci)
        {
            List<string> liste = new List<string>();
            liste.Add(ogretmen.AdSoyad);
            liste.Add(ogrenci.AdSoyad);
            return liste;
        }

        public void EkranaYaz(Ogretmen ogretmen, Ogrenci ogrenci)
        {
            Console.WriteLine("Ogretmen adı Soyadı: " + ogretmen.AdSoyad);
            Console.WriteLine($"Ogrenci adı Soyadı: {ogrenci.AdSoyad}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1; //instance

            Ogrenci ogr1 = new Ogrenci()
            {
                AdSoyad = "Ahmet Yüksel",
                sinif = 3
            };
            ogr1.Yaz();

            Ogrenci[] ogrenciler = new Ogrenci[5];
            List<Ogrenci> liste = new List<Ogrenci>();

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                ogrenciler[i] = new Ogrenci();
                Console.WriteLine("{0}. öğrenci adı soyadı: ", (i + 1));
                ogrenciler[i].AdSoyad = Console.ReadLine();
                liste.Add(ogrenciler[i]);
            }

            Console.WriteLine("**************************************");

            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman.AdSoyad);
                Console.WriteLine(eleman.sinif);
            }

            Console.WriteLine("**************************************");

            Ogretmen ogretmen1 = new Ogretmen()
            {
                AdSoyad = "Mustafa Ersoy",
                brans = "Bilgisayar Ogretmeni"
            };
            ogretmen1.Yaz();

            GeriDonusTipleri gdt = new GeriDonusTipleri();
            Ogretmen ogretmen2 = gdt.OgretmenBilgileriDondur(ogretmen1);
            Ogrenci ogrenci2 = gdt.OgrenciOlustur2();

            List<string> liste2  = gdt.IsimListesi(ogretmen2, ogrenci2);

            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }

            gdt.EkranaYaz(ogretmen2, ogrenci2);

        }
    }
}
