using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_9
{//özyineli
    class Program
    {
        static void Main(string[] args)
        {
            int hesap;
            hesap = Faktoriyel(5);
            Console.WriteLine(hesap);
            Console.ReadLine();
        }
        static int Faktoriyel(int sayi)
        {
            int sonuc;
            if (sayi==0)
            {
                return 1;
            }
            else
            {
                sonuc = sayi * Faktoriyel(sayi - 1);
            }
            return sonuc;
        }
    }
}
