using System;

namespace KattisSolutions.Easy
{
    internal class KnightPacking
    {
        internal void KnightPackingSolution()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) Console.Write("second");
            else Console.Write("first");
        }
    }
}
