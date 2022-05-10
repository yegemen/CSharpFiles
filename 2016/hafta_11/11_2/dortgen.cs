using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2
{
    public class dortgen // public kelimesi ana programdan ulaşılmasını sağlıyor.
                        // private olsaydı sadece sınıf içerisinden erişime izin verir.
    {
        public int En; // 3 adet özellik tanımladık.
        public int Boy;
        private string Ad; //bu sınıf dışından ulaşılmaz. ana programdan bu özelliğe ulaşamayız.
        public void EnBoyBelirle(int en, int boy, string ad)
        {
            En = en;
            Boy = boy;
            Ad = ad; //private olarak tanımlanan özelliğe metot üzerinden dışarıdan erişim sağladık.
        }
        public static string AlanHesapla()
        {
            return "alan hesapla metodunun çağırılması ";
        }
        public void Yaz()
        {
            Console.WriteLine("{0} nesnesinin özellikleri", Ad);
            Console.WriteLine("En:{0}", En);
            Console.WriteLine("Boy:{0}", Boy);
        }
    }
}
