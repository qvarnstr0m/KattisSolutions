using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class DivvyingUp
    {
        internal void DivvyingUpSolution()
        {
            Console.ReadLine();
            int[] prizeArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int totalPrize = 0;
            foreach (var item in prizeArray)
            {
                totalPrize += item;
            }

            if (totalPrize % 3 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
