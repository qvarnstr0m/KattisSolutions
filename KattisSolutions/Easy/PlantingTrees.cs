using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class PlantingTrees
    {
        internal void PlantingTreesSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            int[] seedArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(seedArray);
            Array.Reverse(seedArray);
            List<int> maxDays = new List<int>();

            for (int i = 0; i < iterations; i++)
            {
                maxDays.Add(i + seedArray[i] + 2);
            }

            Console.WriteLine(maxDays.Max());
        }
    }
}
