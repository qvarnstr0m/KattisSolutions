using System;

namespace KattisSolutions.Easy
{
    internal class Relocation
    {
        internal void RelocationSolution()
        {
            string line1 = Console.ReadLine();
            string[] split1 = line1.Split(new char[] { ' ' });
            int companies = int.Parse(split1[0]);
            int iterations = int.Parse(split1[1]);
            int[] locations = new int[companies];
            string line2 = Console.ReadLine();
            string[] split2 = line2.Split(new char[] { ' ' });
            for (int i = 0; i < companies; i++)
            {
                locations[i] = int.Parse(split2[i]);
            }
            for (int i = 0; i < iterations; i++)
            {
                string line3 = Console.ReadLine();
                string[] split3 = line3.Split(new char[] { ' ' });
                int action = int.Parse(split3[0]);
                int second = int.Parse(split3[1]);
                int third = int.Parse(split3[2]);
                if (action == 1)
                {
                    locations[second - 1] = third;
                }
                else
                {
                    if (locations[second - 1] > locations[third - 1])
                    {
                        Console.WriteLine(locations[second - 1] - locations[third - 1]);
                    }
                    else
                    {
                        Console.WriteLine(locations[third - 1] - locations[second - 1]);
                    }
                }
            }
        }
    }
}
