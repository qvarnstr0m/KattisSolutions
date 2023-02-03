using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class ThreeDPrintedStatues
    {
        internal void ThreeDPrintedStatuesSolution()
        {
            int input = int.Parse(Console.ReadLine());

            int statues = 0;
            int machines = 1;
            int daysPassed = 0;

            while (statues < input)
            {
                daysPassed++;
                if (machines < input)
                {
                    machines += machines;
                }
                else
                {
                    statues += machines;
                }
            }

            Console.WriteLine(daysPassed);
        }
    }
}
