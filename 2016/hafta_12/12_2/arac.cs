using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class arac
    {
        private int yakit;
        private string renk;

        public int Yakit //özellik (property)
        {
            get { return yakit; }
            set
            {
                if (value > 0)
                {
                    yakit = yakit + value;
                }
            }
        }
        public int MaksimumMesafe
        {
            get { return yakit * 10; }
        }
        public string Renk
        {
            get { return renk; }
            set { renk = value.ToUpper(); }
        }
        public void HareketEt(int mesafe)
        {
            Console.WriteLine("Arac hareket etmiştir.");//araç hareket edince ekrana yazıp bilgi verecek.
            yakit = yakit - mesafe / 10; //araç hareket ettiği kadar yakıtta azalma yaptık.
        }
        //ctrl+k+d tuşları ile kodları düzenler.
    }
}
