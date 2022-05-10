using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int satir = 0; satir < 25; satir++)
            {
                if (satir==5)
                {
                    continue;
                    Console.WriteLine("\n");
                }
                Console.WriteLine("*************************");
            }
            Console.ReadLine();
        }
    }
}
