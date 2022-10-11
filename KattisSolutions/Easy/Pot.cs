using System;

namespace KattisSolutions.Easy
{
    internal class Pot
    {
        internal void PotSolution()
        {
            int iterations = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < iterations; i++)
            {
                string line = Console.ReadLine();
                double baseNumber = double.Parse(line.Substring(0, line.Length - 1));
                double powNumber = double.Parse(line.Substring(line.Length - 1));
                total += Math.Pow(baseNumber, powNumber);
            }
            Console.Write(total);
        }
    }
}
