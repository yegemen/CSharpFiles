using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int tahmin = 0;
            Random rnd = new Random();
            sayi = rnd.Next(0,100);
            Console.Write(sayi);
            do
            {
                Console.Write("\nSayı tahmin et: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin < sayi)
                {
                    Console.Write("\n Büyük Sayı girin..");
                }
                else if (tahmin > sayi)
                {
                    Console.Write("\n Küçük Sayı girin..");
                }
                else
                {
                    Console.Write("sayıyı bildiniz.");
                }

            } while (tahmin != sayi);

            Console.ReadLine();
        }
    }
}
