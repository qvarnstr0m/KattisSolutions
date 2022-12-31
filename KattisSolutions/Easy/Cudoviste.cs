using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class Cudoviste
    {
        internal void CudovisteSolution()
        {
            Dictionary<int, int> resultDict = new Dictionary<int, int>()
            {
                {0, 0 },
                {1, 0 },
                {2, 0 },
                {3, 0 },
                {4, 0 },
            };

            int[] table = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string[] map = new string[table[0]];

            for (int i = 0; i < table[0]; i++)
            {
                map[i] = Console.ReadLine();
            }

            for (int i = 0; i < table[0] - 1; i++)
            {

                for (int j = 0; j < table[1] - 1; j++)
                {
                    List<char> car = new List<char>();
                    car.Add(map[i][j]);
                    car.Add(map[i][j + 1]);
                    car.Add(map[i + 1][j]);
                    car.Add(map[i + 1][j + 1]);
                    if (!car.Contains('#'))
                    {
                        resultDict[car.Count(x => x.Equals('X'))]++;
                    }
                }
            }

            foreach (var item in resultDict)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
