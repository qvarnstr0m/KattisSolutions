using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class QuickEstimates
    {
        internal void QuickEstimatesSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string line = Console.ReadLine();
                int digits = 0;
                foreach (char c in line)
                {
                    digits++;
                }
                Console.WriteLine(digits);
            }
        }
    }
}
