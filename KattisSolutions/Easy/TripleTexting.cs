using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class TripleTexting
    {
        internal void TripleTextingSolution()
        {
            string line = Console.ReadLine();

            List<string> words = new List<string>();

            int iterations = line.Length / 3;

            for (int i = 0; i < line.Length; i += iterations)
            {
                words.Add(line.Substring(i, iterations));
            }

            var groupsWithCounts = from s in words
                                   group s by s into g
                                   select new
                                   {
                                       Item = g.Key,
                                       Count = g.Count()
                                   };
            var groupSorted = groupsWithCounts.OrderByDescending(g => g.Count);
            string mostFrequent = groupSorted.First().Item;

            Console.Write(mostFrequent);
        }
    }
}
