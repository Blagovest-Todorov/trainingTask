using System;

namespace _19.examTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            double mRanKms = double.Parse(Console.ReadLine()); //Ran Kms first day 
                                                               //int dayIncrementPercent = int.Parse(Console.ReadLine());
                                                               //math ceiling / Math.Ceiling();

            // double distanceRan = 0;
            bool isSucceded = false; //is succeded to ran the distance; 

            double totalRanKms = mRanKms; // here i write down  the ran distance /
            double totalRanKmsSum = mRanKms;
            for (int i = 1; i <= numberDays; i++)
            {
                int dayIncrementPercent = int.Parse(Console.ReadLine());
                double currDayIncrement = (1.0 * dayIncrementPercent) / 100;
                //distanceRan += mRanKms;// distance 1 day ran
                totalRanKms += (currDayIncrement * totalRanKms); /// day two ran kms  distanceRan = distanceRan + distanceRan * dayIncrementPercent;
                totalRanKmsSum += totalRanKms;

                if (totalRanKmsSum >= 1000)
                {
                   // Console.WriteLine($"You've done a great job running {Math.Ceiling(distanceRan - 1000)} more  kilometers!");
                    isSucceded = true;
                   
                    break;                    
                }
                else if ( 1000 > totalRanKmsSum)
                {
                    //Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - distanceRan)} more kilometers");
                    continue;
                } 
            }
            if (isSucceded == true)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalRanKmsSum - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalRanKmsSum)} more kilometers");
            }

        }
    }
}
