using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndMehods
{
    class Program
    {
        static void Print(string[] Company)
        {
            for (int i = 0; i < Company.Length; i++)
            {
                Console.WriteLine($"Worker name: {Company[i]}");
            }
        }


        static void Main(string[] args)
        {
            int number = 0;
            string[] Code = new[] {"Deivid","Gosho","Georgi" };
            string[] Sharp = new[] {"Gery","Nikol" };
            string[] Stroy = new[] {"Petar" };

            Console.WriteLine("1 --> Code Company\n2 --> Sharp Company\n3 --> Stroy Company");

            Console.WriteLine("Enter numer");
            number = int.Parse(Console.ReadLine());


            switch (number)
            {
                case 1:
                    Print(Code);
                    break;
                case 2:
                    Print(Sharp);
                    break;
                case 3:
                    Print(Stroy);
                    break;
            }


        }
    }
}
