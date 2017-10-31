using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number with 7 digits: ");

            int number = int.Parse(Console.ReadLine());

            string numberAsString = (Convert.ToString(number));

            char result = numberAsString[3];

            Console.WriteLine($"The 4-th digit is {result}");




        }
    }
}
