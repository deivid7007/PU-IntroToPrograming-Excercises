using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeNeedToTravelToTheSun
{
    class Program
    {
        static void Main(string[] args)
        {

            //int velocity = 1225;

            double velocityPerSecond = 331.2; // in 0 degree
            //double velocityPerSecond1 = 343d; // in 20 degree
            
            double distance = 149600000d;
            
            double time = distance / velocityPerSecond;

            double daysToGo = time / (60 * 60 * 24);


            Console.WriteLine($"The time needed to travel from the Eath to the Sun is {Math.Floor(daysToGo)} days");
            

            //years = Math.Floor(time / 365);
            //days = Math.Floor(time % 365);
            //Console.WriteLine($"The time needed to travel from the Eath to the Sun is {time} hours, or {years} Years and {days} days");



        }
    }
}
