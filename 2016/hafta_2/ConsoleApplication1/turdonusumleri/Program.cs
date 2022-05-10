using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogumyili;
            int yil, yas;
            Console.WriteLine("dogum yilinizi giriniz: ");
            dogumyili = Console.ReadLine();
            yil = Convert.ToInt32(dogumyili);
            yas = 2016 - yil;

            Console.WriteLine("Yaşınız= " + yas);

            Console.ReadLine();


        }
    }
}
