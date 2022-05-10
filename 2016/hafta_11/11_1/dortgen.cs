using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    class dortgen
    {
        public int En;
        public int Boy;

        public dortgen() //2 değişkene dışarıdan değer girilmese de başlangıç değerleri 1 olur. ,, sınıf adı ile aynı yazılır bunlar. void olmaz.
        {
            En = 1;
            Boy = 1;
        }

        public dortgen(int en, int boy)
        {
            En = en; //en özelliğine parametre değerini atadık.
            Boy = boy;
        }

        /// <summary>
        /// bu metod dörtgenin alanını hesaplar
        /// </summary>
        /// <returns>en*boy değerini döndürür</returns>
        public int AlanHesapla()
        {
            return En * Boy; 
        }
        public int CevreHesapla()
        {
            return 2 * En + 2 * Boy;
        }
        public void BilgiYaz()
        {
            Console.WriteLine(En);
            Console.WriteLine(Boy);
        }
    }
}
