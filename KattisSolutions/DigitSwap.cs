﻿using System;

namespace KattisSolutions
{
    internal class DigitSwap
    {
        internal void DigitSwapSolution()
        {
            string line = Console.ReadLine();
            char[] lineArray = line.ToCharArray();
            Array.Reverse(lineArray);
            Console.Write(lineArray);
        }
    }
}
