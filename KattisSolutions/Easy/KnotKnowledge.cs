using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisSolutions.Easy
{
    internal class KnotKnowledge
    {
        internal void KnotKnowledgeSolution()
        {
            Console.ReadLine();
            int[] needsToLearn = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] alreadyKnows = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            foreach (int knot in needsToLearn)
            {
                if (!alreadyKnows.Contains(knot))
                {
                    Console.Write(knot);
                }
            }
        }
    }
}
