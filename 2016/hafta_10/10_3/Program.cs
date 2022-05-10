using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3
{
    class Program
    {
        #region
        static double KdvHesap(double sayi)
        {
            return sayi = sayi * 0.18;
        }

        static void Main(string[] args)
        {
            double a, sonuc;
            Console.Write("Kdv'si hesaplanacak sayıyı girin: ");
            a=Convert.ToInt32(Console.ReadLine());
            sonuc = KdvHesap(a);
            Console.WriteLine("\n" + a + " sayısının %18 kdv si= " + sonuc);
            Console.ReadLine();
        }
        #endregion
    }
}
