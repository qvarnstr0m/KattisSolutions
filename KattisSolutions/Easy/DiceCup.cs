using System;
using System.Collections.Generic;
using System.Linq;

namespace KattisSolutions.Easy
{
    internal class DiceCup
    {
        internal void DiceCupSolution()
        {
            int[] split = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int firstDice = split[0];
            int secondDice = split[1];
            List<int> totals = new List<int>();

            for (int i = 1; i <= firstDice; i++)
            {
                for (int j = 1; j <= secondDice; j++)
                {
                    totals.Add(i + j);
                }
            }

            Dictionary<int, int> totalsDict = new Dictionary<int, int>();

            foreach (var item in totals)
            {
                totalsDict[item] = (!totalsDict.ContainsKey(item)) ? totalsDict[item] = 1 : totalsDict[item] = totalsDict[item] + 1;
            }

            int mostOccuring = totalsDict.Values.Max();

            foreach (var item in totalsDict)
            {
                if (item.Value == mostOccuring) Console.WriteLine(item.Key);
            }
        }
    }
}
