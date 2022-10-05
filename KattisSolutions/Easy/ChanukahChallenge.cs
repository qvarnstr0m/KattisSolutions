using System;

namespace KattisSolutions.Easy
{
    internal class ChanukahChallenge
    {
        internal void ChanukahChallengeSolution()
        {
            int dataSets = int.Parse(Console.ReadLine());

            for (int i = 1; i <= dataSets; i++)
            {
                string line = Console.ReadLine();
                string[] split = line.Split(new char[] { ' ' });
                int[] arraySplit = Array.ConvertAll(split, int.Parse);
                int candles = 0;

                for (int j = 1; j <= arraySplit[1]; j++)
                {
                    candles += j + 1;
                }

                Console.WriteLine($"{i} {candles}");
            }
        }
    }
}
