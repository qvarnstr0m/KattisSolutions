using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class GrassSeedInc
    {
        internal void GrassSeedIncSolution()
        {
            decimal costPerSq = decimal.Parse(Console.ReadLine());
            int iterations = int.Parse(Console.ReadLine());
            decimal totalCost = 0;

            for (int i = 0; i < iterations; i++)
            {
                string[] lawn = Console.ReadLine().Split(' ');
                totalCost += costPerSq * decimal.Parse(lawn[0]) * decimal.Parse(lawn[1]);
            }
            Console.Write(totalCost);
        }
    }
}
