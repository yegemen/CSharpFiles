using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            double toplam = 0, ort;
            for (int i = 0; i < 5 ; i++)
            {
                Console.Write("dizinin " + (i+1) + ". elemanını giriniz=");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayilar[i];
            }
            ort = toplam / 5;
            Console.WriteLine("girdiğiniz sayıların ortalaması= " + ort);
            Console.ReadLine();
        }
    }
}
