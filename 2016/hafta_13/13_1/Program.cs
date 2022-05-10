using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr = new ogrenci();
            Console.Write("Okul İsmi Girin= ");
            ogr.Okulismi = Console.ReadLine();
            Console.Write("İl Girin= ");
            ogr.Il = Console.ReadLine();
            Console.Write("Kaçıncı Sınıf= ");
            ogr.Kacincisinif = Convert.ToInt32(Console.ReadLine());
            Console.Write("Öğrenci Sayısı= ");
            ogr.Ogrsayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yeni Öğrenci Sayısı= ");
            ogr.Yeniogr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mezun Öğrenci Sayısı= ");
            ogr.Mezunogr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Okul İsmi= " + ogr.Okulismi);
            Console.WriteLine("İl= " + ogr.Il);
            Console.WriteLine("Sınıf= " + ogr.Kacincisinif);
            Console.WriteLine(ogr.kacyildahavar() + " Yıl daha okuyacak.");
            ogr.sinifduzey();
            ogr.yaskac();
            ogr.yeniogrencisayi();

            Console.ReadLine();


        }
    }
}
