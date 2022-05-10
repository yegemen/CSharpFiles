using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class Program
    {//geriye değer döndürmeyen metodlar (void olarak yazılabilir veya return kullanılmaz)
        static void Main(string[] args)
        {
            string a = "asd";
            EkranaYaz(a);
            EkranaYaz();
            Console.ReadLine();
        }
        //metot dan önce 3 slaç metodun açıklaması olur.
        /// <summary>
        /// bu metot ekrana yazı yazdırır.
        /// </summary>
        /// <param name="Metin"></param>
        static void EkranaYaz(string Metin)
        {
            Console.WriteLine(Metin);
        }
        //aşırı yükleme
        static void EkranaYaz()//parametresiz kullanım.
        {
            Console.WriteLine("bu parametresiz çalışan bir metottur.");
        }
    }
}
