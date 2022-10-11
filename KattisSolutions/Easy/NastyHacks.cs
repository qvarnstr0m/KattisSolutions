using System;

namespace KattisSolutions.Easy
{
    internal class NastyHacks
    {
        internal void NastyHacksSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string line = Console.ReadLine();
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                int revenueWithoutAds = int.Parse(split[0]);
                int revenueWithAds = int.Parse(split[1]) - int.Parse(split[2]);

                if (revenueWithAds == revenueWithoutAds) Console.WriteLine("does not matter");
                else if (revenueWithAds > revenueWithoutAds) Console.WriteLine("advertise");
                else if (revenueWithoutAds > revenueWithAds) Console.WriteLine("do not advertise");
            }
        }
    }
}