using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //double dolar, tl;
            //Console.Write("TL giriniz: ");
            //tl=Convert.ToDouble(Console.ReadLine());
            //dolar = tl / 2.97;
            //Console.WriteLine("\n"+ tl + " TL, " + dolar + " DOLAR dır.");

            //Console.ReadLine();

            string para;
            double dolar, tl;
            Console.Write("TL giriniz: ");
            para = Console.ReadLine();
            tl = Convert.ToInt32(para);
            dolar = tl / 2.97;
            Console.WriteLine("\n" + tl + " TL, " + dolar + " DOLAR dır.");

            Console.ReadLine();

        }
    }
}
