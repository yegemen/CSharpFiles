using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string parola;
            do
            {
                Console.Write("Parolayı gir: ");
                parola = Console.ReadLine();
                if (parola == "şaban")
                {
                    Console.Write("Hoşgeldin..");
                    break;
                }
            } while (parola=="şaban");
            if (parola != "şaban")
            {
                Console.Write("parolayı yanlış girdin.");
            }
            Console.ReadLine();
        }
    }
}
