using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;

            for (satir = 0; satir < 25; satir++)
            {
                for (sutun = 0; sutun < 25; sutun++)
                {
                    if (satir+sutun==24||satir==sutun||satir==12||sutun==12||(sutun==22&&satir==16)) //22 sutun 16 satır
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
