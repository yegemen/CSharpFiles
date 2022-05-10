using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla(25, 58, 78);
            Topla(25, 58, 78, 50);
            double[] dizi = { 45, 58, 69 }; // params anahtar kelimesi kullanmadığımızdan argümanları dizi olarak vermek zorundayız.
            Topla(dizi);
            Console.ReadLine();
        }
        static void Topla(params int[] sayilar) // istediğimiz sayıda parametre alması için.
        {
            int Toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Toplam += sayilar[i];
            }
            Console.WriteLine("Sonuc: {0}", Toplam);
        }
        static void Topla(double[] sayilar)
        {
            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Sonuç: {0}", toplam);
        }
    }
}
