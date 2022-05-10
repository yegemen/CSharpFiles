using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            dortgen nesne = new dortgen();
            nesne.EnBoyBelirle(12,50,"asd"); // en boy değerlerini metot üzerinden atama yaptık.
            string a = dortgen.AlanHesapla();
            

            nesne.EnBoyBelirle(2, 4, "kırmızı");
            nesne.Yaz();
            nesne.EnBoyBelirle(14, 25, "mavi");
            nesne.Yaz();
            Console.ReadLine();
        }
    }
}
