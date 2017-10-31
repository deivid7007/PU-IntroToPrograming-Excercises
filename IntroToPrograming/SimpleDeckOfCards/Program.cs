using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string yesOrNo;
            int heart = 9829;
            int spade = 9824;
            int diamond = 9830;
            int club = 9827;

            do
            {
                Console.WriteLine("Do you want to see a full deck of cards? (yes or no): ");
                yesOrNo = Console.ReadLine();

            } while (yesOrNo != "yes");

            

            for (int i = 1; i < 14; i++)
            {

                if (i >= 2 && i < 11)
                {
                    Console.WriteLine($"{i} {(char)heart}, {i} {(char)spade}, {i} {(char)diamond}, {i} {(char)club}");
                }            

                switch (i)
                {
                    case 1:
                        Console.WriteLine($"A {(char)heart}, A {(char)spade}, A {(char)diamond}, A {(char)club}");
                        break;                  

                    case 11:
                        Console.WriteLine($"J {(char)heart}, J {(char)spade}, J {(char)diamond}, J {(char)club}");
                        break;

                    case 12:
                        Console.WriteLine($"Q {(char)heart}, Q {(char)spade}, Q {(char)diamond}, Q {(char)club}");
                        break;

                    case 13:
                        Console.WriteLine($"K {(char)heart}, K {(char)spade}, K {(char)diamond}, K {(char)club}");
                        break;

                }


            }

            }

        }
    }

