using System;

namespace KattisSolutions.Easy
{
    internal class ProvinceAndGold
    {
        internal void ProvinceAndGoldSolution()
        {
            string line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            int gold = int.Parse(split[0]) * 3;
            int silvers = int.Parse(split[1]) * 2;
            int coppers = int.Parse(split[2]);
            int total = gold + silvers + coppers;

            if (total >= 8)
            {
                Console.Write($"Province or ");
            }
            else if (total >= 5)
            {
                Console.Write($"Duchy or ");
            }
            else if (total >= 2)
            {
                Console.Write($"Estate or ");
            }

            if (total >= 6)
            {
                Console.Write($"Gold");
            }
            else if (total >= 3)
            {
                Console.Write($"Silver");
            }
            else if (total >= 0)
            {
                Console.Write($"Copper");
            }
        }
    }
}
