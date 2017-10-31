using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSomeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //int starterUnicode = 1072;

            //// 1103 is the unicode of я

            //for (int i = 0; i < 100; i++)
            //{
            //    if (starterUnicode >= 1072 && starterUnicode <= 1103) 
            //    {
            //       // Console.WriteLine((char)starterUnicode);
            //        starterUnicode++;
            //    }
            //    else
            //    {             
            //        starterUnicode = 1072;
            //    }

            //}


            string lettersInString = "уеишщксдзцьяаожгтнвмчюйъэфхпрлбуеишщксдзцдьяаожгтнвмчюйъэфхпрлбуеишщксдзцьяаожгтнвмчюйъэфхпрлбуеишщк";

            for (int i = 0; i < lettersInString.Length; i++)
            {
                if (lettersInString[i] == 'а' || lettersInString[i] == 'е' || lettersInString[i] == 'о')
                {
                    Console.WriteLine($"Буквата ({lettersInString[i]}) е широка гласна и се намира под номер {i}");
                }

                if (lettersInString[i] == 'и' || lettersInString[i] == 'у' || lettersInString[i] == 'ъ')
                {
                    Console.WriteLine($"Буквата ({lettersInString[i]}) е тясна гласна и се намира под номер {i}");
                }

                if (lettersInString[i] == 'ю' || lettersInString[i] == 'я')
                {
                    Console.WriteLine($"Буквата ({lettersInString[i]}) е съставна гласна и се намира под номер {i}");
                }

                if (lettersInString[i] == 'п' || lettersInString[i] == 'ф' || lettersInString[i] == 'к' || lettersInString[i] == 'т' || lettersInString[i] == 'ш' || lettersInString[i] == 'с' || lettersInString[i] == 'х' || lettersInString[i] == 'ц')
                {
                    Console.WriteLine($"Буквата ({lettersInString[i]}) е беззвучна съгласна и се намира под номер {i}");
                }

                if (lettersInString[i] == 'л' || lettersInString[i] == 'м' || lettersInString[i] == 'н' || lettersInString[i] == 'р')
                {
                    Console.WriteLine($"Буквата ({lettersInString[i]}) е сонорна съгласна и се намира под номер {i}");
                }

                if (lettersInString[i] == 'б' || lettersInString[i] == 'в' || lettersInString[i] == 'г' || lettersInString[i] == 'д' || lettersInString[i] == 'ж' || lettersInString[i] == 'з' || lettersInString[i] == 'ч')
                {
                    Console.WriteLine($"Буквата ({lettersInString[i]}) е звучна съгласна и се намира под номер {i}");
                }
            }


        }
    }
}
