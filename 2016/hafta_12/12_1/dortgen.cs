using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1
{
    public class dortgen
    {
        private int en;
        private int boy;
        private string ad;

        public int En
        {
            get // okuma yapmak için
            {
                Console.WriteLine("en değerinin okunması");
                return en;
            }
            set // yazma işleri yapıyoruz
            {
                en = value;
                Console.WriteLine("en değerine atama yapıldı.");
            }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        public int Boy
        {
            get { return boy; }
            set { boy = value; }
        }
        public int Alan // sadece okunabilir değer atanması
        {
            get { return en * boy; }
        }
    }
}