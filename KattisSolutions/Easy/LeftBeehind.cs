using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class LeftBeehind
    {
        internal static void LeftBeehindSolution()
        {
            while (true)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int first = input[0];
                int second = input[1];

                if (first == 0 && second == 0) break;
                if (first + second == 13) Console.WriteLine("Never speak again.");
                else if (first == second) Console.WriteLine("Undecided.");
                else if (first < second) Console.WriteLine("Left beehind.");
                else if (first > second) Console.WriteLine("To the convention.");
            }
        }
    }
}
