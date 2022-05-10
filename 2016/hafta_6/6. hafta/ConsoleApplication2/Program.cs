using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        #region yıldızN
        static void Main(string[] args)
        {
            for (int satir = 0; satir <= 7; satir++)
            {
                for (int sutun = 0; sutun <= 7; sutun++)
                {
                    if (satir == sutun || sutun == 7 || sutun == 0)
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
            Console.ReadLine();
            #endregion

        }
    }
}
