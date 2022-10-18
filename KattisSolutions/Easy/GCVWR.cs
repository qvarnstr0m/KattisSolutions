using System;

namespace KattisSolutions.Easy
{
    internal class GCVWR
    {
        internal void GCVWRSolution()
        {
            string line1 = Console.ReadLine();
            string[] split1 = line1.Split(new char[] { ' ' });
            int g = int.Parse(split1[0]);
            int t = int.Parse(split1[1]);
            int iterations = int.Parse(split1[2]);
            double totalWeight = (g - t) * 0.9d;
            string items = Console.ReadLine();
            string[] itemsSplit = items.Split(new char[] { ' ' });
            for (int i = 0; i < iterations; i++)
            {
                totalWeight -= int.Parse(itemsSplit[i]);
            }
            Console.Write(totalWeight);
        }
    }
}
