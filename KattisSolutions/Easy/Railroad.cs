using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Railroad
    {
        internal static void RailroadSolution()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.Write((input[0] * 4 + input[1] * 3) % 2 == 0 ? "Possible" : "Impossible");
        }
    }
}
