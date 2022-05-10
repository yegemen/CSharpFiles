using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_8
{//opsiyonelsecim
    class Program
    {
        static void Main(string[] args)
        {
            Topla(21);
            Topla(15, 87);
            Topla(45, 69, " Sayıların Toplamı");
            Topla(sayi1: 45, sayi2: 50, mesaj: "parametre adıyla çağrma"); //parametre adıyla çağırır sıralama önemli değil.
            Console.ReadLine();

        }
        static void Topla(int sayi1 = 0, int sayi2 = 0, string mesaj = "")
        {
            Console.WriteLine(mesaj + " Toplam= {0}", sayi1 + sayi2);
        }
    }
}
