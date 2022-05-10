using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir = 0, sutun = 0;
            while (satir<=5)
            {
                while (sutun<=5)
                {
                    if (satir == sutun || sutun == 5 || sutun == 0)
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
            Console.ReadLine();
        }
    }
}
