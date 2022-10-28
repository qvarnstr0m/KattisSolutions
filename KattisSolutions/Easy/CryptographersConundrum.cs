using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class CryptographersConundrum
    {
        internal void CryptographersConundrumSolution()
        {
            string line = Console.ReadLine();
            int days = 0;
            for (int i = 0; i < line.Length; i = i + 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0 && line[i + j] != 'P') days++;
                    else if (j == 1 && line[i + j] != 'E') days++;
                    else if (j == 2 && line[i + j] != 'R') days++;
                }
            }
            Console.WriteLine(days);
        }
    }
}
