using System;

namespace KattisSolutions.Easy
{
    internal class Betting
    {
        internal void BettingSolution()
        {
            decimal percentage = decimal.Parse(Console.ReadLine());
            Console.WriteLine(100 / percentage);
            Console.WriteLine(100 / (100 - percentage));
        }
    }
}
