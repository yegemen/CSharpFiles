using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dizisayisi;
            Random dizi = new Random();
            Console.Write("Kaç elemanlı dizi oluşturmak istiyorsun? = ");
            dizisayisi = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[dizisayisi];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = dizi.Next(0, 1000);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine((i+1) + ". eleman = "+sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
