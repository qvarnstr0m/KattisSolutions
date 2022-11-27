using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class RoamingRomans
    {
        internal void RoamingRomansSolution()
        {
            float number = float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(number * 1000 * (5280f / 4854f)));
        }
    }
}
