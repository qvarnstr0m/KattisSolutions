using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class TransitWoes
    {
        internal void TransitWoesSolution()
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int startTime = int.Parse(line1[0]);
            int schoolTime = int.Parse(line1[1]);
            int bussRides = int.Parse(line1[2]);

            string[] line2 = Console.ReadLine().Split(' ');
            int walkTime = 0;
            foreach (var item in line2)
            {
                walkTime += int.Parse(item);
            }

            string[] line3 = Console.ReadLine().Split(' ');
            int rideTime = 0;
            foreach (var item in line3)
            {
                rideTime += int.Parse(item);
            }

            string[] line4 = Console.ReadLine().Split(' ');
            int waitTime = 0;
            for (int i = 0; i < line4.Length; i++)
            {

            }
            if (startTime + walkTime + rideTime + waitTime > schoolTime)
                Console.Write("no");
            else
                Console.Write("yes");
        }
    }
}
