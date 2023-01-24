using System;
using System.Collections.Generic;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class ABC
    {
        internal void ABCSolution()
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>();

            int[] first = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string second = Console.ReadLine();

            Array.Sort(first);

            myDict.Add('A', first[0]);
            myDict.Add('B', first[1]);
            myDict.Add('C', first[2]);

            Console.WriteLine($"{myDict[second[0]]} {myDict[second[1]]} {myDict[second[2]]}");
        }
    }
}
