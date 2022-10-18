using System;

namespace KattisSolutions.Easy
{
    internal class Planina
    {
        internal void PlaninaSolution()
        {
            int n = int.Parse(Console.ReadLine());
            double x = Math.Pow(2, n) + 1;
            Console.WriteLine(x * x);
        }
    }
}