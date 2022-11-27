using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KattisSolutions.Easy
{
    internal class StackingCups
    {
        internal void StackingCupsSolution()
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            int iterations = int.Parse(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int number;
                if (int.TryParse(line[0], out number))
                {
                    myDict.Add($"{line[1]}", number / 2);
                }
                else
                {
                    myDict.Add(line[0], int.Parse(line[1]));
                }
            }
            var sortedDict = from entry in myDict orderby entry.Value ascending select entry;
            foreach (var item in sortedDict)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
