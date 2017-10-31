using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotaryWinningCombinationsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
           // int counter = 0;

            for (int a = 1; a <= 44; a++)
            {
                for (int b = a + 1; b <= 45; b++)
                {
                    for (int c = b + 1 ; c <= 46; c++)
                    {
                        for (int d = c + 1; d <= 47; d++)
                        {
                            for (int e = d + 1; e <= 48; e++)
                            {
                                for (int f = e + 1; f <= 49; f++)
                                {
                                    Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
                                }
                            }
                        }
                    }
                }
            }

            //Console.WriteLine($"There are {counter} winning combinations of 6/49 lottery.");

        }
    }
}
