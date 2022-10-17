using System;

namespace KattisSolutions.Easy
{
    internal class MagicTrick
    {
        internal void MagicTrickSolution()
        {
            string line = Console.ReadLine();
            bool duplicates = false;

            for (int i = 0; i < line.Length; i++)
            {
                char toCheck = line[i];
                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[j] == toCheck) duplicates = true;
                }
            }

            if (duplicates == false) Console.Write("1");
            else Console.Write("0");
        }
    }
}
