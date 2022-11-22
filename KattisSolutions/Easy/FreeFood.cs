using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class FreeFood
    {
        internal void FreeFoodSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            HashSet<int> uniqueDaysWithFood = new HashSet<int>();

            for (int i = 0; i < iterations; i++)
            {
                int[] eventWithFood = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int j = eventWithFood[0]; j <= eventWithFood[1]; j++)
                {
                    uniqueDaysWithFood.Add(j);
                }
            }

            Console.Write(uniqueDaysWithFood.Count);
        }
    }
}
