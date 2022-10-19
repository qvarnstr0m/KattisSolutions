//Only right output in first test case

using System;

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

            for (int i = 0; i < iterations; i++)
            {
                string[] nextLine = Console.ReadLine().Split(' ');
                bool keepCard = false;
                for (int j = 1; j < int.Parse(nextLine[0]); j++)
                {
                    if (int.Parse(nextLine[j]) == secretCard)
                        keepCard = true;
                }
                if (keepCard == true)
                    Console.WriteLine("KEEP");
                else
                    Console.WriteLine("REMOVE");
            }
        }
    }
}
