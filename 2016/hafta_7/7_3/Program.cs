using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] dizi = { { 1, 2, 3 }, { 5, 58, 89 }, { 12, 3, 56 } }; //statik metot ile (el ile) değer girme yöntemi.
            int[,] dizi2 = new int[25, 25]; //dizinin kaç elemanlı olduğu tanımlanıyor. 25 x 25 lik bir matris dizi oluşturduk.

            for (int satir = 0; satir < 25; satir++)
            {
                for (int sutun = 0; sutun < 25; sutun++)
                {
                    if (satir==sutun||satir+sutun==24)
                    {
                        dizi2[satir, sutun] = 1;
                    }
                    else
                    {
                        dizi2[satir, sutun] = 0;
                    }
                }
            }

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (dizi2[i,j]==1)
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
