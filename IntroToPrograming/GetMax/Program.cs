using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int firstMax = GetMax(firstNumber, secondNumber);
            int secondMax = GetMax(firstMax, thirdNumber);

            Console.WriteLine($"The biggest number is {secondMax}");
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
