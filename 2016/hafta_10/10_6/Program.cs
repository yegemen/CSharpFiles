using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int enbuyuk;
            enbuyuk = EnBuyukBul2(25, 45, 58);
            Console.WriteLine("en büyük sayi= " + enbuyuk);
            Console.ReadLine();
            
        }

        static int EnBuyukBul(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else
            {
                return sayi2;
            }
        }
        static int EnBuyukBul2(int sayi1, int sayi2, int sayi3)
        {
            int sonuc;
            sonuc = EnBuyukBul(sayi1, EnBuyukBul(sayi2, sayi3));
            return sonuc;
        }
    }
}
