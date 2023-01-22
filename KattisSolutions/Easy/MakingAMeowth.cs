using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class MakingAMeowth
    {
        internal void MakingAMeowthSolution()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int output = 0;

            output += input[1] * input[2];
            output += (input[1] / (input[0] - 1)) * input[3];

            Console.WriteLine(output);
        }
    }
}
