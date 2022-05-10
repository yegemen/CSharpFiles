using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4
{
    class Program
    {
        static int KareAL(int sayi)
        {
            return sayi * sayi;
        }
        static int KupAl(int sayi)
        {
            return sayi * sayi * sayi;
        }
        static int FaktoriyelAl(int sayi)
        {
            int sonuc=1;
            for (int i=sayi;sayi>=1; sayi--)
            {
                sonuc = sonuc * sayi;
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            int a, b, c, sonuc1, sonuc2, sonuc3;
            Console.Write("Karesi alınacak sayıyı girin= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Küpü alınacak sayıyı girin= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Faktöriyeli alınacak sayıyı girin= ");
            c = Convert.ToInt32(Console.ReadLine());
            sonuc1 = KareAL(a);
            sonuc2 = KupAl(b);
            sonuc3 = FaktoriyelAl(c);
            Console.WriteLine(a + " sayısının karesi= " + sonuc1 + "\n" + b + " sayısının küpü= " + sonuc2 + "\n" + c + " sayısının faktöriyeli= " + sonuc3);
            Console.ReadLine();
        }
    }
}
