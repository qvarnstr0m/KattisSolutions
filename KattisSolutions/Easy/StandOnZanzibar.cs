using System;

namespace KattisSolutions.Easy
{
    internal class StandOnZanzibar
    {
        internal void StandOnZanzibarSolution()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int immigrantTurtles = 0;
                int[] split = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int j = 1; j < split.Length - 1; j++)
                {
                    if (split[j - 1] * 2 < split[j])
                    {
                        immigrantTurtles += split[j] - split[j - 1] * 2;
                    }
                }
                Console.WriteLine(immigrantTurtles);
            }
        }
    }
}
