using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class NumberFun
    {
        internal void NumberFunSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                bool possible = false;

                double[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

                if (numbers[0] + numbers[1] == numbers[2]) possible = true;
                else if (numbers[0] * numbers[1] == numbers[2]) possible = true;
                else if (numbers[0] - numbers[1] == numbers[2] || numbers[1] - numbers[0] == numbers[2]) possible = true;
                else if (numbers[0] / numbers[1] == numbers[2] || numbers[1] / numbers[0] == numbers[2]) possible = true;

                Console.WriteLine(possible ? "Possible" : "Impossible");
            }
        }
    }
}
