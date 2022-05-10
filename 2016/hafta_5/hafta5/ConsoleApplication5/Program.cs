using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir = 0, sutun = 0;
            while (satir <= 10)
            { 
                while (sutun <= 10)
                {
                    if (satir == sutun || satir == 5 || sutun == 5 || satir + sutun == 10)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    sutun++;
                }
                sutun = 0;
                Console.WriteLine();
                satir++;
            }
            #region digeri;
            //int satir = 0, sutun = 0;
            //while (satir <= 10)
            //{
            //    while (sutun <= 10)
            //    {
            //        if (satir>=sutun)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //        sutun++;
            //    }
            //    sutun = 0;
            //    Console.WriteLine();
            //    satir++;
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
