using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class UserHeartInfo
    {
       
        public void GetHeartRate()
        {
            const double targetMin = .5;
            const double targetMax = .85;
            int maxHeartRate = 220;

            Console.WriteLine("What is your age?");

            string userInput = Console.ReadLine();
            int userAge = Int32.Parse(userInput);

            int userMaxHeartRate = (maxHeartRate - userAge);
            double targetHRMin = (userMaxHeartRate * targetMin);
            double targetHRMax = (userMaxHeartRate * targetMax);

            Console.WriteLine("Your expected heart rate should be " + userMaxHeartRate + " beats per minute.");
            Console.WriteLine("Your target Heart Rate zone is " + targetHRMin + "-" + targetHRMax + " beats per minute.");
            Console.ReadKey();
        }



    }
}
