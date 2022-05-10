using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region hesap makinesi
            /*int s1, s2, sonuc;
            char secim;
            Console.Write("Birinci sayıyı giriniz: ");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            s2=Convert.ToInt32(Console.ReadLine());
            Console.Write("\nseçim yapınız. \n\n toplama + ya bas\n çıkartma - ye bas\n çarpma * ya bas\n bölme / ye bas..\n\nSeçiminiz= ");
            secim = Convert.ToChar(Console.ReadLine());


            if (secim == '+' || secim == 't')
            {
                sonuc = s1 + s2;
                Console.Write("\n" + s1 + " + "+s2+" = " + sonuc);
            }
            else if (secim == '-' || secim == 'c')
            {
                sonuc = s1 - s2;
                Console.Write("\n" + s1 + " - " + s2 + " = " + sonuc);
            }
            else if (secim == '*' || secim == 'p')
            {
                sonuc = s1 * s2;
                Console.Write("\n" + s1 + " * " + s2 + " = " + sonuc);
            }
            else if (secim == '/' || secim == 'b')
            {
                sonuc = s1 / s2;
                Console.Write("\n" + s1 + " / " + s2 + " = " + sonuc);
            }
            else
            {
                Console.Write("doğru seçim yapınız.");
            }

            Console.ReadLine();*/
            #endregion

            #region not hesaplama
            /*double vize, final, ort;
            Console.Write("vize notunuzu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine()) * 0.40;
            Console.Write("final notunuzu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine()) * 0.60;
            ort = vize + final;
            if (ort >= 0 && ort <= 20)
            {
                Console.WriteLine("\nNotunuz: " + ort + " ile FF");
            }
            else if (ort >= 21 && ort <= 40)
            {
                Console.WriteLine("\nNotunuz: " + ort + " ile DD");
            }
            else if (ort >= 41 && ort <= 60)
            {
                Console.WriteLine("\nNotunuz: " + ort + " ile CC");
            }
            else if (ort >= 61 && ort <= 80)
            {
                Console.WriteLine("\nNotunuz: " + ort + " ile BB");
            }
            else if (ort >= 81 && ort <= 100)
            {
                Console.WriteLine("\nNotunuz: " + ort + " ile AA");
            }
            if (ort >= 65)
            {
                Console.Write("\nGeçtiniz.");
            }
            if (ort < 65)
            {
                Console.Write("\nKaldınız.");
            }
            Console.ReadLine();*/
            #endregion

            #region switch ile gün sayısı
            /*int gun;
            Console.Write("gün giriniz(1-7): ");
            gun = Convert.ToInt32(Console.ReadLine());
            switch(gun)
            {
                case 1: Console.Write("Pazartesi");
                    break;
                case 2: Console.Write("Salı");
                    break;
                case 3: Console.Write("Çarşamba");
                    break;
                case 4: Console.Write("Perşembe");
                    break;
                case 5: Console.Write("Cuma");
                    break;
                case 6: Console.Write("Cumartesi");
                    break;
                case 7: Console.Write("Pazar");
                    break;
                default: Console.Write("belirtilen aralıklardar değer gir.");
                    break;
            }
            Console.ReadLine();*/
            #endregion
        }
    }
}
