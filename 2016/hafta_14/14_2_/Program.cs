using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphaneagac_;

namespace _14_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            agac nesne = new agac();
            nesne.ad = "bitki";
            nesne.yaprakturu = "ince";
            nesne.yaprakrengi = "sarı";
            nesne.govde = 8;
            nesne.uzunluk = 120;
            nesne.yetistigibolge = "akdeniz";
            nesne.meyvevarmi = "yok";
            nesne.yıllikkarbondioksit = 100;
            nesne.Buyu();
            nesne.YaprakDok();
            nesne.Kesildi();
            Console.WriteLine("adı= "+nesne.ad+"\n yaprakturu= "+nesne.yaprakturu+"\n yaprakrengi= "+nesne.yaprakrengi+"\n gövde= "+nesne.govde+"\n uzunluk= "+nesne.uzunluk+"\n yetiştiği bölge="+nesne.yetistigibolge+"\n Meyve Var mı= "+nesne.meyvevarmi+"\n yıllık kullandığı karbondioksit= "+nesne.yıllikkarbondioksit+"\n");

            portakal meyve = new portakal();
            meyve.ad = "meyveli ağaç";
            meyve.yaprakturu = "geniş";
            meyve.yaprakrengi = "yeşil";
            meyve.govde = 10;
            meyve.uzunluk = 100;
            meyve.yetistigibolge = "marmara";
            meyve.meyvevarmi = "var";
            meyve.yıllikkarbondioksit = 150;
            meyve.Buyu();
            meyve.YaprakDok();
            meyve.Kesildi();
            Console.WriteLine("adı= " + meyve.ad + "\n yaprakturu= " + meyve.yaprakturu + "\n yaprakrengi= " + meyve.yaprakrengi + "\n gövde= " + meyve.govde + "\n uzunluk= " + meyve.uzunluk + "\n yetiştiği bölge=" + meyve.yetistigibolge + "\n Meyve Var mı= " + meyve.meyvevarmi + "\n yıllık kullandığı karbondioksit= " + meyve.yıllikkarbondioksit + "\n");

            cam cam = new cam();
            cam.ad = "çam ağacı";
            cam.yaprakturu = "ince";
            cam.yaprakrengi = "yeşil";
            cam.govde = 20;
            cam.uzunluk = 60;
            cam.yetistigibolge = "marmara";
            cam.meyvevarmi = "yok";
            cam.yıllikkarbondioksit = 200;
            cam.Buyu();
            cam.YaprakDok();
            cam.Kesildi();
            Console.WriteLine("adı= " + cam.ad + "\n yaprakturu= " + cam.yaprakturu + "\n yaprakrengi= " + cam.yaprakrengi + "\n gövde= " + cam.govde + "\n uzunluk= " + cam.uzunluk + "\n yetiştiği bölge=" + cam.yetistigibolge + "\n Meyve Var mı= " + cam.meyvevarmi + "\n yıllık kullandığı karbondioksit= " + cam.yıllikkarbondioksit + "\n");

            cinar cinar = new cinar();
            cinar.ad = "çınar ağacı";
            cinar.yaprakturu = "geniş";
            cinar.yaprakrengi = "yeşil";
            cinar.govde = 70;
            cinar.uzunluk = 300;
            cinar.yetistigibolge = "marmara";
            cinar.meyvevarmi = "var";
            cinar.yıllikkarbondioksit = 500;
            cinar.Buyu();
            cinar.YaprakDok();
            cinar.Kesildi();
            Console.WriteLine("adı= " + cinar.ad + "\n yaprakturu= " + cinar.yaprakturu + "\n yaprakrengi= " + cinar.yaprakrengi + "\n gövde= " + cinar.govde + "\n uzunluk= " + cinar.uzunluk + "\n yetiştiği bölge=" + cinar.yetistigibolge + "\n Meyve Var mı= " + cinar.meyvevarmi + "\n yıllık kullandığı karbondioksit= " + cinar.yıllikkarbondioksit + "\n");

           

            Console.ReadLine();
        }
    }
}
