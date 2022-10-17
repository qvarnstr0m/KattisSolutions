using System;

namespace KattisSolutions.Easy
{
    internal class ElectricalOutlets
    {
        internal void ElectricalOutletsSolution()
        {
            int testCases = int.Parse(Console.ReadLine());
            int totalOutlets = 1;

            for (int i = 0; i < testCases; i++)
            {
                string line = Console.ReadLine();
                string[] split = line.Split(new char[] { ' ' });
                int iterations = int.Parse(split[0]);
                for (int j = 1; j <= iterations; j++)
                {
                    totalOutlets--;
                    totalOutlets += int.Parse(split[j]);
                }
                Console.WriteLine(totalOutlets);
                totalOutlets = 1;
            }
        }
    }
}
