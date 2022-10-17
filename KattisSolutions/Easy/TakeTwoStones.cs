using System;

namespace KattisSolutions.Easy
{
    internal class TakeTwoStones
    {
        internal void TakeTwoStonesSolution()
        {
            int stones = int.Parse(Console.ReadLine());
            if (stones % 2 == 0) Console.Write("Bob");
            else Console.WriteLine("Alice");
        }
    }
}
