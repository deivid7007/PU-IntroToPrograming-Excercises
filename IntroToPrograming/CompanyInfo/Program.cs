using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the requested information!");
            Console.WriteLine("----------------------------------------");

            Console.Write("Company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Company phone number: ");
            string companyNumber = Console.ReadLine();

            Console.Write("Company web site: ");
            string companyWebSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Manager phone number: ");
            string managerPhone = Console.ReadLine();

            string info = "INFO: ";

            string fullManagerName = managerFirstName + " " + managerLastName;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            

            Console.WriteLine("{0}", info);

            Console.Write("Company: {0, 30}|" + 
                "\nAddress: {1, 30}|" + 
                "\nCompany number: {2, 23}|" +
                "\nWeb site: {3, 29}|" +
                "\nManager: {4, 30}|" + 
                "\nManager phone: {5, 24}|",
                          companyName, companyAddress, companyNumber,
                          companyWebSite, fullManagerName, managerPhone);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();


        }
    }
}
