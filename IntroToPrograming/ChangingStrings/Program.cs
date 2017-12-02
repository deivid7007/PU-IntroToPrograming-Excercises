using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Shteigraempokerdnespokeraehubavaigra";
            string x = "poker";
            string y = "belot";
            Console.WriteLine(s);
            s = Replacer(s,x,y);
            Console.WriteLine(s);
        }

        static string Replacer(string s,string x,string y)
        {
            return s.Replace(x, y);
        }
    }
}
