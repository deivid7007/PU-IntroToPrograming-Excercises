using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WorkingWithSomeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int number;


            for (int i = 0; i < 100; i++)
            {
                number = rand.Next(0, 132);

                // A

                if (i % 2 == 0)
                {
                    Console.WriteLine($"{number} have even index = {i}");
                }


                // B

                if (number % 2 == 1 && i % 2 == 1)
                {
                    Console.WriteLine($"{number} is odd and have index {i}");
                }

                // C

                if (number % 3 == 0)
                {
                    Console.WriteLine($"{number} is divided to 3 without reminder and have index {i}");
                }

                //D

                if (number % 7 == 1)
                {
                    Console.WriteLine($"{number} is divided to 7 with reminder = 1 and have index {i}");
                }

                // E

                if (number >= 26 && number <= 100)
                {
                    Console.WriteLine($"{number} is between 26 and 100 and have index {i}");
                }

                // F

                if (number < 26 || number > 100)
                {
                    Console.WriteLine($"{number} is not between 26 and 100 and have index {i}");
                }
                


            }




        }
    }
}
