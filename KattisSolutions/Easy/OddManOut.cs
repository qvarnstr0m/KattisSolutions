using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class OddManOut
    {
        internal static void OddManOutSolution()
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                int cases = int.Parse(Console.ReadLine());
                int[] casesArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                Dictionary<int, int> code = new Dictionary<int, int>();

                foreach (int item in casesArray)
                {
                    if (code.ContainsKey(item)) code[item]++;
                    else code.Add(item, 1);
                }

                Console.WriteLine($"Case #{i + 1}: {code.First(x => x.Value == 1).Key}");
            }
        }
    }
}
