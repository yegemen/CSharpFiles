using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_10
{
    class Program
    {//geriye değer döndüren metotlar.
        static void Main(string[] args)
        {
            int sonuc;
            sonuc = Topla(5,5);
            Console.WriteLine("Sayıların Toplamı= " + sonuc);
            Console.WriteLine(Topla(55, 15));
            Console.ReadLine();
        }
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
