using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class SumKindOfProblem
    {
        internal void SumKindOfProblemSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int positive = 0;
                int odd = 0;
                int even = 0;

                for (int j = 1; j <= line[1]; j++)
                {
                    positive += j;
                }
                for (int j = 1; j <= line[1] * 2; j = j + 2)
                {
                    odd += j;
                }
                for (int j = 2; j <= line[1] * 2; j = j + 2)
                {
                    even += j;
                }
                Console.WriteLine($"{line[0]} {positive} {odd} {even}");
            }
        }
    }
}
