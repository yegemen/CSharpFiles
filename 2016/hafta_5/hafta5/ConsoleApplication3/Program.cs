using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int satir = 0; satir <= 10; satir++)
            {
                for (int sutun = 0; sutun <= 10; sutun++)
                {
                    if (satir>=sutun)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
