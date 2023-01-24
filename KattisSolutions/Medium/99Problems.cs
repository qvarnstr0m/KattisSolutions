using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Medium
{
    internal class _99Problems
    {
        internal void _99ProblemsSolution()
        {
            int input = int.Parse(Console.ReadLine());

            if (input <= 100) Console.Write(99);
            else
            {
                int remainder = input % 100;
                Console.WriteLine(remainder < 49 ? input - remainder - 1 : input + 99 - remainder);
            }
        }
    }
}
