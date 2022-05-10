using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;//değişkenin değeri değiştirelemez.
            int sayi1 = 12, sayi2 = 3;
            double sayi3;
            decimal sayi4;//128 bit gerçek sayı.
            float a;//32 bitlik pozitif sayılar.
            string metin;//metin türünden değer.
            char b;//karakter.
            byte c;//1byte (8bitlik) veri
            bool dy;//doğru yanlış

            metin = "metin değeri alır";
            sayi3 = 3.5;
            sayi4 = 5;
            a = 30;
            b = 'a';
            c = 255;
            dy = true;

            Console.WriteLine(metin+"\t"+sayi3+"\t"+sayi4+"\t"+a+"\t"+b+"\t"+c+"\t"+dy+"\t");

            sayi2 = sayi1;
            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.ReadLine();

        }
    }
}
