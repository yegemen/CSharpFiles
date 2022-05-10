using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            dortgen nesne = new dortgen();
            nesne.En = 76; // set bloğu çalışır.
            int a = nesne.En; // get bloğu çalışır ve değer a değişkenine atanır.
            nesne.Ad = "pazaryeri";//atama yaptık.
            Console.WriteLine(nesne.Ad);//okuma yaptık get
            //nesne.Alan=23; // set bloğu tanımlanmadığından derleme sırasında hata verir.
            Console.WriteLine(nesne.Alan);

            Console.ReadLine();


        }
    }
}