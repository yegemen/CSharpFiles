using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bisiklet b = new bisiklet();
            Console.Write("bisiklet markasını giriniz: ");
            b.marka = Console.ReadLine();
            Console.Write("Bisikletin hızını(km) giriniz: ");
            b.hız = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaç km hızlansın: ");
            b.hızlanma = Convert.ToInt32(Console.ReadLine());
            Console.Write("bisiklet türünü giriniz: ");
            b.tur = Console.ReadLine();
            Console.Write("Bisikletin fren gücü nasıl: ");
            b.frengucu = Console.ReadLine();
            Console.Write("rengini giriniz: ");
            b.renk = Console.ReadLine();
            Console.Write("bisiklet model yılını giriniz: ");
            b.modelyili = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bisikletin vites sayısını giriniz: ");
            b.vitessayi = Convert.ToInt32(Console.ReadLine());

            b.markayaz();
            b.hızyaz();
            b.hızlanmayaz();
            b.turyaz();
            b.frengucuyaz();
            b.renkyaz();
            b.modelyiliyaz();
            b.yasyaz();
            b.vitessayiyaz();
            
            Console.ReadLine();
        }
    }
}
