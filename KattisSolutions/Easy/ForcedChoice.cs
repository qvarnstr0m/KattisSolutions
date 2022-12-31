//Only right output in first test case

using System;
using System.Collections.Generic;

namespace KattisSolutions.Easy
{
    internal class ForcedChoice
    {
        internal void ForcedChoiceSolution()
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int cards = int.Parse(line1[0]);
            int secretCard = int.Parse(line1[1]);
            int iterations = int.Parse(line1[2]);
            List<int> shownCards = new List<int>();
            for (int i = 0; i < iterations; i++)
            {
                int[] nextLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int j = 1; j <= nextLine[0]; j++)
                {
                    shownCards.Add(nextLine[j]);
                }
                if (shownCards.Contains(secretCard))
                {
                    Console.WriteLine("KEEP");
                }
                else
                {
                    Console.WriteLine("REMOVE");
                }
                shownCards.Clear();
            }
        }
    }
}
