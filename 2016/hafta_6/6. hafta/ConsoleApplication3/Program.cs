using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dizisayisi, min, mak;
            /* min=1000;
            max=0;
             bu şekildede olurdu. */
            Random dizi = new Random();
            Console.Write("Kaç elemanlı dizi oluşturmak istiyorsun? = ");
            dizisayisi = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[dizisayisi];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = dizi.Next(0, 1000);
            }
            min = sayilar[0];
            mak = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                
                if (min > sayilar[i]) //sayilar[i]>max yukardaki değişkenlere 0 ve 1000 vererek
                {
                    min = sayilar[i];
                }
                if (mak < sayilar[i]) //sayilar[i]<min yukardaki değişkenlere 0 ve 1000 vererek
                {
                    mak = sayilar[i];
                }  
                Console.WriteLine((i + 1) + ". eleman = " + sayilar[i]);
            }
            Console.WriteLine("dizinin en büyük elemanı= " + mak);
            Console.WriteLine("dizinin en küçük elemanı= " + min);
            Console.ReadLine();
        }
    }
}
