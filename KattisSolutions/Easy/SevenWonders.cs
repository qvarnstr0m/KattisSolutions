using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class SevenWonders
    {
        internal void SevenWondersSolution()
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>()
            {
                {'T', 0 },
                {'C', 0 },
                {'G', 0 }
            };
            int finalScore = 0;
            string line = Console.ReadLine();
            foreach (char c in line)
            {
                myDict[c]++;
            }
            foreach (var item in myDict)
            {
                finalScore += item.Value * item.Value;
            }
            int setScore = 7 * myDict.Values.Min();
            Console.WriteLine(finalScore + setScore);
        }
    }
}
