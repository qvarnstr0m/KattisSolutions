using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class BatterUp
    {
        internal void BatterUpSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            int[] atBats = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            decimal total = 0m;
            int divider = 0;
            foreach (int item in atBats)
            {
                if (item != -1)
                {
                    total += item;
                    divider++;
                }
            }
            Console.Write(total / divider);
        }
    }
}
