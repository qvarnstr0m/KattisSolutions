﻿using System;

namespace KattisSolutions.Easy
{
    internal class StuckInATimeLoop
    {
        internal void StuckInATimeLoopSolution()
        {
            int loops = int.Parse(Console.ReadLine());
            for (int i = 1; i <= loops; i++)
            {
                Console.WriteLine($"{i} Abracadabra");
            }
        }
    }
}
