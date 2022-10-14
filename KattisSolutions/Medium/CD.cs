using System;
using System.Collections.Generic;

namespace KattisSolutions.Medium
{
    internal class CD
    {
        internal void CDSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int jackCDs = int.Parse(split[0]);

            var jackList = new List<long>();

            int canBeSold = 0;

            for (int i = 0; i < jackCDs; i++)
            {
                jackList.Add(long.Parse(Console.ReadLine()));
            }

            string jillInput;
            while ((jillInput = Console.ReadLine()) != "0 0")
            {
                long cd = long.Parse(jillInput);
                if (jackList.Contains(cd))
                {
                    canBeSold++;
                }
            }

            Console.Write(canBeSold);
        }
    }
}
