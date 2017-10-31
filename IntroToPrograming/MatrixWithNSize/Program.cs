using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixWithNSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;


            Console.WriteLine("Enter value for the prameter N between 2 and 20: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = i; j < (n - 1) + i; j++)
                {
                    Console.Write($"{i}\n{j}");
                }
            }


        }
    }
}
