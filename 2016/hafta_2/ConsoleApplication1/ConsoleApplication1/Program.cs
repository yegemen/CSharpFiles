using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            degiskenler.yaziyaz();

            degiskenler d = new degiskenler();

            Console.Write("a değeriniz giriniz= ");
            d.a=Convert.ToInt32(Console.ReadLine());
            Console.Write("b değeriniz giriniz= ");
            d.b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a ya girdiğiniz değer= " + d.a);
            Console.WriteLine("b ye girdiğiniz değer= " + d.b);
            

            Console.ReadLine();
        }
    }
}
