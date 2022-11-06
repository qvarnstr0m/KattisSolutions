using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Bela
    {
        internal void BelaSolution()
        {
            Dictionary<char, int> notDominant = new Dictionary<char, int>()
            {
                {'A', 11 },
                {'K', 4 },
                {'Q', 3 },
                {'J', 2 },
                {'T', 10 },
                {'9', 0 },
                {'8', 0 },
                {'7', 0 }
            };

            Dictionary<char, int> dominant = new Dictionary<char, int>()
            {
                {'A', 11 },
                {'K', 4 },
                {'Q', 3 },
                {'J', 20 },
                {'T', 10 },
                {'9', 14 },
                {'8', 0 },
                {'7', 0 }
            };

            string[] split = Console.ReadLine().Split(' ');
            int iterations = int.Parse(split[0]) * 4;
            char dominantCard = char.Parse(split[1]);
            int totalPoints = 0;

            for (int i = 0; i < iterations; i++)
            {
                string line = Console.ReadLine();
                char value = Convert.ToChar(line[0]);
                char suit = Convert.ToChar(line[1]);

                if (suit == dominantCard)
                {
                    totalPoints += dominant[value];
                }
                else
                {
                    totalPoints += notDominant[value];
                }

            }

            Console.Write(totalPoints);
        }
    }
}
