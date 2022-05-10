using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    class ogrenci
    {
        private string okulismi;
        private string il;
        private int kacincisinif;
        private int ogrsayi;
        private int yeniogr;
        private int mezunogr;

        public string Okulismi
        {
            get { return okulismi; }
            set { okulismi = value; }
        }
        public string Il
        {
            get { return il; }
            set { il = value; }
        }
        public int Kacincisinif
        {
            get { return kacincisinif; }
            set { kacincisinif = value; }
        }
        public void sinifduzey()
        {
            if (kacincisinif >= 1 && kacincisinif <= 8)
            {
                Console.WriteLine("ilköğretim");
            }
            if (kacincisinif >= 9 && kacincisinif <= 12)
            {
                Console.WriteLine("Lise");
            }
            if (kacincisinif >= 13)
            {
                Console.WriteLine("Üniversite");
            }
        }
        public int Ogrsayi
        {
            get { return ogrsayi; }
            set { ogrsayi = value; }
        }
        public int kacyildahavar()
        {
            return 16 - kacincisinif;
        }
        public void yaskac()
        {
            if (kacincisinif == 1)
            {
                Console.WriteLine("yaş 7");
            }
            if (kacincisinif == 2)
            {
                Console.WriteLine("yaş 8");
            }
            if (kacincisinif == 3)
            {
                Console.WriteLine("yaş 9");
            }
            if (kacincisinif == 4)
            {
                Console.WriteLine("yaş 10");
            }
            if (kacincisinif == 5)
            {
                Console.WriteLine("yaş 11");
            }
            if (kacincisinif == 6)
            {
                Console.WriteLine("yaş 12");
            }
            if (kacincisinif == 7)
            {
                Console.WriteLine("yaş 13");
            }
            if (kacincisinif == 8)
            {
                Console.WriteLine("yaş 14");
            }
            if (kacincisinif == 9)
            {
                Console.WriteLine("yaş 15");
            }
            if (kacincisinif == 10)
            {
                Console.WriteLine("yaş 16");
            }
            if (kacincisinif == 11)
            {
                Console.WriteLine("yaş 17");
            }
            if (kacincisinif == 12)
            {
                Console.WriteLine("yaş 18");
            }
            if (kacincisinif == 13)
            {
                Console.WriteLine("yaş 19");
            }
            if (kacincisinif == 14)
            {
                Console.WriteLine("yaş 20");
            }
            if (kacincisinif == 15)
            {
                Console.WriteLine("yaş 21");
            }
            if (kacincisinif == 16)
            {
                Console.WriteLine("yaş 22");
            }
        }
        public int Yeniogr
        {
            get { return yeniogr; }
            set { yeniogr = value; }
        }
        public int Mezunogr
        {
            get { return mezunogr; }
            set { mezunogr = value; }
        }
        public void yeniogrencisayi(int sonuc=0)
        {
            
            sonuc = ogrsayi;
            sonuc = sonuc + yeniogr;
            sonuc = sonuc - mezunogr;
            Console.WriteLine("Okulda "+sonuc+" tane öğrenci kaldı.");

        }
    }
}
