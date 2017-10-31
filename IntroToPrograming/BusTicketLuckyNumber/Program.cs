using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketLuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // 0 0 8 7 2 3

            int counter = 0;
            int counterNot = 0;

            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                for (int f = 0; f <= 9; f++)
                                {
                                    if (a + b + c == d + e + f)
                                    {
                                        Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
                                        counter++;
                                    }

                                    else if (a + b + c != d + e + f)
                                    {
                                        counterNot++;
                                    }

                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Total lucky ticket numbers are {counter}");
            Console.WriteLine($"Total not lucky ticket numbers are {counterNot}");
            Console.WriteLine($"Total tickets existing are {counter + counterNot}");



        }
    }
}
