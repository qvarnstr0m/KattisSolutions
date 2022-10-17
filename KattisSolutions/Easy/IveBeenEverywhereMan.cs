using System;
using System.Collections.Generic;

namespace KattisSolutions.Easy
{
    internal class IveBeenEverywhereMan
    {
        internal void IveBeenEverywhereManSolution()
        {
            var citySet = new HashSet<string>();
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int iterations = int.Parse(Console.ReadLine());
                for (int j = 0; j < iterations; j++)
                {
                    citySet.Add(Console.ReadLine());
                }
                Console.WriteLine(citySet.Count);
                citySet.Clear();
            }
        }
    }
}
