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
            char[] kelime = new char[7] { 'S', 'A', 'K', 'A', 'R', 'Y', 'A' };
            for (int i = 0; i < kelime.Length; i++)
            {
                Console.Write(kelime[i]);
            }
            Console.WriteLine();
            for (int i = 6; i >= 0; i--)
            {
                Console.Write(kelime[i]);
            }
            Console.ReadLine();
        }
    }
}
