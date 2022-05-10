using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sonuc = Ortalama(65, 40);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
        
        static decimal Ortalama(int sayi1, int sayi2)// sonuç değişkeninin yaşam alanı bu metot değişkeninin yaşam alanı bu blok içinde geçerlidir.
                                                     // ana metot daki sonuç değişkeni ile bir alakası yoktur.
        {
            decimal sonuc = (sayi1 + sayi2) / 2;
            return sonuc;
        }
        
    }
}
