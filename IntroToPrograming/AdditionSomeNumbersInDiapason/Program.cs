using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionSomeNumbersInDiapason
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for (int i = 1; i < 50; i++)
            {
                result += i;
            }

            Console.WriteLine("The result of addition is = {0}", result);

        }
    }
}
