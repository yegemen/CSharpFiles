using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int satir = 0; satir <= 10; satir++)
            {
                for (int sutun = 0; sutun <=10; sutun++)
                {
                    if (satir==sutun||satir==5||sutun==5||satir+sutun==10)
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
        }
    }
}
